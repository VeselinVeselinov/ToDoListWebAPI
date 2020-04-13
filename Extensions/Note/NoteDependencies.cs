using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.Note;
using ToDoListWebAPI.Business.Processor.Note;
using ToDoListWebAPI.DataAccess.Dao.Note;
using ToDoListWebAPI.Storage.Note;

namespace ToDoListWebAPI.Extensions.Note
{
    public static class NoteDependencies
    {
        public static void RegisterNoteDependencies(this IServiceCollection services)
        {
            services.AddScoped<INoteData, NoteData>();
            services.AddScoped<INoteDao, NoteDaoEF>();
            services.AddScoped<INoteResultConverter, NoteResultConverter>();
            services.AddScoped<INoteParamConverter, NoteParamConverter>();
            services.AddScoped<INoteProcessor, NoteProcessor>();
        }
    }
}
