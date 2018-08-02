using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NS.Inno.Business.Implementations;
using NS.Inno.Business.Interfaces;
using NS.Inno.Common;
using NS.Inno.Data;
using NS.Inno.Models;
using NS.Inno.Repository;

namespace NS.Inno.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();

            InitializeDependencyInjection(services);
            services.AddMvc();

            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            services.Configure<ConfigProvider>(Configuration.GetSection(nameof(ConfigProvider)));

            services.AddSingleton(Configuration);

            services.AddDbContext<VacationRequestsContext>(options => options.UseSqlServer("Server = vacationRequests-sql;Database = VacationRequests; Trusted_Connection = True;"));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IUserSystem userSystem)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
            //User user = new User();
            //userSystem.CreateUser(user);
            //var a = userSystem.GetUser(1);
        }


        private void InitializeDependencyInjection(IServiceCollection services)
        {
            services.AddTransient<ITeamSystem, TeamSystem>();
            services.AddTransient<IApprovingLevelSystem, ApprovingLevelSystem>();
            services.AddTransient<IEmployeeOverlapPolicySystem, EmployeeOverlapPolicySystem>();
            services.AddTransient<IUserSystem, UserSystem>();
            services.AddTransient<IVacationDaysSystem, VacationDaysSystem>();
            services.AddTransient<IVacationRequestSystem, VacationRequestSystem>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
