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

        [HttpPost]
        public IActionResult Create(Student student)
        {
            studentService.CreateStudent(student);
            return Ok("creating");
        }

        [HttpPut]

        public IActionResult Update(int id, Student student)
        {
            studentService.UpdateStudent(id, student);
            return Ok();

        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            studentService.DeleteStudent(id);
            return Ok();
        }

    }
}
