using BOL;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class RoleBL
    {
        private RoleDb rdb;

        public RoleBL()
        {
            rdb = new RoleDb();
        }

        public IEnumerable<Role> GetAll()
        {
            return rdb.GetALL();
        }

        public Role GetById(Guid Id)
        {
            return rdb.GetByID(Id);
        }

        public bool Add(Role role)
        {
            bool status = false;
            try
            {
                rdb.Insert(role);
                status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
            }

            return status;


        }


        public bool Delete(Guid Id)
        {
            bool status = false;
            try
            {
                rdb.Delete(Id);
                status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
            }

            return status;

        }

        public bool Update(Role role)
        {
            bool status = false;
            try
            {
                rdb.Update(role);
                status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
            }

            return status;
        }

    }
}
