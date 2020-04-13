using ToDoListWebAPI.Storage.AlertStatus;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.AlertStatus
{
	class AlertStatusDaoFile : BaseDaoFile<long, Data.Entity.AlertStatus, IAlertStatusData>, IAlertStatusDao
	{
		public AlertStatusDaoFile(IAlertStatusData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.AlertStatus entity)
		{
			return entity.Id;
		}
	}
}
