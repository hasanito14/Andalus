using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class UserDb : DALBase
    {
        public IEnumerable<User> GetALL()
        {
            return db.Users.ToList();
        }
        public User GetByID(Guid Id)
        {
            return db.Users.Find(Id);
        }
        public void Insert(User user)
        {

            db.Users.Add(user);
            Save();
        }
        public void Delete(Guid Id)
        {
            User user = db.Users.Find(Id);
            db.Users.Remove(user);
            Save();
        }
        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
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
