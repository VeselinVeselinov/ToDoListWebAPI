using ToDoListWebAPI.Storage.UserGroupStatus;
using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.UserGroupStatus;
using ToDoListWebAPI.Business.Processor.UserGroupStatus;
using ToDoListWebAPI.DataAccess.Dao.UserGroupStatus;

namespace ToDoListWebAPI.Extensions.UserGroupStatus
{
    public static class UserGroupStatusDependencies
    {
        public static void RegisterUserGroupStatusDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserGroupStatusData, UserGroupStatusData>();
            services.AddScoped<IUserGroupStatusDao, UserGroupStatusDaoEF>();
            services.AddScoped<IUserGroupStatusParamConverter, UserGroupStatusParamConverter>();
            services.AddScoped<IUserGroupStatusResultConverter, UserGroupStatusResultConverter>();
            services.AddScoped<IUserGroupStatusProcessor, UserGroupStatusProcessor>();
        }
    }
}
