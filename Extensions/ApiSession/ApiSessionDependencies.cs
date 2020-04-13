using ToDoListWebAPI.Storage.ApiSession;
using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.DataAccess.Dao.ApiSession;
using ToDoListWebAPI.Business.Convertor.ApiSession;
using ToDoListWebAPI.Business.Processor.ApiSession;

namespace ToDoListWebAPI.Extensions.ApiSession
{
    public static class ApiSessionDependencies
    {
        public static void RegisterApiSessionDependencies(this IServiceCollection services)
        {
            services.AddScoped<IApiSessionData, ApiSessionData>();
            services.AddScoped<IApiSessionDao, ApiSessionDaoEF>();
            services.AddScoped<IApiSessionParamConverter, ApiSessionParamConverter>();
            services.AddScoped<IApiSessionResultConverter, ApiSessionResultConverter>();
            services.AddScoped<IApiSessionProcessor, ApiSessionProcessor>();

        }
    }
}
