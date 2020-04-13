using ToDoListWebAPI.Business.Convertor.NoteType;
using ToDoListWebAPI.Business.Processor.NoteType;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.NoteType
{
    public class NoteTypeController : BaseController<long, NoteTypeParam, NoteTypeResult, INoteTypeProcessor>
    {
        public NoteTypeController(INoteTypeProcessor processor) : base(processor)
        {
        }
    }
}