﻿using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlayerDb : DALBase
    {
        public IEnumerable<Player> GetALL()
        {
            return db.Players.ToList();
        }
        /*
        public Role GetByID(Guid Id)
        {
            return db.Roles.Find(Id);
        }
        public void Insert(Role role)
        {

            db.Roles.Add(role);
            Save();
        }
        public void Delete(Guid Id)
        {
            Role role = db.Roles.Find(Id);
            db.Roles.Remove(role);
            Save();
        }
        public void Update(Role role)
        {
            db.Entry(role).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            Save();
            db.Configuration.ValidateOnSaveEnabled = true;
        }
        public void Save()
        {
            db.SaveChanges();
        }
        */
    }
}
