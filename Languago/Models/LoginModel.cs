using System;
using System.Collections.Generic;
using System.Text;
using Languago.Models.orm;
using Languago.Models.Protector;

namespace Languago.Models
{
    public class LoginModel
    {

        public long checkCredentials(string login, string password, LanguagoContext db)
        {
            /* There might be error */
            long UserID = FormChecker.checkPassword(login, password, db);
            return UserID;
        }

    }
}
