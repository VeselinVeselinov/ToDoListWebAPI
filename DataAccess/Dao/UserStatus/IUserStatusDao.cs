using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.UserStatus
{
	interface IUserStatusDao : IBaseDao<long, Data.Entity.UserStatus>
    {
	}
}
