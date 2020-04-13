using ToDoListWebAPI.Business.Convertor.NoteTask;
using ToDoListWebAPI.Business.Processor.NoteTask;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.NoteTask
{
    public class NoteTaskController : BaseController<long, NoteTaskParam, NoteTaskResult, INoteTaskProcessor>
    {
        public NoteTaskController(INoteTaskProcessor processor) : base(processor)
        {
        }
    }
}