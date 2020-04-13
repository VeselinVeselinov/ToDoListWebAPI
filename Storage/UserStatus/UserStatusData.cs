using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.UserStatus
{
	class UserStatusData:BaseStorage<long,Data.Entity.UserStatus>,IUserStatusData
	{
		public override string GetPath()
		{
			return @"Storage\UserStatus\UserStatusStorage.json";
		}

		protected override long GetPK(Data.Entity.UserStatus entity)
		{
			return entity.Id;
		}
	}
}
