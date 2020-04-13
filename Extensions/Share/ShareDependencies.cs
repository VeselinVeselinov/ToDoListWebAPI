using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.Share;
using ToDoListWebAPI.Business.Processor.Share;
using ToDoListWebAPI.DataAccess.Dao.Share;
using ToDoListWebAPI.Storage.Share;

namespace ToDoListWebAPI.Extensions.Share
{
    public static class ShareDependencies
    {
        public static void RegisterShareDependencies(this IServiceCollection services)
        {
            services.AddScoped<IShareData, ShareData>();
            services.AddScoped<IShareDao, ShareDaoEF>();
            services.AddScoped<IShareResultConverter, ShareResultConverter>();
            services.AddScoped<IShareParamConverter, ShareParamConverter>();
            services.AddScoped<IShareProcessor, ShareProcessor>();
        }
    }
}
