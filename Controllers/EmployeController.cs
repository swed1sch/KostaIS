using KostaIS.Models;
using Microsoft.AspNetCore.Mvc;


namespace KostaIS.Controllers
{
    public class EmployeController : Controller
    {
        private IEmploye employe;
        public EmployeController(IEmploye employe) => this.employe = employe;

        public ViewResult EmployersList() => View(employe.Employers);
        [HttpPost]
        public IActionResult Create(Empoyee empoyee)
        {
            employe.AddEmploye(empoyee);
            return RedirectToAction(nameof(EmployersList));
        }
        [HttpPost]
        public IActionResult Delete(Empoyee empoyee)
        {
            employe.DeleteEmploye(empoyee);
            return RedirectToAction(nameof(EmployersList));
        }
        public IActionResult Create() => View();

        
    }
}
