﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cities.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Cities
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IRepository, MemoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Map("/mvcapp", appBuilder => {
                appBuilder.UseStatusCodePages();
                appBuilder.UseDeveloperExceptionPage();
                appBuilder.UseStaticFiles();
                appBuilder.UseMvcWithDefaultRoute();
            });

            //app.UseDeveloperExceptionPage();
            //app.UseStatusCodePages();
            //app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();


        }
    }
}