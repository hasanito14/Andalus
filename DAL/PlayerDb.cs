using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class PlayerDb : DALBase
    {
        public IEnumerable<Player> GetALL()
        {
            return db.Players.ToList();
        }
        public Player GetByID(Guid Id)
        {
            return db.Players.Find(Id);
        }

        public Player GetByEmail(string email)
        {
            return db.Players.Where(x => x.Email == email).FirstOrDefault();
        }
        public void Insert(Player player)
        {

            db.Players.Add(player);
            Save();
        }
        public void Delete(Guid Id)
        {
            Player player = db.Players.Find(Id);
            db.Players.Remove(player);
            Save();
        }
        public void Update(Player player)
        {
            db.Entry(player).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            Save();
            db.Configuration.ValidateOnSaveEnabled = true;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
