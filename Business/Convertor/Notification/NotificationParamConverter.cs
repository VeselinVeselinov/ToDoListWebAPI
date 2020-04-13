using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.DataAccess.Dao.Alert;
using ToDoListWebAPI.DataAccess.Dao.NotificationStatus;

namespace ToDoListWebAPI.Business.Convertor.Notification
{
	class NotificationParamConverter:BaseParamConverter<NotificationParam, Data.Entity.Notification>
		, INotificationParamConverter
    {
		private IAlertDao _alertDao;

		public IAlertDao AlertDao
		{
			get { return _alertDao; }
			set { _alertDao = value; }
		}

		private INotificationStatusDao _statusDao;

		public INotificationStatusDao StatusDao
		{
			get { return _statusDao; }
			set { _statusDao = value; }
		}

		public NotificationParamConverter(IAlertDao alertDao, INotificationStatusDao statusDao)
		{
			_alertDao = alertDao;
			_statusDao = statusDao;
		}

		public override void ConvertSpecific(NotificationParam param, Data.Entity.Notification entity)
		{
			entity.Alert = AlertDao.Find(param.AlertId);
			entity.Status = StatusDao.Find(param.StatusId);
		}

		public override Data.Entity.Notification GetEntity(NotificationParam param)
		{
			return new Data.Entity.Notification()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
