using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.Category;
using ToDoListWebAPI.Business.Processor.Category;
using ToDoListWebAPI.DataAccess.Dao.Category;
using ToDoListWebAPI.Storage.Category;

namespace ToDoListWebAPI.Extensions.Category
{
    public static class CategoryDependencies
    {
        public static void RegisterCategoryDependencies(this IServiceCollection services)  
        {
            services.AddScoped<ICategoryData, CategoryData>();
            services.AddScoped<ICategoryDao, CategoryDaoEF>();
            services.AddScoped<ICategoryResultConverter, CategoryResultConverter>();
            services.AddScoped<ICategoryParamConverter, CategoryParamConverter>();
            services.AddScoped<ICategoryProcessor, CategoryProcessor>();
        }
    }
}
