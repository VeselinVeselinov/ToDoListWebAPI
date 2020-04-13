using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NotificationStatus
{
	class NotificationStatusParamConverter:BaseParamConverter<NotificationStatusParam ,Data.Entity.NotificationStatus>
		, INotificationStatusParamConverter
    {
		public override void ConvertSpecific(NotificationStatusParam param, Data.Entity.NotificationStatus entity) { }

		public override Data.Entity.NotificationStatus GetEntity(NotificationStatusParam param)
		{
			return new Data.Entity.NotificationStatus()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
