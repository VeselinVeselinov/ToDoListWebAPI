using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.AlertStatus;
using ToDoListWebAPI.Business.Processor.AlertStatus;
using ToDoListWebAPI.DataAccess.Dao.AlertStatus;
using ToDoListWebAPI.Storage.AlertStatus;

namespace ToDoListWebAPI.Extensions.AlertStatus
{
    public static class AlertStatusDependencies
    {
        public static void RegisterAlertStatusDependencies(this IServiceCollection services) 
        {
            services.AddScoped<IAlertStatusData, AlertStatusData>();
            services.AddScoped<IAlertStatusDao, AlertStatusDaoEF>();
            services.AddScoped<IAlertStatusResultConverter, AlertStatusResultConverter>();
            services.AddScoped<IAlertStatusParamConverter, AlertStatusParamConverter>();
            services.AddScoped<IAlertStatusProcessor, AlertStatusProcessor>();
        }
    }
}
