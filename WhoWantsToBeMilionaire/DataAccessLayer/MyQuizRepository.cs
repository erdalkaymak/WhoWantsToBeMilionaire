using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeMilionaire.DataAccessLayer
{
    
    public class MyQuizRepository
    {
        MillionaireEntities db;
        public MyQuizRepository()
        {
            db = new MillionaireEntities();
        }
        public MyQuiz Search(int id)
        {
            MyQuiz result = db.MyQuiz.Where(c => c.Id == id).FirstOrDefault();
            return result;
        }

        public List<int>  ListId()
        {
            
            List<int> kat1 = (from d in db.MyQuiz
                                orderby Guid.NewGuid()
                                where d.level == 1|| d.level == 2|| d.level == 3
                              select d.Id ).Take(3).ToList();

            List<int> kat2 = (from d in db.MyQuiz
                              orderby Guid.NewGuid()
                              where d.level == 4 || d.level == 5 || d.level == 6
                              select d.Id).Take(3).ToList();

            List<int> kat3 = (from d in db.MyQuiz
                              orderby Guid.NewGuid()
                              where d.level == 7 || d.level == 8 
                              select d.Id).Take(3).ToList();

            List<int> kat4 = (from d in db.MyQuiz
                              orderby Guid.NewGuid()
                              where  d.level == 9|| d.level == 10
                              select d.Id).Take(3).ToList();

            List<int> result = new List<int>();
            for(int i = 0; i < 3; i++)
            {
                result.Add(kat1[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                result.Add(kat2[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                result.Add(kat3[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                result.Add(kat4[i]);
            }
            return result;



        }

        public List<MyQuiz> List()
        {
            List<MyQuiz> result = db.MyQuiz.ToList();
            return result;
        }

        public void Delete(int id)
        {
            MyQuiz result = db.MyQuiz.Where(c => c.Id == id).FirstOrDefault();
            db.MyQuiz.Remove(result);
            db.SaveChanges();
        }

        public void Insert(MyQuiz entity)
        {
            MyQuiz result = db.MyQuiz.Add(entity);
            db.SaveChanges();
        }

        public MyQuiz Update(MyQuiz entity)
        {
            MyQuiz result = db.MyQuiz.Where(c => c.Id == entity.Id).FirstOrDefault();

            result.question = entity.question;
            result.A = entity.A;
            result.B = entity.B;
            result.C = entity.C;
            result.D = entity.D;
            result.trueAnswer = entity.trueAnswer;
            result.level = entity.level;

            db.SaveChanges();

            return result;
        }

    }
}
