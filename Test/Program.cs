using DAL;

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
*?        
        }
    }
}
