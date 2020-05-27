using System.Collections.Generic;
using ToDoListWebAPI.Business.Convertor.Note;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.Note
{
	public interface INoteProcessor:IBaseProcessor<long, NoteParam, NoteResult>
    {
        List<NoteResult> GetByIdAndCategory(long accountId, string categoryName);

        List<NoteResult> GetByIdAndName(long accountId, string name);

        List<NoteResult> GetByIdAndContent(long accountId, string content);

        List<NoteResult> GetByIdAndType(long accountId, string typeName);
    }
}
