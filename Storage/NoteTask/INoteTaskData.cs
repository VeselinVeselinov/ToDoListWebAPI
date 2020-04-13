using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.NoteTask
{
	interface INoteTaskData:IBaseStorage<long,Data.Entity.NoteTask>
	{
	}
}
