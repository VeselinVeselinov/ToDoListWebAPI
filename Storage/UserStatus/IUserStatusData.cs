using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.UserStatus
{
	interface IUserStatusData:IBaseStorage<long,Data.Entity.UserStatus>
	{
	}
}
