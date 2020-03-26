using KostaIS.Models;
using Microsoft.AspNetCore.Mvc;


namespace KostaIS.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartment department;
        public DepartmentController(IDepartment department) => this.department = department;
        public ViewResult DepartmentList() => View(department.Departments);
        
        [HttpPost]
        public IActionResult CreateDepartment(Department department)
        {
            this.department.AddDepartment(department);
            return RedirectToAction(nameof(DepartmentList));
        }
        public ViewResult CreateDepartment() => View();
        [HttpPost]
        public IActionResult DeleteDepartment(Department department)
        {
            this.department.DeleteDepartment(department);
            return RedirectToAction(nameof(DepartmentList));
        }
        public ViewResult DeleteDepartment() => View();
    }
}
