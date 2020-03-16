
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
            context.SaveChanges();
        }
        public IQueryable<Empoyee> Employers => context.Empoyee;
        public void DeleteEmploye(Empoyee employe)
        {
            context.Empoyee.Remove(employe);
            context.SaveChanges();
        }
    }
}
