using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal interface Interface1
    {
        // interface
        interface IUser
        {
            bool UserExists();
            UserType getUserType();
            User GetLoggedInUser();//return current logged in user data from the access token  
        }
        interface IManager : IEmployee
        {
            User GetEmployee(Guid id);
            bool UpdateEmployee(Guid id, User user);
        }
        interface IEmployee : IUser
        {

        }
        interface IAdministrator : IUser
        {
            bool UpdateUser(Guid id, User user);//return true when database query is successful
            bool UpdateUserPermissions(Guid id, UserType userType);
        }
    }
}
