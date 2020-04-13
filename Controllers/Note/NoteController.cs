using ToDoListWebAPI.Business.Convertor.Note;
using ToDoListWebAPI.Business.Processor.Note;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.Note
{
    public class NoteController : BaseController<long, NoteParam, NoteResult, INoteProcessor>
    {
        public NoteController(INoteProcessor processor) : base(processor)
        {
        }
    }
}