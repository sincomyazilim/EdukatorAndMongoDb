using Edukator.BusinessLayer.Abstract;
using Edukator.BusinessLayer.Concrete;
using Edukator.DataAccessLayer;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.EntityFramework;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver;
using System;



namespace EdukatorMongo.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

           
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            var mongoDbSettings = Configuration.GetSection("DatabaseSettings").Get<DatabaseSettings>();


            services.AddSingleton(mongoDbSettings);

            services.AddSingleton<IMongoClient>(new MongoClient(mongoDbSettings.ConnectionString));

            services.AddSingleton<IMongoDatabase>(provider =>
            {
                var client = provider.GetRequiredService<IMongoClient>();
                return client.GetDatabase(mongoDbSettings.DatabaseName);
            });

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                 .AddMongoDbStores<ApplicationUser, ApplicationRole, Guid>(mongoDbSettings.ConnectionString, mongoDbSettings.DatabaseName);







            services.AddControllersWithViews();
            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>(); //baglandı
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICourseService, CourseManager>(); //baglandı
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>(); //baglandı

            services.AddScoped<IFeatureDal, EFeatureDal>();
            services.AddScoped<IFeatureService, FeatureManager>(); //baglandı
            services.AddScoped<IAboutGridDal, EfAboutGridDal>();
            services.AddScoped<IAboutGridService, AboutGridManager>(); //baglandı

            services.AddScoped<IAboutUsImageDal, EfAboutUsImageDal>();
            services.AddScoped<IAboutUsImageService, AboutUsImageManager>(); //baglandı

            services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            services.AddScoped<ISubscribeService, SubscribeManager>(); //baglandı

            //services.AddScoped<ICourseRegisterDal, EfCourseRegisterDal>();
            //services.AddScoped<ICourseRegisterService, CourseRegisterManager>(); //baglandı

            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>(); //baglandı

            services.AddMvc(conf =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();

                conf.Filters.Add(new AuthorizeFilter(policy));//
            });
            //123
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.LoginPath = "/Account/Login/";
            });
            //123


        }
       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Default}/{action=Index}/{id?}");
            });
        }
    }
}
