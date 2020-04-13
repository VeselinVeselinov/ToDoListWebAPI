using ToDoListWebAPI.Storage.Account;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Account
{
	class AccountDaoFile : BaseDaoFile<long, Data.Entity.Account, IAccountData>, IAccountDao
	{
		public AccountDaoFile(IAccountData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.Account entity)
		{
			return entity.Id;
		}
	}
}
