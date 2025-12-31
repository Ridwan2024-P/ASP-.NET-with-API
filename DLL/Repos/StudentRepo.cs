using DLL.EF;
using DLL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repos
{
  public class StudentRepo
    {
        UMSContext db;
        public StudentRepo(UMSContext db) {
            this.db = db;
        }
    public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public bool Create(Student student)
        {
            db.Students.Add(student);
            return db.SaveChanges() > 0;
        }
        public bool Update(int id, Student student)
        {
            var f = db.Students.Find(id);
            f.Name = student.Name;
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            db.Departments.Find(id);
            return db.SaveChanges() > 0;
        }


    }
}
