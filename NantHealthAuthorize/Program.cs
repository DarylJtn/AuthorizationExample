// See https://aka.ms/new-console-template for more information
using NantHealthAuthorize;
using NantHealthAuthorize.Models;
while (true) { 
    Console.WriteLine("Enter Username:");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Password:");
    string password = Console.ReadLine();
    DBLogic logic = new DBLogic();
    User user = logic.GetUser(username);
    if (user != null && LoginLogic.ValidCredientials(user, password))
    {
        Console.WriteLine("Login Successful");
    }
    else {
        Console.WriteLine("Login Unsuccessful");
    }
}