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
            EmployeeData getEmployee(Guid? Id,Department department);//get employee data if employee is reporting to them, If no Id is supplied return current user employee data
            bool EditEmployee(Guid id, EmployeeData data);//return true if data is successfully updated
        }
        interface IEmployee : IUser
        {
            EmployeeData getEmployee(Guid? Id,Department department);//get employee data for current logged in user or specified user if they are in the HR department
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
