using ToDoListWebAPI.Storage.UserStatus;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.UserStatus
{
	class UserStatusDaoFile : BaseDaoFile<long, Data.Entity.UserStatus, IUserStatusData>, IUserStatusDao
	{
		public UserStatusDaoFile(IUserStatusData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.UserStatus entity)
		{
			return entity.Id;
		}
	}
}
