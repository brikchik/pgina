using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using pGina.Shared.Types;
using pGina.Shared.Interfaces;
using pGina.Plugin.MFLoginPlugin.Entities.Keys;

namespace pGina.Plugin.MFLoginPlugin
{
    class AuthenticationManager
    {
        public static BooleanResult Authenticate(UserInformation userInfo)
        {
            DBHelper dbh=new DBHelper();
            User user = dbh.GetUser(userInfo.Username);
            if (user == null)
            {
                return new BooleanResult { Success = false, Message = "User doesn't exist" };
            }
            AuthMethod[] am = dbh.GetAuthMethods(user);
            for (int i = 0; i < am.Length; i++)
            {
                KeySet ks = am[i].ks;
                int number_of_valid_keys = 0;
                int number_of_keys_required = am[i].number_of_keys;
                string usedKeys="";
                for (int j = 0; i < 5; i++)
                {
                    IKey ik = ks.Keys[j];
                    bool valid=ik.CheckKey(userInfo.Password);
                    if (valid)
                    {
                        usedKeys+=ik.Type()+"->";
                        number_of_valid_keys++;
                    }
                    // get password if it's stored in a key
                    // last returned password is used
                    if (ik.ReturnPassword() != null) userInfo.Password = ik.ReturnPassword();
                }
                if (number_of_valid_keys >= number_of_keys_required)
                {
                    return new BooleanResult { Success = true, Message="Logged via: "+usedKeys };
                }
            }
            return new BooleanResult { Success=false, Message="Failed to authenticate you"};
        }
    }
}