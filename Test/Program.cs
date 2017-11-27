using BLL;
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
            // check for existing role before insert
            role.Insert(new Role() { RoleName = "Admin", RoleCode = "A", RoleDescription = "Admin User" });
            role.Insert(new Role() { RoleName = "User", RoleCode = "U", RoleDescription = "Non Admin User" });
            role.Insert(new Role() { RoleName = "Player", RoleCode = "P", RoleDescription = "Non Admin Player User" });
            */

            //Check for existing Team
            TeamDb team = new TeamDb();
            team.Insert(new Team()
            {
                Name = "Humble",
                CaptainName = "Ali",
                PlayerName1 = "Jahed",
                PlayerName2 = "Othman",
                PlayerName3 = "Arnel",
                PlayerName4 = "Muamer",
                PlayerName5 = "Ira",
                Points = 4,
                wins = 2

            });

            /*
            PlayerBL pdb = new PlayerBL();
            var result = pdb.Add(new Player() { FirstName = "Ghalib", LastName = "Syed", JerseyName = "Syed", DateOfBirth = DateTime.Now, Email = "Syed.test@gmail.com", Password = "123456", RoleId = Guid.Parse("221A8738-416F-434E-8563-7328DB629C08") });
            pdb.Add(new Player() { FirstName = "Hasan", LastName = "Khan", JerseyName = "Abu Musab", DateOfBirth = DateTime.Now, Email = "Hasan.syl@gmail.com", Password = "123456", RoleId = Guid.Parse("221A8738-416F-434E-8563-7328DB629C08") });
            Console.WriteLine(result);*/
            //UserDb user = new UserDb();
            //user.Insert(new User() { });
        }
    }
}
