using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.Account;
using ToDoListWebAPI.Business.Processor.Account;
using ToDoListWebAPI.DataAccess.Dao.Account;
using ToDoListWebAPI.Storage.Account;

namespace ToDoListWebAPI.Extensions.Account
{
    public static class AccountDependencies
    {
        public static void RegisterAccountDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAccountDao, AccountDaoEF>();
            services.AddScoped<IAccountData, AccountData>();
            services.AddScoped<IAccountResultConverter, AccountResultConverter>();
            services.AddScoped<IAccountParamConverter, AccountParamConverter>();
            services.AddScoped<IAccountProcessor, AccountProcessor>();
        }
    }
}
