using ToDoListWebAPI.Business.Convertor.Note;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.Note
{
	public interface INoteProcessor:IBaseProcessor<long, NoteParam, NoteResult>
    {
	}
}
