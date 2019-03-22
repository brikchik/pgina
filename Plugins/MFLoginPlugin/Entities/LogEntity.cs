using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

// log entity is configurable. can be changed.

namespace pGina.Plugin.MFLoginPlugin.Entities
{
    class LogEntity
    {
        public LogEntity(User user, AuthMethod authmethod, bool success) 
        {
            SQLiteCommand sqlc = new SQLiteCommand("SELECT MAX(LEID) AS MAX_LEID FROM LOGIN_ATTEMPTS", DBHelper.connection);
            SQLiteDataReader r = sqlc.ExecuteReader();
            r.Read();
            try
            {
                LEID = ulong.Parse(r["MAX_LEID"].ToString()) + 1;
            }
            catch { LEID = 1; }
            UID = user.UID;
            Name = user.Name;
            AMID = authmethod.AMID;
            AMDescription = authmethod.Description;
            KeysUsed = "";
            KeysUsed += (authmethod.K1 == null) ? "" : "--->" + authmethod.K1.ToString();
            KeysUsed += (authmethod.K2 == null) ? "" : "--->" + authmethod.K2.ToString();
            KeysUsed += (authmethod.K3 == null) ? "" : "--->" + authmethod.K3.ToString();
            KeysUsed += (authmethod.K4 == null) ? "" : "--->" + authmethod.K4.ToString();
            KeysUsed += (authmethod.K5 == null) ? "" : "--->" + authmethod.K5.ToString();
            Success = success;
        }
        public LogEntity(ulong leid)
        {
            LEID = leid;
        }
        public override string ToString()
        {
            string result="";
            result += "User '"+Name + "' ";
            result += "tried to log with '"+AMDescription + "' ";
            result += Success?"and succeeded":"and failed";
            result += " at "+Time.ToString() + ";  ";
            result += "Keys:"+KeysUsed;
            result += "  #LEID:" + LEID + "#AMID:" + AMID + "#UID:" + UID;
            return result;
        }

        ulong LEID = 0; // Log entity ID
        ulong UID = 0;
        string Name = null;
        ulong AMID = 0;
        string AMDescription = null;
        string KeysUsed = null;
        bool Success = false;
        DateTime Time = DateTime.Now;
        String Hash = "";
        public void ComputeHash() { Hash = Shared.Hashed(""+LEID+UID+Name+AMID+AMDescription+KeysUsed+Success+Time); }
        public bool IsValid()
        {
            string currentHash = Hash;
            ComputeHash();
            return (currentHash == Hash);
        }
        public bool Fill()
        {
            SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM LOGIN_ATTEMPTS WHERE LEID=$leid", DBHelper.connection);
            sqlc.Parameters.AddWithValue("$leid", LEID);
            SQLiteDataReader r = sqlc.ExecuteReader();
            if (r.Read())
            {
                UID = ulong.Parse(r["UID"].ToString());
                Name = r["Name"].ToString();
                AMID = ulong.Parse(r["AMID"].ToString());
                AMDescription = r["AMDescription"].ToString();
                KeysUsed = r["KeysUsed"].ToString();
                Success = (bool)r["Success"];
                Time = (DateTime)r["Time"];
                Hash = (string)r["Hash"];
                if (!IsValid()) return false;
                return true;
            }
            else
                return false;
        }
        public bool Save()
        {
            SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM LOGIN_ATTEMPTS WHERE LEID=$leid", DBHelper.connection);
            sqlc.Parameters.AddWithValue("$leid", LEID);
            bool exists = (sqlc.ExecuteScalar() != null);
            if (exists) return false; // logs have to remain constant
            sqlc = new SQLiteCommand("INSERT INTO LOGIN_ATTEMPTS VALUES($LEID, $UID, $Name, $AMID, $AMDescription, $KeysUsed, $Success, $Time, $Hash)", DBHelper.connection);
            sqlc.Parameters.AddWithValue("$LEID", LEID);
            sqlc.Parameters.AddWithValue("$AMID", AMID);
            sqlc.Parameters.AddWithValue("$UID", UID);
            sqlc.Parameters.AddWithValue("$AMDescription", AMDescription);
            sqlc.Parameters.AddWithValue("$KeysUsed", KeysUsed);
            sqlc.Parameters.AddWithValue("$Name", Name);
            sqlc.Parameters.AddWithValue("$Success", Success);
            sqlc.Parameters.AddWithValue("$Time", Time);
            ComputeHash();
            sqlc.Parameters.AddWithValue("$Hash", Hash);
            return (sqlc.ExecuteNonQuery() == 1);
        }
        public bool Delete()
        {
            SQLiteCommand sqlc = new SQLiteCommand("DELETE FROM LOGIN_ATTEMPTS WHERE LEID=$LEID", DBHelper.connection);
            sqlc.Parameters.AddWithValue("$LEID", LEID);
            bool deleted = (sqlc.ExecuteScalar() != null);
            return deleted;
        }
    }
}
