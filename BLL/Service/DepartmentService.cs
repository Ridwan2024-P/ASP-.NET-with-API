using DLL.EF.Models;

using DLL.Repos;


namespace BLL.Service
{
    public class DepartmentService
    {
        DepartmentRep Rep;
        public DepartmentService (DepartmentRep Rep)
        {
            this.Rep = Rep;
        }
        public List<Department> GetResult()
        {
            return Rep.Get();
        }
         public bool CreateDepartment(Department department)
        {
            return Rep.Create(department);
        }

        public bool DeleteDepartment(int id)
        {
            return Rep.Delete(id);
        }
        public bool UpdateDepartment(int id, Department department)
        {

            return Rep.Update(id, department);
        }
        
    }
}
