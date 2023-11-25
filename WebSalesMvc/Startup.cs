using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebSalesMvc.Data;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;
using WebSalesMvc.Services;
using System.Globalization;
using Microsoft.AspNetCore.Identity;
using System.Net.PeerToPeer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace WebSalesMvc
{
    public class Startup
    {
        public class CustomIdentityErrorDescriber : IdentityErrorDescriber
        {
            public override IdentityError DuplicateEmail(string Email)
            {
                return new IdentityError
                {
                    Code = nameof(DuplicateEmail),
                    Description = $"O Email {Email} já está em uso."
                };
            }
            public override IdentityError DuplicateUserName(string userName)
            {
                return new IdentityError
                {
                    Code = nameof(DuplicateUserName),
                    Description = string.Empty
                };
            }
        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<WebSalesMvcContext>
        {
            public WebSalesMvcContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<WebSalesMvcContext>();
                var connectionString = configuration.GetConnectionString("WebSalesMvcContext");

                builder.UseMySql(connectionString);

                return new WebSalesMvcContext(builder.Options);
            }
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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<WebSalesMvcContext>(options =>
                  options.UseMySql(Configuration.GetConnectionString("WebSalesMvcContext"), builder => builder.MigrationsAssembly("WebSalesMvc")));
            services.AddScoped<SellerService>();
            services.AddScoped<DepartmentService>();
            services.AddScoped<SalesRecordService>();
            services.AddScoped<CategoryService>();

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("WebSalesMvcContext"), builder =>
              builder.MigrationsAssembly("WebSalesMvc")));

            services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders()
            .AddErrorDescriber<CustomIdentityErrorDescriber>();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddScoped<UserManager<User>>();
            services.AddScoped<SignInManager<User>>();

            services.Configure<IdentityOptions>(options =>
            {
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var brl = new CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(brl),
                SupportedCultures = new List<CultureInfo> { brl },
                SupportedUICultures = new List<CultureInfo> { brl }
            };
            
            app.UseRequestLocalization(localizationOptions);    

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
                     template: "{controller=Users}/{action=Login}/{id?}");
            });

        }
    }
}
