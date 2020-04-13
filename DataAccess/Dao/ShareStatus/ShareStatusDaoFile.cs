using ToDoListWebAPI.Storage.ShareStatus;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.ShareStatus
{
	class ShareStatusDaoFile : BaseDaoFile<long, Data.Entity.ShareStatus, IShareStatusData>, IShareStatusDao
	{
		public ShareStatusDaoFile(IShareStatusData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.ShareStatus entity)
		{
			return entity.Id;
		}
	}
}
