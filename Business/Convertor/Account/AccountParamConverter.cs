using ToDoListWebAPI.DataAccess.Dao.User;
using ToDoListWebAPI.DataAccess.Dao.AccountStatus;
using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Account
{
	class AccountParamConverter: BaseParamConverter<AccountParam, Data.Entity.Account>, IAccountParamConverter
    {
		private IUserDao _userDao;

		public IUserDao UserDao
		{
			get { return _userDao; }
			set { _userDao = value; }
		}

		private IAccountStatusDao _statusDao;

		public IAccountStatusDao StatusDao
		{
			get { return _statusDao; }
			set { _statusDao = value; }
		}

		public AccountParamConverter(IUserDao userDao, IAccountStatusDao statusDao)
		{
			_userDao = userDao;
			_statusDao = statusDao;
		}

		public override void ConvertSpecific(AccountParam param, Data.Entity.Account entity)
		{
			entity.User = UserDao.Find(param.UserId);
			entity.Status = StatusDao.Find(param.StatusId);
		}

		public override Data.Entity.Account GetEntity(AccountParam param)
		{
			return new Data.Entity.Account()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
