using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.NoteType;
using ToDoListWebAPI.Business.Processor.NoteType;
using ToDoListWebAPI.DataAccess.Dao.NoteType;
using ToDoListWebAPI.Storage.NoteType;

namespace ToDoListWebAPI.Extensions.NoteType
{
    public static class NoteTypeDependencies
    {
        public static void RegisterNoteTypeDependencies(this IServiceCollection services)
        {
            services.AddScoped<INoteTypeData, NoteTypeData>();
            services.AddScoped<INoteTypeDao, NoteTypeDaoEF>();
            services.AddScoped<INoteTypeResultConverter, NoteTypeResultConverter>();
            services.AddScoped<INoteTypeParamConverter, NoteTypeParamConverter>();
            services.AddScoped<INoteTypeProcessor, NoteTypeProcessor>();
        }
    }
}
