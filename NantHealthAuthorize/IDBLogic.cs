using NantHealthAuthorize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantHealthAuthorize
{
    internal interface IDBLogic
    {
        public bool authenticate(string username, string password);
        public User? GetUser(string? username);
    }
}
