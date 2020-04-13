using ToDoListWebAPI.Storage.Alert;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Alert
{
	class AlertDaoFile : BaseDaoFile<long, Data.Entity.Alert, IAlertData>, IAlertDao
	{
		public AlertDaoFile(IAlertData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.Alert entity)
		{
			return entity.Id;
		}
	}
}
