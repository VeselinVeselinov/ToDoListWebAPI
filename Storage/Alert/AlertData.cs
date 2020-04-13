using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.Alert
{
	class AlertData:BaseStorage<long, Data.Entity.Alert>,IAlertData
	{
		public override string GetPath()
		{
			return @"Storage\Alert\AlertStorage.json";
		}

		protected override long GetPK(Data.Entity.Alert entity)
		{
			return entity.Id;
		}
	}
}
