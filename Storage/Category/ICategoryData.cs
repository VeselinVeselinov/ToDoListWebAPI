using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.Category
{
	interface ICategoryData : IBaseStorage<long, Data.Entity.Category>
	{
	}
}
