using ToDoListWebAPI.Storage.AccountStatus;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.AccountStatus
{
	class AccountStatusDaoFile : BaseDaoFile<long, Data.Entity.AccountStatus, IAccountStatusData>, IAccountStatusDao
	{
		public AccountStatusDaoFile(IAccountStatusData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.AccountStatus entity)
		{
			return entity.Id;
		}
	}
}
