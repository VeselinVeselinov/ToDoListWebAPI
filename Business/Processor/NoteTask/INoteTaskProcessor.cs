using ToDoListWebAPI.Business.Convertor.NoteTask;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.NoteTask
{
	public interface INoteTaskProcessor:IBaseProcessor<long, NoteTaskParam, NoteTaskResult>
    {
	}
}
