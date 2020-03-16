using KostaIS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KostaIS.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartment department;
        public DepartmentController(IDepartment department) => this.department = department;
        public ViewResult DepartmentList() => View(department.Departments);
        
    }
}
