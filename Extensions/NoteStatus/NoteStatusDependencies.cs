using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.NoteStatus;
using ToDoListWebAPI.Business.Processor.NoteStatus;
using ToDoListWebAPI.DataAccess.Dao.NoteStatus;
using ToDoListWebAPI.Storage.NoteStatus;

namespace ToDoListWebAPI.Extensions.NoteStatus
{
    public static class NoteStatusDependencies
    {
        public static void RegisterNoteStatusDependencies(this IServiceCollection services)
        {
            services.AddScoped<INoteStatusData, NoteStatusData>();
            services.AddScoped<INoteStatusDao, NoteStatusDaoEF>();
            services.AddScoped<INoteStatusResultConverter, NoteStatusResultConverter>();
            services.AddScoped<INoteStatusParamConverter, NoteStatusParamConverter>();
            services.AddScoped<INoteStatusProcessor, NoteStatusProcessor>();
        }
    }
}
