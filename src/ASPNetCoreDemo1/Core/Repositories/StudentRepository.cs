using System.Collections.Generic;
using ASPNetCoreDemo1.Core.Interfaces;
using ASPNetCoreDemo1.Core.Models;
using System.Linq;

namespace ASPNetCoreDemo1.Core.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        public Student Add(Student s)
        {
            using (var db = new StudentDbContext())
            {
                db.Students.Add(s);
                db.SaveChanges();
            }
            return s;
        }

        public List<Student> GetAll()
        {
            using (var db = new StudentDbContext())
            {
                return db.Students.ToList();
            }
        }

        public Student Get(string jmbag)
        {
            using (var db = new StudentDbContext())
            {
                return db.Students.Where(s => s.Jmbag == jmbag).FirstOrDefault();
            }
        }
    }


}
