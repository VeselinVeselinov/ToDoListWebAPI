using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.ShareStatus;
using ToDoListWebAPI.Business.Processor.ShareStatus;
using ToDoListWebAPI.DataAccess.Dao.ShareStatus;
using ToDoListWebAPI.Storage.ShareStatus;

namespace ToDoListWebAPI.Extensions.ShareStatus
{
    public static class ShareStatusDependencies
    {
        public static void RegisterShareStatusDependencies(this IServiceCollection services)
        {
            services.AddScoped<IShareStatusData, ShareStatusData>();
            services.AddScoped<IShareStatusDao, ShareStatusDaoEF>();
            services.AddScoped<IShareStatusResultConverter, ShareStatusResultConverter>();
            services.AddScoped<IShareStatusParamConverter, ShareStatusParamConverter>();
            services.AddScoped<IShareStatusProcessor, ShareStatusProcessor>();
        }
    }
}
