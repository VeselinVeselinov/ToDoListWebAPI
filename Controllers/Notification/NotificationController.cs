using ToDoListWebAPI.Business.Convertor.Notification;
using ToDoListWebAPI.Business.Processor.Notification;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.Notification
{
    public class NotificationController : BaseController<long, NotificationParam
        , NotificationResult, INotificationProcessor>
    {
        public NotificationController(INotificationProcessor processor) : base(processor)
        {
        }
    }
}