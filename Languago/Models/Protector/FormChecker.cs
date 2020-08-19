using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

using Languago.Models.DataStructures;
using Languago.Models.orm;

namespace Languago.Models.Protector
{
    public static class FormChecker
    {
        private static string SaltAndHashPassword(string password, string salt)
        {
            var sha = SHA512.Create();
            var saltedPassword = password + salt;

            //Zamień string na UTF8, domyslnie stringi w C# są w Unicode
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
            //Hash wygenerowany posiada "-" pomiędzy znakami, trzeba się tego pozbyć
            return (BitConverter.ToString(hash).Replace("-",""));
        }
        public static long checkPassword(string userName, string userPassword, LanguagoContext db)
        {
                SHA512 shaM = new SHA512Managed();

                var checkuser = db.Users
                                .Where(u => u.Login == userName);
                foreach (User u in checkuser)
                {
                    userPassword = SaltAndHashPassword(userPassword, u.Salt);
                    if (userPassword == u.Password) return u.UserID;
                    else return -1;
                }
                return -1;
          
        }

    }
}

