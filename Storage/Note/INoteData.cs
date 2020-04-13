using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.Note
{
	interface INoteData:IBaseStorage<long,Data.Entity.Note>
	{
	}
}
