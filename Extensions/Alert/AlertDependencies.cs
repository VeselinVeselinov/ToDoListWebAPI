using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.Alert;
using ToDoListWebAPI.Business.Processor.Alert;
using ToDoListWebAPI.DataAccess.Dao.Alert;
using ToDoListWebAPI.Storage.Alert;

namespace ToDoListWebAPI.Extensions.Alert
{
    public static class AlertDependencies
    {
        public static void RegisterAlertDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAlertData, AlertData>();
            services.AddScoped<IAlertDao, AlertDaoEF>();
            services.AddScoped<IAlertResultConverter, AlertResultConverter>();
            services.AddScoped<IAlertParamConverter, AlertParamConverter>();
            services.AddScoped<IAlertProcessor,AlertProcessor>();
        }
    }
}
