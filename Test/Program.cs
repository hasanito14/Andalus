using BLL;
using BOL;

using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //RoleDb role = new RoleDb();
            /*
            role.Insert(new Role() { RoleName = "Admin", RoleCode = "A", RoleDescription = "Admin User" });
            role.Insert(new Role() { RoleName = "User", RoleCode = "U", RoleDescription = "Non Admin User" });
            role.Insert(new Role() { RoleName = "Player", RoleCode = "P", RoleDescription = "Non Admin Player User" });
            */
            PlayerBL pdb = new PlayerBL();
            var result = pdb.Add(new Player() { FirstName = "Ghalib", LastName = "Syed", JerseyName = "Syed", DateOfBirth = DateTime.Now, Email = "Syed.test@gmail.com", Password = "123456", RoleId = Guid.Parse("221A8738-416F-434E-8563-7328DB629C08") });
            pdb.Add(new Player() { FirstName = "Hasan", LastName = "Khan", JerseyName = "Abu Musab", DateOfBirth = DateTime.Now, Email = "Hasan.syl@gmail.com", Password = "123456", RoleId = Guid.Parse("221A8738-416F-434E-8563-7328DB629C08") });
            Console.WriteLine(result);
            //UserDb user = new UserDb();
            //user.Insert(new User() { });
        }
    }
}
