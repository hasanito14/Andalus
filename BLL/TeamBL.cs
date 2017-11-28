using BOL;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class TeamBL
    {
        private TeamDb tdb;

        public TeamBL()
        {
            tdb = new TeamDb();
        }

        public IEnumerable<Team> GetAll()
        {
            return tdb.GetAll();
        }

        public Team GetById(Guid Id)
        {
            return tdb.GetById(Id);
        }

        public bool Add(Team team)
        {
            bool status = false;
            try
            {
                tdb.Insert(team);
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
                tdb.Delete(Id);
                status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
            }

            return status;

        }

        public bool Update(Team team)
        {
            bool status = false;
            try
            {
                tdb.Update(team);
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
