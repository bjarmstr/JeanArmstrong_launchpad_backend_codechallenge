using LaunchpadCodeChallenge.API.SQSProcessor;
using LaunchpadCodeChallenge.API.SQSProcessor.Interfaces;
using LaunchpadCodeChallenge.Repository;
using LaunchpadCodeChallenge.Repository.Interfaces;
using LaunchpadCodeChallenge.Service;
using LaunchpadCodeChallenge.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace LaunchpadCodeChallenge.API
{

    /// <summary>
    /// Startup class
    /// </summary>
    public class Startup
    {

        /// <summary>
        /// Startup
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Dependency Injection
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureDependencyInjection(IServiceCollection services)
        {
            // Configure Dependency Injection
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ISQSHttpProcessor, SQSHttpProcessor>();
        }

        /// <summary>
        /// Add Services to the app
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Add the following to stop circular reference if department name needs to be included in IEnumerable call
            // services.AddControllers().AddJsonOptions(x =>
            //  x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            ConfigureDependencyInjection(services);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite("LaunchpadSqliteDb"));


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LaunchpadCodeChallenge API", Version = "v1" });
                var apiPath = Path.Combine(System.AppContext.BaseDirectory, "LaunchpadCodeChallenge.Api.xml");
                var modelsPath = Path.Combine(System.AppContext.BaseDirectory, "LaunchpadCodeChallenge.Models.xml");
                c.IncludeXmlComments(apiPath);
                c.IncludeXmlComments(modelsPath);
            });



        }
        /// <summary>
        /// Configure Http request pipeline
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CodeChallenge1 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
