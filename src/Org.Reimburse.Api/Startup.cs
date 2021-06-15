using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Org.Reimburse.Api.Controllers;
using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Repository_Interfaces;
using Org.Reimburse.Data._Context;
using Org.Reimburse.Data.Repository;
using Org.Reimburse.Infrastructure.Business;

namespace Org.Reimburse.Api
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
            services.AddDbContext<OrgDbContext>(option =>
            {
                option.UseInMemoryDatabase("OrgDb");
            });

            services.AddTransient<DbContext, OrgDbContext>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeBusiness, EmployeeBusiness>();
            services.AddTransient<IClaimCourseRepository, ClaimCourseRepository>();
            services.AddTransient<IClaimCourseBusiness, ClaimCourseBusiness>();
            services.AddTransient<IMonthlyPaidSalaryRepository, MonthlyPaidSalaryRepository>();
            services.AddTransient<IMonthlyPaidSalaryBusiness, MonthlyPaidSalaryBusiness>();


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
