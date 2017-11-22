using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBase
    {
        protected LeagueContext db;

        public DALBase()
        {
            db = new LeagueContext();
        }

    }
}
