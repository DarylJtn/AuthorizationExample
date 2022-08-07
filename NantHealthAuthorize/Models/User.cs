using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NantHealthAuthorize.Models
{
    public class User : IUser
    {
        public Guid id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public ILoginLogic LoginLogic { get; set; } = new LoginLogic();
    }
}
}
