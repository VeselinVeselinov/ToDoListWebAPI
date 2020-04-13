using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.ShareStatus
{
	class ShareStatusData:BaseStorage<long, Data.Entity.ShareStatus>,IShareStatusData
	{
		public override string GetPath()
		{
			return @"Storage\ShareStatus\ShareStatusStorage.json";
		}

		protected override long GetPK(Data.Entity.ShareStatus entity)
		{
			return entity.Id;
		}
	}
}
