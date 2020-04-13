using ToDoListWebAPI.Business.Convertor.NotificationStatus;
using ToDoListWebAPI.Business.Processor.NotificationStatus;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.NotificationStatus
{
    public class NotificationStatusController : BaseController<long, NotificationStatusParam
        , NotificationStatusResult, INotificationStatusProcessor>
    {
        public NotificationStatusController(INotificationStatusProcessor processor) : base(processor)
        {
        }
    }
}