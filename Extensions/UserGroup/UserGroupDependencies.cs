using ToDoListWebAPI.Storage.UserGroup;
using ToDoListWebAPI.DataAccess.Dao.UserGroup;
using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.UserGroup;
using ToDoListWebAPI.Business.Processor.UserGroup;

namespace ToDoListWebAPI.Extensions.UserGroup
{
    public static class UserGroupDependencies
    {
        public static void RegisterUserGroupDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserGroupData, UserGroupData>();
            services.AddScoped<IUserGroupDao, UserGroupDaoEF>();
            services.AddScoped<IUserGroupParamConverter, UserGroupParamConverter>();
            services.AddScoped<IUserGroupResultConverter, UserGroupResultConverter>();
            services.AddScoped<IUserGroupProcessor, UserGroupProcessor>();
        }
    }
}
