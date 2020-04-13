using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.Account
{
	interface IAccountData:IBaseStorage<long,Data.Entity.Account>
	{
	}
}
