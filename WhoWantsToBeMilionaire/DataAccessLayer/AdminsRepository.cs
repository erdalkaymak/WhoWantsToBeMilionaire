using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeMilionaire.DataAccessLayer
{
    
    public class AdminsRepository
    {
        MillionaireEntities db;

        public AdminsRepository()
        {
            db = new MillionaireEntities();
        }

        public bool isLogin(string u,string p)
        {
            
            List<Admins> result = db.Admins.Where(c => c.Password == p && c.userName == u).ToList();

            if (result.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
