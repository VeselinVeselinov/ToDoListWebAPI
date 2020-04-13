using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.Account
{
	class AccountData:BaseStorage<long,Data.Entity.Account>, IAccountData
	{
		public override string GetPath()
		{
			return @"Storage\Account\AccountStorage.json";
		}

		protected override long GetPK(Data.Entity.Account entity)
		{
			return entity.Id;
		}
	}
}

