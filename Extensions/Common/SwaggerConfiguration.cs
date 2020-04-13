using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ToDoListWebAPI.Extensions.Common
{
    public static class SwaggerConfiguration
    {
        public static void RegisterSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ToDoList API",
                    Description = "A simple ToDoList ASP.NET Core Web API",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Veselin Veselinov",
                        Email = string.Empty,
                        Url = new Uri("https://swagger.io/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://example.com/license"),
                    }
                });

                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath, true);
            });
        }
    }
}
