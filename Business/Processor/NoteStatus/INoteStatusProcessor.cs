using ToDoListWebAPI.Business.Convertor.NoteStatus;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.NoteStatus
{
	public interface INoteStatusProcessor:IBaseProcessor<long, NoteStatusParam, NoteStatusResult>
    {
	}
}
