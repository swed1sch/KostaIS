﻿
using Microsoft.EntityFrameworkCore;
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

        public IQueryable<Department>Departments => context.Department.Include(c=>c.Employers);

        
    }
}
