using KostaIS.Models;
using Microsoft.AspNetCore.Mvc;
using System;

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
        public IActionResult UpdateDepartment(Guid key)
        {
            return View(department.GetDepartment(key));
        }
        [HttpPost]
        public IActionResult UpdateDepartment(Department department)
        {
            this.department.UpdateDepartment(department);
            return RedirectToAction(nameof(DepartmentList));
        }
    }
}
