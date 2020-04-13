using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.AccountStatus;
using ToDoListWebAPI.Business.Processor.AccountStatus;
using ToDoListWebAPI.DataAccess.Dao.AccountStatus;
using ToDoListWebAPI.Storage.AccountStatus;

namespace ToDoListWebAPI.Extensions.AccountStatus
{
    public static class AccountStatusDependencies
    {
        public static void RegisterAccountStatusDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAccountStatusData, AccountStatusData>();
            services.AddScoped<IAccountStatusDao, AccountStatusDaoEF>();
            services.AddScoped<IAccountStatusParamConverter, AccountStausParamConverter>();
            services.AddScoped<IAccountStatusResultConverter, AccountStatusResultConverter>();
            services.AddScoped<IAccountStatusProcessor, AccountStatusProcessor>();
        }
    }
}
