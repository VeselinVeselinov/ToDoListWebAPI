using ToDoListWebAPI.Storage.Share;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Share
{
	class ShareDaoFile : BaseDaoFile<long, Data.Entity.Share, IShareData>, IShareDao
	{
		public ShareDaoFile(IShareData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.Share entity)
		{
			return entity.Id;
		}
	}
}
