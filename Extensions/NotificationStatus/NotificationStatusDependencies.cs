using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.NotificationStatus;
using ToDoListWebAPI.Business.Processor.NotificationStatus;
using ToDoListWebAPI.DataAccess.Dao.NotificationStatus;
using ToDoListWebAPI.Storage.NotificationStatus;

namespace ToDoListWebAPI.Extensions.NotificationStatus
{
    public static class NotificationStatusDependencies
    {
        public static void RegisterNotificationStatusDependencies(this IServiceCollection services)
        {
            services.AddScoped<INotificationStatusData, NotificationStatusData>();
            services.AddScoped<INotificationStatusDao, NotificationStatusDaoEF>();
            services.AddScoped<INotificationStatusResultConverter, NotificationStatusResultConverter>();
            services.AddScoped<INotificationStatusParamConverter, NotificationStatusParamConverter>();
            services.AddScoped<INotificationStatusProcessor, NotificationStatusProcessor>();
        }
    }
}
