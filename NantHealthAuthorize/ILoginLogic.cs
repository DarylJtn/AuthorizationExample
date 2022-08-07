using NantHealthAuthorize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantHealthAuthorize
{
    public interface ILoginLogic
    {
        public bool ValidCredientials(IUser user, string enteredPassword);
    }
}
