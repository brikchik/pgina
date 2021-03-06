﻿using System;
using System.Data.SQLite;
using log4net;
using pGina.Plugin.MFLoginPlugin.Entities.Keys;
// Key class encapsulates all operations with keys
// May be used to determine which key type to use
namespace pGina.Plugin.MFLoginPlugin
{
    public class Key
    {
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public static Key DefineKey(ulong kid)
		{
			string type = "";
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM KEYS WHERE KID=$KID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$KID", kid);
			SQLiteDataReader r = sqlc.ExecuteReader();
			if (r.Read())
			{
				type = (string)r["Type"];
			}
            r.Close();
			Key key = null;
			switch (type)
			{
				case "Password": key=new PasswordKey(kid); break;
				case "ConnectedDevice": key= new ConnectedDevice(kid); break;
				case "BluetoothDevice": key = new BluetoothDevice(kid); break;
				case "HttpRequest": key = new HttpRequestKey(kid); break;
                case "EncryptedPasswordFileKey": key = new EncryptedPasswordFileKey(kid); break;
				case "ETokenKey": key = new ETokenKey(kid); break;
				case "FaceRecognitionKey": key = new FaceRecognitionKey(kid); break;
				default:break;
			}
			if(key!=null)key.Fill();
			return key;
		}
		public static Key DefineKey(string type)
		{
			Key key = new Key(); // Get new key id
			switch (type)
			{
				case "Password": key = new PasswordKey(key.KID); break;
				case "ConnectedDevice": key = new ConnectedDevice(key.KID); break;
				case "BluetoothDevice": key = new BluetoothDevice(key.KID); break;
				case "HttpRequest": key = new HttpRequestKey(key.KID); break;
                case "EncryptedPasswordFileKey": key = new EncryptedPasswordFileKey(key.KID); break;
				case "ETokenKey": key = new ETokenKey(key.KID); break;
				case "FaceRecognitionKey": key = new FaceRecognitionKey(key.KID); break;
				default: key = null; m_logger.Error("Unable to recognize key type: "+type); break;
			}
			return key; // get appropriate key class
		}
		public static String[] KeyTypes= { "Password", "ConnectedDevice", "BluetoothDevice", "HttpRequest", "EncryptedPasswordFileKey", "ETokenKey", "FaceRecognitionKey"};

        public ulong KID;
		public string Description="";
		public bool Inverted=false;
		protected string Type="";
		public string Serial=null;
		public string Password=null;
		public string Data=null;
		protected string Hash="";
		/* Configuration feature for some key types */
		public bool IsConfigurable = false;
		public virtual void Configure() {}
		/* */
		public new String GetType() { return Type; }
		public Key()
		{
			SQLiteCommand sqlc = new SQLiteCommand("SELECT MAX(KID) AS MAX_KID FROM KEYS", DBHelper.connection);
			SQLiteDataReader r = sqlc.ExecuteReader();
			r.Read();
			try {
			KID = ulong.Parse(r["MAX_KID"].ToString()) + 1;
			}
			catch { KID = 1; }
            r.Close();
		}
		public Key(ulong kid) { KID = kid; }
		// management form
		// each key has to provide a key creation window
		public virtual bool AddKey(string userName) { m_logger.Debug("Key.AddKey called. That wasn't supposed to happen!"); return false; } 
		public bool Fill()
		{
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM KEYS WHERE KID=$KID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$KID", KID);
			SQLiteDataReader r = sqlc.ExecuteReader();
            if (r.Read())
            {
                Description = (string)r["Description"];
                Inverted = (bool)r["Inverted"];
                Type = (string)r["Type"];
                try { Serial = (string)r["Serial"]; }
                catch { }; // may be null
                try { Password = (string)r["Password"]; }
                catch { };// may be null
                try { Data = (string)r["Data"]; }
                catch { };// may be null
                Hash = (string)r["Hash"];
                r.Close();
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
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM KEYS WHERE KID=$KID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$KID", KID);
			bool exists = (sqlc.ExecuteScalar() != null);
			if (exists)
				sqlc = new SQLiteCommand("UPDATE KEYS SET KID=$KID, Description=$Description,Inverted=$Inverted, Type=$Type, Serial=$Serial, Password=$Password,Data=$Data,Hash=$Hash WHERE KID=$KID", DBHelper.connection);
			else
				sqlc = new SQLiteCommand("INSERT INTO KEYS VALUES($KID, $Description,$Inverted, $Type, $Serial, $Password,$Data,$Hash)", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$KID", KID);
			sqlc.Parameters.AddWithValue("$Description", Description);
			sqlc.Parameters.AddWithValue("$Inverted", Inverted);
			sqlc.Parameters.AddWithValue("$Type", Type);
			sqlc.Parameters.AddWithValue("$Serial", Serial);
			sqlc.Parameters.AddWithValue("$Password", Password);
			sqlc.Parameters.AddWithValue("$Data", Data);
            ComputeHash();
			sqlc.Parameters.AddWithValue("$Hash", Hash);
			return (sqlc.ExecuteNonQuery()==1);
		}
		public bool Remove()
		{
			SQLiteCommand sqlc = new SQLiteCommand("DELETE FROM KEYS WHERE KID=$KID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$KID", KID);
			bool success = (sqlc.ExecuteNonQuery() == 1);
			return success;
		}
        public void ComputeHash() { Hash = Shared.Hashed(Description + Type + Inverted + KID + Serial + Password+ Data); }
        public bool IsValid()
        {
            string currentHash = Hash;
            ComputeHash();
            return (currentHash == Hash);
        }
		public override string ToString()
		{
			String type = Type + " (" + KID + ")" + ": " + Description;
			if (Serial != "" && Serial!=null) type += "   SN: " + Serial;
			return type; //serial added if exists
		}
		public virtual bool CheckKey(string password) { m_logger.Debug("Key.CheckKey called... That wasn't supposed to happen"); return false; }// All _keys_ behave similarly. abstract key is wrong

		//key MAY contain windows password
		public virtual string ReturnWindowsPassword() { return null; }
        // it is used only if the plugin database has no password
	}
}
