using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeamDb : DALBase
    {
        public IEnumerable<Team> GetAll()
        {
            return db.Teams.ToList();
        }
        public Team GetById(Guid Id)
        {
            return db.Teams.Find(Id);
        }

        public Team GetByEmail(string captainName)
        {
            return db.Teams.Where(x => x.CaptainName == captainName).FirstOrDefault();
        }
        public void Insert(Team team)
        {

            db.Teams.Add(team);
            Save();
        }
        public void Delete(Guid Id)
        {
            Team team = db.Teams.Find(Id);

            if (team != null)
            {
                db.Teams.Remove(team);
            }

            Save();
        }
        public void Update(Team team)
        {
            db.Entry(team).State = EntityState.Modified;
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
