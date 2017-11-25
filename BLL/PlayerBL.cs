using BOL;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PlayerBL
    {
        private PlayerDb pdb;

        public PlayerBL()
        {
            pdb = new PlayerDb();
        }

        public IEnumerable<Player> GetAll()
        {
            return pdb.GetALL();
        }

        public Player GetById(Guid Id)
        {
            return pdb.GetByID(Id);
        }

        public bool Add(Player player)
        {
            bool status = false;
            try
            {
                pdb.Insert(player);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }

            return status;


        }

        public Player GetByEmail(string email)
        {
            return pdb.GetByEmail(email);
        }

        public bool Delete(Guid Id)
        {
            bool status = false;
            try
            {
                pdb.Delete(Id);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }

            return status;

        }

        public bool Update(Player player)
        {
            bool status = false;
            try
            {
                pdb.Update(player);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }

            return status;
        }




    }
}
