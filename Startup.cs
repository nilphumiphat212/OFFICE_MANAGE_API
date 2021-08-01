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
using Npgsql.EntityFrameworkCore.PostgreSQL;
using MySql.EntityFrameworkCore.Extensions;
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

        public void ConfigureServices(IServiceCollection services)
        {
            IConfigurationSection appSettings = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettings);
            services.PostConfigure<AppSettings>(options => { });

            string databaseProvider = appSettings.GetValue<string>("DatabaseProvider");

            switch (databaseProvider)
            {
                case "postgresql":
                    services.AddDbContext<DatabaseContext>(options =>
                    {
                        options.UseNpgsql(Configuration.GetConnectionString("postgresql_connection"));
                    });
                    break;
                case "mysql":
                    services.AddDbContext<DatabaseContext>(options => {
                        options.UseMySQL(Configuration.GetConnectionString("mysql_connection"));
                    });
                    break;
                default:
                    services.AddDbContext<DatabaseContext>(options =>
                    {
                        options.UseSqlServer(Configuration.GetConnectionString("sqlserver_connection"));
                    });
                    break;
            }

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "office_manage_api", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy(cors, builder =>
                {
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

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "office_manage_api v1"));
            }

            app.UseCors(cors);

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
