using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.UserStatus;
using ToDoListWebAPI.Business.Processor.UserStatus;
using ToDoListWebAPI.DataAccess.Dao.UserStatus;
using ToDoListWebAPI.Storage.UserStatus;

namespace ToDoListWebAPI.Extensions.UserStatus
{
    public static class UserStatusDependencies
    {
        public static void RegisterUserStatusDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserStatusData, UserStatusData>();
            services.AddScoped<IUserStatusDao, UserStatusDaoEF>();
            services.AddScoped<IUserStatusResultConverter, UserStatusResultConverter>();
            services.AddScoped<IUserStatusParamConverter, UserStatusParamConverter>();
            services.AddScoped<IUserStatusProcessor, UserStatusProcessor>();
        }
    }
}
