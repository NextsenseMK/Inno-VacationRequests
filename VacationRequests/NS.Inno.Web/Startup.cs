﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NS.Inno.Business.Implementations;
using NS.Inno.Business.Interfaces;
using NS.Inno.Data;

namespace NS.Inno.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            InitializeDependencyInjection(services);
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IUserSystem userSystem)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });

            var a = userSystem.GetUser();
        }


        private void InitializeDependencyInjection(IServiceCollection services)
        {
            services.AddTransient<ITeamSystem, TeamSystem>();
            services.AddTransient<IApprovingLevelSystem, ApprovingLevelSystem>();
            services.AddTransient<IEmployeeOverlapPolicySystem, EmployeeOverlapPolicySystem>();
            services.AddTransient<IUserSystem, UserSystem>();
            services.AddTransient<IVacationDaysSystem, VacationDaysSystem>();
            services.AddTransient<IVacationRequestSystem, VacationRequestSystem>();
        }
    }
}