using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.User
{
	class UserData:BaseStorage<long,Data.Entity.User>,IUserData
	{
		public override string GetPath()
		{
			return @"Storage\User\UserStorage.json";
		}

		protected override long GetPK(Data.Entity.User entity)
		{
			return entity.Id;
		}
	}
}
