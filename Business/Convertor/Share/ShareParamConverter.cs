using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.DataAccess.Dao.Account;
using ToDoListWebAPI.DataAccess.Dao.ShareStatus;
using ToDoListWebAPI.DataAccess.Dao.Note;

namespace ToDoListWebAPI.Business.Convertor.Share
{
	class ShareParamConverter:BaseParamConverter<ShareParam, Data.Entity.Share>, IShareParamConverter
    {
		private IAccountDao _accountDao;

		public IAccountDao AccountDao
		{
			get { return _accountDao; }
			set { _accountDao = value; }
		}

		private IShareStatusDao _statusDao;

		public IShareStatusDao StatusDao
		{
			get { return _statusDao; }
			set { _statusDao = value; }
		}

		private INoteDao _noteDao;

		public INoteDao NoteDao
		{
			get { return _noteDao; }
			set { _noteDao = value; }
		}

		public ShareParamConverter(IAccountDao accountDao, INoteDao noteDao, IShareStatusDao statusDao)
		{
			_accountDao = accountDao;
			_noteDao = noteDao;
			_statusDao = statusDao;
		}

		public override void ConvertSpecific(ShareParam param, Data.Entity.Share entity)
		{
			entity.Owner = AccountDao.Find(param.OwnerId);
			entity.Contributor = AccountDao.Find(param.ContributorId);
			entity.Status = StatusDao.Find(param.StatusId);
			entity.Note = NoteDao.Find(param.NoteId);
		}

		public override Data.Entity.Share GetEntity(ShareParam param)
		{
			return new Data.Entity.Share()
			{
				Id = param.Id,
			};
		}
	}
}
