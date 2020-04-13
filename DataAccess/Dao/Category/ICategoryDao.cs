using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Category
{
	interface ICategoryDao : IBaseDao<long, Data.Entity.Category>
    {
	}
}
