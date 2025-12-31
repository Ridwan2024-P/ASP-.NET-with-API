using BLL.Service;
using DLL.EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspwithApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        DepartmentService Service;
        public DepartmentController(DepartmentService service)
        {
            this.Service = service;
        }

        [HttpGet]
        public List<Department> GetStudents()
        {
            return Service.GetResult();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            {
                Service.CreateDepartment(department);
                return Ok("Data Insert");
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Service.DeleteDepartment(id); 
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(int id,Department department)
        {
            Service.UpdateDepartment(id, department);
            return Ok();

        }


    }

}
