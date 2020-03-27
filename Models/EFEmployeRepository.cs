using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace KostaIS.Models
{
    public class EFEmployeRepository : IEmploye
    {
        private ApplicationDbContext context;
        public EFEmployeRepository(ApplicationDbContext ctx) => context = ctx;        

        public void AddEmploye(Empoyee employe)
        {           
            context.Empoyee.Add(employe);
            context.Database.OpenConnection();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Empoyee ON");
            context.SaveChanges();            
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Empoyee OFF");
            context.Database.CloseConnection();
        }
        public IQueryable<Empoyee> Employers => context.Empoyee;
        public void DeleteEmploye(Empoyee employe)
        {
            context.Empoyee.Remove(employe);
            context.Database.OpenConnection();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Empoyee ON");
            context.SaveChanges();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Empoyee OFF");
            context.Database.CloseConnection();
        }

        public Empoyee GetEmpoyee(decimal key) => context.Empoyee.Find(key);

        public void UpdateEmployee(Empoyee employee)
        {
            context.Empoyee.Update(employee);
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Empoyee ON");
            context.SaveChanges();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Empoyee OFF");
            context.Database.CloseConnection();
        }
    }
}
