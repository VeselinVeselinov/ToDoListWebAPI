using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.AlertStatus
{
	class AlertStatusData:BaseStorage<long, Data.Entity.AlertStatus>,IAlertStatusData
	{
		public override string GetPath()
		{
			return @"Storage\AlertStatus\AlertStatusStorage.json";
		}

		protected override long GetPK(Data.Entity.AlertStatus entity)
		{
			return entity.Id;
		}
	}
}
