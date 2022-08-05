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

        }
        interface IManager : IEmployee
        {
            bool EditEmployee(Guid id, EmployeeData data);//return true if data is successfully updated
        }
        interface IEmployee : IUser
        {
            EmployeeData getEmployee(Guid? Id,Department department);//Get employee for current user or specified user if their department has permission to access it
            Department getDepartment();
        }
        interface IAdministrator : IUser
        {
            UserData UserData(Guid id);//get user data for any users 
            bool EditUser(Guid id, UserData data);//return true if data is successfully updated
            bool UpdatePermission(Guid id, EmployeeType type);//pass in new permissions for the supplied user. return true if data is updated
        }
    }
    public class EmployeeData { }
    public enum EmployeeType { }
    public class UserData { }
    public enum Department { }
    
}
