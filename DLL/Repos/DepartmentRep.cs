using DLL.EF;
using DLL.EF.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repos
{
    public class DepartmentRep
    {
        UMSContext db;
        public DepartmentRep (UMSContext db)
        {
            this.db = db;
        }
        public List<Department> Get()
        {
            return db.Departments.ToList();
        }

        public bool Create (Department department)
        {
            db.Departments.Add(department);
            return db.SaveChanges() > 0;
        }
        public bool Delete( int id)
        {
            var f = db.Departments.Find(id);
            db.Departments.Remove(f);

            return db.SaveChanges()>0;

        }
        public bool Update(int id, Department department)
        {
            var  u= db.Departments.Find(id);
             u.Name= department.Name;
            return db.SaveChanges() > 0;
        }
    }
}
