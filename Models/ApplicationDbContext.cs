using Microsoft.EntityFrameworkCore;


namespace KostaIS.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Department> Department { get; set; }
        public DbSet<Empoyee> Empoyee { get; set; }

    }
}
