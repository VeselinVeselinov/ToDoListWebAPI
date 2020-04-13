using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.UsersUserGroups;
using ToDoListWebAPI.Business.Processor.UsersUserGroups;
using ToDoListWebAPI.DataAccess.Dao.UsersUserGroups;
using ToDoListWebAPI.Storage.UsersUserGroups;

namespace ToDoListWebAPI.Extensions.UsersUserGroups
{
    public static class UsersUserGroupsDependencies
    {
        public static void RegisterUsersUserGroupsDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUsersUserGroupsData, UsersUserGroupsData>();
            services.AddScoped<IUsersUserGroupsDao, UsersUserGroupsDaoEF>();
            services.AddScoped<IUsersUserGroupsParamConverter, UsersUserGroupsParamConverter>();
            services.AddScoped<IUsersUserGroupsResultConverter, UsersUserGroupsResultConverter>();
            services.AddScoped<IUsersUserGroupsProcessor, UsersUserGroupsProcessor>();
        }
    }
}
