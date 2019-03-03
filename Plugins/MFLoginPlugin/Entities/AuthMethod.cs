using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pGina.Plugin.MFLoginPlugin.Entities;
using System.Data.SQLite;
using log4net;
namespace pGina.Plugin.MFLoginPlugin
{
    class AuthMethod
    {
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public AuthMethod(User user=null) {
			if (user != null) UID = user.UID;
			SQLiteCommand sqlc = new SQLiteCommand("SELECT MAX(AMID) AS MAX_AMID FROM AUTH_METHOD", DBHelper.connection);
			SQLiteDataReader r = sqlc.ExecuteReader();
			r.Read();
			try	{AMID = ulong.Parse(r["MAX_AMID"].ToString()) + 1;} catch (Exception e) { AMID = 0; m_logger.Debug("Unable to create new Auth_method"); }
		}
		public AuthMethod(ulong amid)
		{
			if (amid != 0) AMID = amid;
		}
		public ulong AMID=0;
        public ulong UID=0;
        public Key K1=null;
		public Key K2=null;
		public Key K3=null;
		public Key K4=null;
		public Key K5=null;
		public string Description="Auth method";
        public int Number_of_keys=5; // How many keys are required for a successful auth
		private string Hash="";
		private void ComputeHash() { Hash = "" + AMID + " " + UID; }
		public bool Fill()
		{
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM AUTH_METHOD WHERE AMID=$AMID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$AMID", AMID);
			SQLiteDataReader r = sqlc.ExecuteReader();
			if (r.Read())
			{
				UID = ulong.Parse(r["UID"].ToString());
				try { K1 = Key.DefineKey(ulong.Parse(r["K1"].ToString())); } catch (Exception e) { m_logger.Debug("K1 not loaded"); }
				try { K2 = Key.DefineKey(ulong.Parse(r["K2"].ToString())); } catch (Exception e) { m_logger.Debug("K2 not loaded"); }
				try { K3 = Key.DefineKey(ulong.Parse(r["K3"].ToString())); } catch (Exception e) { m_logger.Debug("K3 not loaded"); }
				try { K4 = Key.DefineKey(ulong.Parse(r["K4"].ToString())); } catch (Exception e) { m_logger.Debug("K4 not loaded"); }
				try { K5 = Key.DefineKey(ulong.Parse(r["K5"].ToString())); } catch (Exception e) { m_logger.Debug("K5 not loaded"); }
				//we don't care if some keys are null
				Description = (string)r["Description"];
				Number_of_keys = int.Parse(r["Number_of_keys"].ToString());
				Hash = (string)r["Hash"];
				return true;
			}
			else
				return false;
		}
		public bool Save()
		{
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM AUTH_METHOD WHERE AMID=$AMID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$AMID", AMID);
			bool exists = (sqlc.ExecuteScalar() != null);
			if (exists)
				sqlc = new SQLiteCommand("UPDATE AUTH_METHOD SET UID=$UID, K1=$K1, K2=$K2, K3=$K3, K4=$K4, K5=$K5, Description=$Description, Number_of_keys=$Number_of_keys, Hash=$Hash WHERE AMID=$AMID", DBHelper.connection);
			else
				sqlc = new SQLiteCommand("INSERT INTO AUTH_METHOD VALUES($AMID, $UID, $K1, $K2, $K3, $K4, $K5, $Description, $Number_of_keys, $Hash)", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$AMID", AMID);
			sqlc.Parameters.AddWithValue("$UID", UID);
			try { sqlc.Parameters.AddWithValue("$K1", K1.KID); } catch { sqlc.Parameters.AddWithValue("$K1", 0); }
			try { sqlc.Parameters.AddWithValue("$K2", K2.KID);} catch { sqlc.Parameters.AddWithValue("$K2", 0); }
			try { sqlc.Parameters.AddWithValue("$K3", K3.KID); } catch { sqlc.Parameters.AddWithValue("$K3", 0); }
			try { sqlc.Parameters.AddWithValue("$K4", K4.KID);} catch { sqlc.Parameters.AddWithValue("$K4", 0); }
			try { sqlc.Parameters.AddWithValue("$K5", K5.KID); } catch { sqlc.Parameters.AddWithValue("$K5", 0); }
			sqlc.Parameters.AddWithValue("$Description", Description);
			sqlc.Parameters.AddWithValue("$Number_of_keys", Number_of_keys);
			
			sqlc.Parameters.AddWithValue("$Hash", Hash);
			return (sqlc.ExecuteNonQuery() == 1);
		}
		public bool Delete() {
			SQLiteCommand sqlc = new SQLiteCommand("DELETE FROM AUTH_METHOD WHERE AMID=$AMID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$AMID", AMID);
			bool deleted = (sqlc.ExecuteScalar() != null);
			return deleted;
		}
		public override string ToString()
		{
			return "" + AMID +" "+Description;
		}
	}
}