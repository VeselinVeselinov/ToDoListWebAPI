using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.Extensions.Common;
using Microsoft.Extensions.Configuration;
using ToDoListWebAPI.Extensions.ApiSession;
using ToDoListWebAPI.Extensions.Authentication;
using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.DataAccess.Dao.Common.Context;
using ToDoListWebAPI.Authentication.Common.Hash.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ToDoListWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        readonly string ApiSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.RegisterAuthenticationDependencies();
            services.Configure<SecretKeySettings>(Configuration.GetSection("SecretKeySettings"));

            services.RegisterApiSessionDependencies();

            services.AddDbContext<ToDoListDbContext>(options => options
                .UseSqlServer(Configuration.GetConnectionString("ToDoListDefault"))
                .UseLazyLoadingProxies())
                .AddScoped<DbContext, ToDoListDbContext>();

            services.RegisterSystemDependencies();

            services.AddHttpContextAccessor();

            services.RegisterSwaggerConfiguration();

            services.AddCors(options =>
            {
                options.AddPolicy(ApiSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins(
                        Configuration.GetSection("ApiSpecificOrigins")
                        .Get<string[]>())
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            services.AddMvc(options =>
            {
                options.SslPort = 44321;
                options.Filters.Add(new RequireHttpsAttribute());
            });

            services.AddAntiforgery(options =>
            {
                options.Cookie.Name = "_af";
                options.Cookie.HttpOnly = true;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                options.HeaderName = "X-XSRF-TOKEN";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c => 
            { 
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ToDoList API");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseHttpsRedirection(); //-- for https redirections

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors(ApiSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
