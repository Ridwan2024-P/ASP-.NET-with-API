using BLL.Service;
using DLL.EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspwithApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentService studentService;
        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }
        [HttpGet]
        public List<Student> Get()
        {
            return studentService.GetStudents();
        }
    }
}
