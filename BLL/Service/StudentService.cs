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

        public bool CreateStudent(Student student)
        {
            return Repo.Create(student);
        }
        public bool UpdateStudent(int id,Student student) 
            {
            return Repo.Update(id,student);

            }
        public bool DeleteStudent(int id)
        {
            return Repo.Delete(id);
        }

    }
}
