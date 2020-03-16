using KostaIS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KostaIS.Controllers
{
    public class EmployeController : Controller
    {
        private IEmploye employe;
        public EmployeController(IEmploye employe) => this.employe = employe;

        public ViewResult EmployersList() => View(employe.Employers);

        
    }
}
