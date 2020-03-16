
using KostaIS.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KostaIS
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("TestDB")));
            services.AddTransient<IDepartment,EFDepartmentRepository>();
            services.AddTransient<IEmploye, EFEmployeRepository>();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvc(
                routes =>
                {
                    routes.MapRoute(name: "Employe", template: "{controller=Employe}/{action=EmployersList}/{id?}");
                    routes.MapRoute(name: "Department", template: "{controller=Department}/{action=DepartmentList}/{id?}");
                    
                   
                });
            app.UseStatusCodePages();
            
        }
    }
}
