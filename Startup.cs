using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using CheckMyVehicle.Models;

namespace CheckMyVehicle
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<CheckMyVehicleContext>(opt => 
            //     opt.UseInMemoryDatabase("CheckMyVehicle"));
            
            // services.AddDbContext<CheckMyVehicleContext>(opt => 
            //     opt.UseMySQL("server=localhost;database=sonar;uid=sonar;pwd=sonar"));

            services.AddDbContext<CheckMyVehicleContext>(opt => 
                opt.UseMySQL(Configuration.GetConnectionString("Default")));
            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // var DB = app.ApplicationServices.GetRequiredService<CheckMyVehicleContext>();
            // DB.Database.EnsureCreated();
        }
    }
}
