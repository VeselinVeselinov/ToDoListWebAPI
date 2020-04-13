using ToDoListWebAPI.Business.Convertor.NoteStatus;
using ToDoListWebAPI.Business.Processor.NoteStatus;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.NoteStatus
{
    public class NoteStatusController : BaseController<long, NoteStatusParam, NoteStatusResult, INoteStatusProcessor>
    {
        public NoteStatusController(INoteStatusProcessor processor) : base(processor)
        {
        }
    }
}