using NantHealthAuthorize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCr = BCrypt.Net;
using Isopoh.Cryptography.Argon2;

namespace NantHealthAuthorize
{
    public static class LoginLogic
    {
        public static bool ValidCredientials(IUser user,string enteredPassword) {
            if (user == null||enteredPassword == null) {
                throw new ArgumentNullException("Username and password must be supplied");
            }
            return Argon2.Verify(user.password, enteredPassword);
        } 
    }
}
