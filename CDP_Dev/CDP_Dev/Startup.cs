using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CDP_Dev.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CDP.Core;
using CDP.Service.Training;
using CDP.Data.Training;
using CDP.Service.Users;
using CDP.Data.Users;
using CDP.Service.Skills;
using CDP.Data.Skills;
using CDP.Service.Allocations;
using CDP.Service.Mentors;
using CDP.Data.Allocations;
using CDP.Data.Mentors;
using CDP.Data.Internals;
using CDP.Service.Internals;
using CDP.Data.Calendars;
using CDP.Service.Calendars;
using System.IO;
using CDP_Dev.PdfProvider;
using CDP.Service.Aspirations;
using CDP.Data.Aspirations;
using CDP.Data.Logs;
using CDP.Service.Logs;
using CDP.Data.Common;
using CDP.Service.Common;
using AspNetCorePdf.PdfProvider;
using CDP.Data.Reports;
using CDP.Service.Reports;

namespace CDP_Dev
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

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => { options.SignIn.RequireConfirmedEmail = false; options.SignIn.RequireConfirmedPhoneNumber = false; })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //        services.AddIdentity<AppUser, IdentityRole>()
            //.AddEntityFrameworkStores<ApplicationDbContext>();
            //services.AddIdentity<AppUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver
                    = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            });
            //services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            services.AddScoped<IPdfSharpService, PdfSharpService>();
            services.AddScoped<IMigraDocService, MigraDocService>();

            services.Configure<ReadConfig>(Configuration.GetSection("Data"));
            services.AddSingleton<ITraining, Training>();
            services.AddSingleton<ISkill, Skill>();
            services.AddSingleton<IAllocation, Allocation>();
            services.AddSingleton<IMentor, Mentor>();
            services.AddSingleton<IInternal, Internal>();
            services.AddSingleton<ICalendar, Calendar>();
            services.AddSingleton<IAspiration, Aspiration>();
            services.AddSingleton<ILog, Log>();
            services.AddSingleton<ICommon, Common>();
            services.AddSingleton<IUser, User>();
            services.AddSingleton<IReport, Report>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
