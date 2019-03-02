using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data.SQLite;
using pGina.Plugin.MFLoginPlugin.Entities.Keys;
using log4net;
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
			Key key = null;
			switch (type)
			{
				case "Password": key=new PasswordKey(kid); break;
				case "ConnectedDevice": key= new ConnectedDevice(kid); break;
				case "BluetoothDevice": key = new BluetoothDevice(kid); break;
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
				default: break;
			}
			return key; // get appropriate key class
		}
		public static String[] KeyTypes= { "Password", "ConnectedDevice", "BluetoothDevice"};
        // each key has to provide a key creation window
        public ulong KID;
		public string Description="";
		protected bool Inverted=false;
		protected string Type="";
		protected string Serial=null;
		protected string Password=null;
		protected string Data=null;
		protected string Hash="";

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
		}
		public Key(ulong kid) { KID = kid; }

		public string[] GetInfo() { return null; }
		// management form
		public virtual void AddKey() { m_logger.Debug("Key.AddKey called. That wasn't supposed to happen!"); } 
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
				try { Serial = (string)r["Serial"]; } catch { }; // may be null
				try { Password = (string)r["Password"]; } catch { };// may be null
				try { Data = (string)r["Data"];} catch { };// may be null
				Hash = (string)r["Hash"];
				return true;
			}
			else
				return false;
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
			sqlc.Parameters.AddWithValue("$Hash", Hash);
			return (sqlc.ExecuteNonQuery()==1);
		}
		public void ComputeHash() { Hash = ""+KID; } // !!!!!!!!!!!!
		public bool IsValid()
		{
			string currentHash = Hash;
			ComputeHash();
			return (currentHash == Hash);
		}
		public override string ToString()
		{
			return Type + ": " + Description+ " ("+KID+")";
		}
		public virtual bool CheckKey(string password) { m_logger.Debug("Key.CheckKey called... That wasn't supposed to happen"); return false; }// All _keys_ behave similarly. abstract key is wrong

		//key MAY contain windows password
		public string ReturnWindowsPassword() { return null; }


		public static string GetUniqueKey(int size)
		{
			char[] chars =
				"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
			byte[] data = new byte[size];
			using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
			{
				crypto.GetBytes(data);
			}
			StringBuilder result = new StringBuilder(size);
			foreach (byte b in data)
			{
				result.Append(chars[b % (chars.Length)]);
			}
			return result.ToString();
		}
	}
}
