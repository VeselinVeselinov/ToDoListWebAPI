using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.AccountStatus
{
	class AccountStatusData:BaseStorage<long,Data.Entity.AccountStatus>,IAccountStatusData
    {
		public override string GetPath()
		{
			return @"Storage\AccountStatus\AccountStatusStorage.json";
		}

		protected override long GetPK(Data.Entity.AccountStatus entity)
		{
			return entity.Id;
		}
	}
}
