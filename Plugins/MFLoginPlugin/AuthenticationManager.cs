using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using pGina.Shared.Types;

namespace pGina.Plugin.MFLoginPlugin
{
    class AuthenticationManager
    {
        public static bool Authenticate(UserInformation userInfo)
        {
            DBHelper dbh=new DBHelper();
            // get data from DB
            // get auth methods for the user
            // check every key
            // return result

            // get password if it's stored in a key
            // that's how it works:
            IKey pk = new PasswordKey();
            pk.AddKey("2");
            IKey usbd = new USBDevice();
            if (pk.ReturnPassword()!=null) userInfo.Password=pk.ReturnPassword();
            if (usbd.ReturnPassword() != null) userInfo.Password = usbd.ReturnPassword();
            //
            // last returned password is used

            return true;
        }
    }
}
