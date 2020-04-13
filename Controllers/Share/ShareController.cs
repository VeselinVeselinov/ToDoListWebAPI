using ToDoListWebAPI.Business.Convertor.Share;
using ToDoListWebAPI.Business.Processor.Share;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.Share
{
    public class ShareController : BaseController<long, ShareParam, ShareResult, IShareProcessor>
    {
        public ShareController(IShareProcessor processor) : base(processor)
        {
        }
    }
}