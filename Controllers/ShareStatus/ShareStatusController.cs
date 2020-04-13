using ToDoListWebAPI.Business.Convertor.ShareStatus;
using ToDoListWebAPI.Business.Processor.ShareStatus;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.ShareStatus
{
    public class ShareStatusController : BaseController<long, ShareStatusParam, ShareStatusResult, IShareStatusProcessor>
    {
        public ShareStatusController(IShareStatusProcessor processor) : base(processor)
        {
        }
    }
}