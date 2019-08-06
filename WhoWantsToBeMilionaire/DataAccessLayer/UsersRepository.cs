using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeMilionaire.DataAccessLayer
{
   public  class UsersRepository
    {
        MillionaireEntities db;
        
        public UsersRepository()
        {
            db = new MillionaireEntities();
        }

        public void Insert(Users entity)
        {
            Users result = db.Users.Add(entity);
            db.SaveChanges();
            
        }

        public List<Users> List()
        {
            List<Users> result = db.Users.ToList();
            return result;
        }

        public void Delete(int id)
        {
            Users user = db.Users.Where(c => c.id == id).FirstOrDefault();
            db.Users.Remove(user);
            db.SaveChanges();
        }

    }
}
