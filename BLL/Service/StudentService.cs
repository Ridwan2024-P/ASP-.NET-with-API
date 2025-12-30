using DLL.EF.Models;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class StudentService
    {
        StudentRepo Repo;
        public StudentService(StudentRepo Repo)
        {
            this.Repo = Repo;
        }
        public List<Student> GetStudents()
        {
            return Repo.Get(); 
        }

    }
}
