using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Processor.User;
using ToDoListWebAPI.DataAccess.Dao.User;
using ToDoListWebAPI.Storage.User;

namespace ToDoListWebAPI.Extensions.User
{
    public static class UserDependencies
    {
        public static void RegisterUserDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserData, UserData>();
            services.AddScoped<IUserDao, UserDaoEF>();
            services.AddScoped<IUserResultConverter, UserResultConverter>();
            services.AddScoped<IUserParamConverter, UserParamConverter>();
            services.AddScoped<IUserProcessor, UserProcessor>();
        }
    }
}
