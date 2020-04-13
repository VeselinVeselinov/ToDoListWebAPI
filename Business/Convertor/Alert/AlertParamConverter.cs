using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.DataAccess.Dao.Note;
using ToDoListWebAPI.DataAccess.Dao.AlertStatus;

namespace ToDoListWebAPI.Business.Convertor.Alert
{
	class AlertParamConverter:BaseParamConverter<AlertParam, Data.Entity.Alert>, IAlertParamConverter
    {
		private INoteDao _noteDao;

		public INoteDao NoteDao
		{
			get { return _noteDao; }
			set { _noteDao = value; }
		}

		private IAlertStatusDao _statusDao;

		public IAlertStatusDao StatusDao
		{
			get { return _statusDao; }
			set { _statusDao = value; }
		}

		public AlertParamConverter(INoteDao noteDao, IAlertStatusDao statusDao)
		{
			_noteDao = noteDao;
			_statusDao = statusDao;
		}

		public override void ConvertSpecific(AlertParam param, Data.Entity.Alert entity)
		{
			entity.Note = NoteDao.Find(param.NoteId);
			entity.Status = StatusDao.Find(param.StatusId);
		}

		public override Data.Entity.Alert GetEntity(AlertParam param)
		{
			return new Data.Entity.Alert()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
