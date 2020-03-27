
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace KostaIS.Models
{
    public class EFDepartmentRepository : IDepartment
    {
        private ApplicationDbContext context;
        public EFDepartmentRepository(ApplicationDbContext ctx) => context = ctx;
        
        public void DeleteDepartment(Department department)
        {
            context.Department.Remove(department);
            
            context.SaveChanges();
            
        }

        public void AddDepartment(Department department)
        {
            context.Department.Add(department);
            
            context.SaveChanges();
            
        }
        public void UpdateDepartment(Department department)
        {
            context.Department.Update(department);
            context.SaveChanges();
        }

        public IQueryable<Department> Departments => context.Department.Include(c => c.Employers);
        public Department GetDepartment(Guid key) => context.Department.Find(key);

        
    }
}
