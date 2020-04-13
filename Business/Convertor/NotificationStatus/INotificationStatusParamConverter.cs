using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NotificationStatus
{
    interface INotificationStatusParamConverter:IBaseParamConverter<NotificationStatusParam, Data.Entity.NotificationStatus>
    {
    }
}
