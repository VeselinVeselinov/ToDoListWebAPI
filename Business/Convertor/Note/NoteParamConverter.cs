using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.DataAccess.Dao.Account;
using ToDoListWebAPI.DataAccess.Dao.Category;
using ToDoListWebAPI.DataAccess.Dao.NoteStatus;
using ToDoListWebAPI.DataAccess.Dao.NoteType;

namespace ToDoListWebAPI.Business.Convertor.Note
{
	class NoteParamConverter : BaseParamConverter<NoteParam, Data.Entity.Note>, INoteParamConverter
	{
		private IAccountDao _accountDao;

		public IAccountDao AccountDao
		{
			get { return _accountDao; }
			set { _accountDao = value; }
		}

		private ICategoryDao _categoryDao;

		public ICategoryDao CategoryDao
		{
			get { return _categoryDao; }
			set { _categoryDao = value; }
		}

		private INoteStatusDao _statusDao;

		public INoteStatusDao StatusDao
		{
			get { return _statusDao; }
			set { _statusDao = value; }
		}

		private INoteTypeDao _typeDao;

		public INoteTypeDao TypeDao
		{
			get { return _typeDao; }
			set { _typeDao = value; }
		}

		public NoteParamConverter(IAccountDao accountDao, ICategoryDao categoryDao, INoteStatusDao statusDao, INoteTypeDao typeDao)
		{
			_accountDao = accountDao;
			_categoryDao = categoryDao;
			_statusDao = statusDao;
			_typeDao = typeDao;
		}

		public override void ConvertSpecific(NoteParam param, Data.Entity.Note entity)
		{
			entity.Account = AccountDao.Find(param.AccountId);
			entity.Category = CategoryDao.Find(param.CategoryId);
			entity.Status = StatusDao.Find(param.StatusId);
			entity.Type = TypeDao.Find(param.TypeId);
		}

		public override Data.Entity.Note GetEntity(NoteParam param)
		{
			return new Data.Entity.Note()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
