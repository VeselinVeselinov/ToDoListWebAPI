using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.Notification;
using ToDoListWebAPI.Business.Processor.Notification;
using ToDoListWebAPI.DataAccess.Dao.Notification;
using ToDoListWebAPI.Storage.Notification;

namespace ToDoListWebAPI.Extensions.Notification
{
    public static class NotificationDependencies
    {
        public static void RegisterNotificationDependencies(this IServiceCollection services) 
        {
            services.AddScoped<INotificationData, NotificationData>();
            services.AddScoped<INotificationDao, NotificationDaoEF>();
            services.AddScoped<INotificationResultConverter, NotificationResultConverter>();
            services.AddScoped<INotificationParamConverter, NotificationParamConverter>();
            services.AddScoped<INotificationProcessor, NotificationProcessor>();
        }
    }
}
