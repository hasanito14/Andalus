using BOL;
using DAL;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RoleDb role = new RoleDb();
            /*
            role.Insert(new Role() { RoleName = "Admin", RoleCode = "A", RoleDescription = "Admin User" });
            role.Insert(new Role() { RoleName = "User", RoleCode = "U", RoleDescription = "Non Admin User" });
            role.Insert(new Role() { RoleName = "Player", RoleCode = "P", RoleDescription = "Non Admin Player User" });
            */
            PlayerDb pdb = new PlayerDb();
            pdb.Insert(new Player() { FirstName = "Ghalib", LastName = "Syed", JerseyName = "Syed", DateOfBirth = DateTime.Now, Email = "Syed.test@gmail.com", Password = "123456", RoleId = Guid.Parse("91FEADC8-8D20-406E-870C-CBB5604D3DF4") });
            //UserDb user = new UserDb();
            //user.Insert(new User() { });
        }
    }
}
