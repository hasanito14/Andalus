using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RoleDb role = new RoleDb();

            role.Insert(new Role() { RoleName = "Admin", RoleCode = "A", RoleDescription = "Admin User" });
            role.Insert(new Role() { RoleName = "User", RoleCode = "U", RoleDescription = "Non Admin User" });
            role.Insert(new Role() { RoleName = "Player", RoleCode = "P", RoleDescription = "Non Admin Player User" });
        }
    }
}
