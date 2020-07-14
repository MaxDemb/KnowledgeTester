using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DAL.EntityFramework.Context;
using DAL.Domain.Entities;
using BLL.Interfaces;
using BLL.Infrastructure.Services;
using DAL.Interfaces;
using DAL.EntityFramework;
using DAL.EntityFramework.Repositories;
using AutoMapper;
using DAL.Interfaces.Repositories;
using DAL.EntityFramework.Repositories.Generic;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using BLL.Infrastructure.AutomapperProfiles;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeTester
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
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AppDbContext>();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutomapperTeacherProfile());
                mc.AddProfile(new AutomapperStudentProfile());
                mc.AddProfile(new AutomapperTestProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            //services.AddIdentityServer()
            //    .AddApiAuthorization<ApplicationUser, AppDbContext>();

            services.AddTransient<ITeacherService, TeacherService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<IResultService, ResultService>();
            //AutomapperTeacherProfile.Configure();


            //services.AddTransient<IQuestionRepository, QuestionRepository>();
            //services.AddTransient<IQuestionRepository, QuestionRepository>();
            //services.AddTransient<IQuestionRepository, QuestionRepository>();
            //services.AddTransient<IQuestionRepository, QuestionRepository>();
            //services.AddTransient<IQuestionRepository, QuestionRepository>();


            services.AddTransient<DbContext,AppDbContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            // services.AddTransient<ITeacherService, TeacherService>();
            services.AddAuthentication()
                .AddIdentityServerJwt();

            
            services.AddControllersWithViews();
            services.AddRazorPages();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseIdentityServer();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default2",
                    pattern: "{controller}/{action=Index}/{id?}/{something}");

                endpoints.MapRazorPages();
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
