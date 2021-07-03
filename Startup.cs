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
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using office_manage_api.Configure;
using office_manage_api.Services.Interfaces;
using office_manage_api.Services;

namespace office_manage_api
{
    public class Startup
    {
        private string cors = "cors";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            IConfigurationSection appSettings = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettings);
            services.PostConfigure<AppSettings>(options => {});

            services.AddDbContext<DatabaseContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("db_connection"));
            });
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "office_manage_api", Version = "v1" });
            });

            services.AddCors(options => {
                options.AddPolicy(cors, builder => {
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                    builder.AllowAnyOrigin();
                });
            });
            

            services.AddSingleton<IJwtService, JwtService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IWorkingTimeService, WorkingTimeService>();
            services.AddScoped<IUserService, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "office_manage_api v1"));
            }

            app.UseCors(cors);

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
