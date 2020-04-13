using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Authentication.AuthHandler;
using ToDoListWebAPI.Business.Processor.Authentication;
using ToDoListWebAPI.Authentication.AuthProvider.Common;
using ToDoListWebAPI.Authentication.AuthProvider.BasicAuthentication;
using ToDoListWebAPI.Authentication.AuthProvider.TokenAuthentication;

namespace ToDoListWebAPI.Extensions.Authentication
{
    public static class AuthenticationDependencies
    {
        public static void RegisterAuthenticationDependencies(this IServiceCollection services)
        {
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthHandler>("BasicAuthentication", null);

            services.AddScoped<IBaseAuthProvider<long>, BasicAuthProvider>();
            services.AddScoped<IBaseAuthProvider<long>, TokenAuthProvider>();
            services.AddScoped<IAuthProcessor, AuthProcessor>();
        }
    }
}
