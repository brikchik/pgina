using System;
using System.Data.SQLite;
using System.DirectoryServices;
using System.IO;
using log4net;
using pGina.Shared.Settings;
using pGina.Shared.Types;

namespace pGina.Plugin.MFLoginPlugin.Entities
{
	public class User
    {
        public ulong UID;
        public string Name;
		public String Role;
        private string Hash="";
		public string WindowsPassword=null; // REAL windows password
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public void ComputeHash() { Hash = Shared.Hashed(Name + UID + Role + WindowsPassword); }
        public bool IsValid()
        {
            string currentHash = Hash;
            ComputeHash();
            return (currentHash == Hash);
        }
        public User(ulong uid, string name, string role="User", string password="Password") 
        { UID = uid; Name = name; Role = role; WindowsPassword = password; ComputeHash(); } //creation
        public User(ulong uid) { UID = uid;}//database item
		public User()
		{

                SQLiteCommand sqlc = new SQLiteCommand("SELECT MAX(UID) AS MAX_UID FROM USERS", DBHelper.connection);
                SQLiteDataReader r = sqlc.ExecuteReader();
                r.Read();
                try
                {
                    UID = ulong.Parse(r["MAX_UID"].ToString()) + 1;
                }
                catch { UID = 1; }
                r.Close();
		}
		public override string ToString() { return Name; }
		public bool FillByName(string name)
		{
                SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM USERS WHERE NAME=$NAME", DBHelper.connection);
                sqlc.Parameters.AddWithValue("$NAME", name);
                SQLiteDataReader r = sqlc.ExecuteReader();
                if (r.Read())
                {
                    UID = ulong.Parse(r["UID"].ToString());
                    Name = (string)r["Name"];
                    Role = (string)r["Role"];
                    if (r["WindowsPassword"] != System.DBNull.Value) WindowsPassword = (string)r["WindowsPassword"];
                    Hash = (string)r["Hash"];
					r.Close();
                    if (WindowsPassword == "") WindowsPassword = null;
                    if (!IsValid()) return false;
					return true;
                }
                else
                {
                    r.Close();
                    return false;
                }
        }
		public bool Fill()
		{
                SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM USERS WHERE UID=$UID", DBHelper.connection);
                sqlc.Parameters.AddWithValue("$UID", UID);
                SQLiteDataReader r = sqlc.ExecuteReader();
                if (r.Read())
                {
                    Name = (string)r["Name"];
                    Role = (string)r["Role"];
                    if (r["WindowsPassword"] != System.DBNull.Value) WindowsPassword = (string)r["WindowsPassword"];
                    Hash = (string)r["Hash"];
					r.Close();
                    if (WindowsPassword == "") WindowsPassword = null;
                    if (!IsValid()) return false;
					return true;
                }
                else
                {
                    r.Close();
                    return false;
                }
		}
		public bool Save()
		{
                try
                {
                    SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM USERS WHERE UID=$UID", DBHelper.connection);
                    sqlc.Parameters.AddWithValue("$UID", UID);
                    bool exists = (sqlc.ExecuteScalar() != null);
                    if (exists)
                        sqlc = new SQLiteCommand("UPDATE USERS SET UID=$UID, Name=$Name,Role=$Role, WindowsPassword=$WindowsPassword, Hash=$Hash WHERE UID=$UID", DBHelper.connection);
                    else
                        sqlc = new SQLiteCommand("INSERT INTO USERS VALUES($UID, $Name,$Role, $WindowsPassword, $Hash)", DBHelper.connection);
                    sqlc.Parameters.AddWithValue("$UID", UID);
                    sqlc.Parameters.AddWithValue("$Name", Name);
                    sqlc.Parameters.AddWithValue("$Role", Role);
                    sqlc.Parameters.AddWithValue("$WindowsPassword", (WindowsPassword==null)?"":WindowsPassword);
                    ComputeHash();
                    sqlc.Parameters.AddWithValue("$Hash", Hash);
				return (sqlc.ExecuteNonQuery() == 1);
                }
                catch (Exception ex)
                {
                    m_logger.Error(ex.Message);
                    return false;
                }
            
		}
		public bool Remove()
		{
            try
            {
                LogEntity le = new LogEntity(this, "Removed from MFLogin", true);
                le.Save();
                SQLiteCommand sqlc = new SQLiteCommand("DELETE FROM USERS WHERE UID=$UID", DBHelper.connection);
                sqlc.Parameters.AddWithValue("$UID", UID);
                bool success = (sqlc.ExecuteNonQuery() == 1);
                sqlc = new SQLiteCommand("DELETE FROM AUTH_METHODS WHERE UID=$UID", DBHelper.connection);
                sqlc.Parameters.AddWithValue("$UID", UID);
                return success;
            }
            catch (Exception ex) { m_logger.Error(ex.Message); return false; }
		}

