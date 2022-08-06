using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NantHealthAuthorize.Models
{
    internal class User
    {
        public Guid id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
