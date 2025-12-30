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

    }
}
