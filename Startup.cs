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

            app.UseHttpsRedirection();

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
