using ToDoListWebAPI.Business.Convertor.NoteType;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.NoteType
{
	public interface INoteTypeProcessor:IBaseProcessor<long, NoteTypeParam, NoteTypeResult>
	{
	}
}
