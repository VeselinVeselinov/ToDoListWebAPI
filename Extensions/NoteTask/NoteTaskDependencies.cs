using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Business.Convertor.NoteTask;
using ToDoListWebAPI.Business.Processor.NoteTask;
using ToDoListWebAPI.DataAccess.Dao.NoteTask;
using ToDoListWebAPI.Storage.NoteTask;

namespace ToDoListWebAPI.Extensions.NoteTask
{
    public static class NoteTaskDependencies
    {
        public static void RegisterNoteTaskDependencies(this IServiceCollection services)
        {
            services.AddScoped<INoteTaskData, NoteTaskData>();
            services.AddScoped<INoteTaskDao, NoteTaskDaoFile>();
            services.AddScoped<INoteTaskResultConverter, NoteTaskResultConverter>();
            services.AddScoped<INoteTaskParamConverter, NoteTaskParamConverter>();
            services.AddScoped<INoteTaskProcessor, NoteTaskProcessor>();
        }
    }
}
