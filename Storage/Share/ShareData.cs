using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.Share
{
	class ShareData:BaseStorage<long,Data.Entity.Share>,IShareData
	{
		public override string GetPath()
		{
			return @"Storage\Share\ShareStorage.json";
		}

		protected override long GetPK(Data.Entity.Share entity)
		{
			return entity.Id;
		}
	}
}
