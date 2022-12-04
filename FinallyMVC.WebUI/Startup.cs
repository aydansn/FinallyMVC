using BigOn.Domain.AppCode.Providers;
using FinallyMVC.Domain.AppCode.Providers;
using FinallyMVC.Domain.AppCode.Services;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities.Membership;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace FinallyMVC.WebUI
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(
                cfg =>
            {
                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider());

                var policyRule = new AuthorizationPolicyBuilder()
                              .RequireAuthenticatedUser()
                              .Build();


                cfg.Filters.Add(new AuthorizeFilter(policyRule));
            }
            );


            services.AddRouting(cfg =>
            {
                cfg.LowercaseUrls = true;
            });

            services.AddDbContext<AppDbContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("cString"));
            });

            services.AddIdentity<FinallymvcUser, FinallymvcRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(cfg =>
            {
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireDigit = false;
                cfg.Password.RequiredLength = 3;
                cfg.Password.RequiredUniqueChars = 1; //aAa

                cfg.SignIn.RequireConfirmedPhoneNumber = false;
                cfg.SignIn.RequireConfirmedAccount = false;
                cfg.SignIn.RequireConfirmedEmail = true;

                cfg.Lockout.MaxFailedAccessAttempts = 3;

                cfg.User.RequireUniqueEmail = true;
                //cfg.User.AllowedUserNameCharacters = "";
            });

            services.ConfigureApplicationCookie(cfg =>
            {

                cfg.Cookie.Name = "Finallymvc";
                cfg.LoginPath = "/signin.html";
                cfg.LogoutPath = "/logout.html";
                cfg.AccessDeniedPath = "/accessdenied.html";

                cfg.ExpireTimeSpan = new TimeSpan(0, 15, 0);
                cfg.Cookie.HttpOnly = true;
            });

            services.AddScoped<UserManager<FinallymvcUser>>();
            services.AddScoped<SignInManager<FinallymvcUser>>();
            services.AddScoped<RoleManager<FinallymvcRole>>();
           services.AddScoped<IClaimsTransformation, AppClaimsProvider>();
            //services.AddScoped(typeof(IClaimsTransformation),typeof(AppClaimsProvider));

            services.AddAuthentication();
            services.AddAuthorization(
                cfg =>
            {
                foreach (var item in AppClaimsProvider.policies)
                {
                    cfg.AddPolicy(item, p =>
                    {
                        //p.RequireClaim(item, "1");

                        p.RequireAssertion(handler =>
                        {
                            return handler.User.IsInRole("sa")
                            || handler.User.HasClaim(c => c.Type.Equals(item) && c.Value.Equals("1"))
                            ;
                        });

                    });
                }
            }
            );
            services.Configure<CryptoServiceOptions>(cfg =>
            {
                configuration.GetSection("cryptograpy").Bind(cfg);
            });
            services.AddSingleton<ICryptoService,CryptoService>();

            services.Configure<EmailServiceOptions>(cfg =>
            {
                configuration.GetSection("emailAccount").Bind(cfg);
            });
            services.AddSingleton<IEmailService,EmailService>();

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            var assemblies = AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(a => a.FullName.StartsWith("FinallyMVC."))
                .ToArray();

            services.AddMediatR(assemblies);

          services.AddValidatorsFromAssemblies(assemblies, ServiceLifetime.Singleton);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


           app.SeedMembership();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(name: "defaultAdmin",
                    areaName: "Admin",
                    pattern: "admin/{controller=home}/{action=index}/{id?}");

                endpoints.MapControllerRoute(name: "default",
                    pattern: "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