		public bool ExistsInSystem()
		{
            return Abstractions.WindowsApi.pInvokes.UserExists(Name);
		}
		public bool AddToSystem()
		{
            if (Abstractions.WindowsApi.pInvokes.UserADD(Name, WindowsPassword, "pGina created"))
            {
            LogEntity le = new LogEntity(this, "Created", true);
            le.Save();
			}
            else
            { m_logger.Error("Unable to create user "+Name); return false; }
			return true;
		}
        public bool AddToPGina()
        {
            try
            {
                DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                DirectoryEntry user = directoryEntry.Children.Find(Name, "user");
                user.Invoke("Put", new object[] { "Description", "pGina created" });
                user.CommitChanges();
            }
            catch (Exception e) { m_logger.Error(e.Message); return false; }
                LogEntity le = new LogEntity(this, "Added to MFLogin", true);
                le.Save();
            return true;
        }
		public bool NewPassword()
		{
            if (Abstractions.WindowsApi.pInvokes.ValidateUser(Name, "", WindowsPassword))
            {
                string newWindowsPassword = Shared.GetUniqueKey(Shared.INTERNAL_USER_PASSWORD_LENGTH);
                Abstractions.WindowsApi.pInvokes.UserChangePassword("", Name, WindowsPassword, newWindowsPassword);
                WindowsPassword = newWindowsPassword;
            }
            else
            {
                try
                {
                    WindowsPassword = Shared.GetUniqueKey(Shared.INTERNAL_USER_PASSWORD_LENGTH);
                    DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                    DirectoryEntry user = directoryEntry.Children.Find(Name, "user");
                    user.Invoke("SetPassword", new Object[] { WindowsPassword });
                    user.CommitChanges();
                    Save();
                }
                catch (Exception e) { m_logger.Error(e.Message); return false; }
            }
            LogEntity le = new LogEntity(this, "Got a new internal password", true);
            le.Save();
			return true;
		}
		public BooleanResult RemoveFromSystem()
		{
            if (Abstractions.WindowsApi.pInvokes.UserDel(Name))
            {
                LogEntity le = new LogEntity(this, "Removed from Windows", true);
                le.Save();
                return new BooleanResult() { Success = true };
            }
            else
                return new BooleanResult { Success = false };
		}
		public BooleanResult RemoveProfile()
		{
            try
            {
                Abstractions.WindowsApi.pInvokes.DeleteProfile(Abstractions.Windows.Security.GetSIDFromName(Name));
            }
            catch (Exception ex) { return new BooleanResult() { Success = false, Message = ex.Message }; }
            return new BooleanResult() { Success = true };
		}
		public bool MakeAdmin(bool admin)
		{
            
            DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            DirectoryEntry currentUser = null;
            String action = admin ? "Add" : "Remove";
            try
            {
                currentUser = directoryEntry.Children.Find(Name, "user");
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                // user not found
                AddToSystem();
                currentUser = directoryEntry.Children.Find(Name, "user");
            }
			try
			{
				DirectoryEntry grp = directoryEntry.Children.Find("Administrators", "group");
				if (grp != null) grp.Invoke(action, new object[] { currentUser.Path.ToString() });
			}
			catch (Exception e) { m_logger.Error("Administrators... " + e.Message); }
			try
			{
				DirectoryEntry grp = directoryEntry.Children.Find("Администраторы", "group");
				if (grp != null) grp.Invoke(action, new object[] { currentUser.Path.ToString() });
			}
			catch (Exception e) { m_logger.Error("Администраторы... " + e.Message); }

                LogEntity le = new LogEntity(this, "Is administrator", admin);
                le.Save();
			return true;
		}
	}
}
