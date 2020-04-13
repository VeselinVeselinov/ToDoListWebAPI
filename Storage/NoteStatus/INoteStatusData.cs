using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.NoteStatus
{
	interface INoteStatusData:IBaseStorage<long,Data.Entity.NoteStatus>
	{
	}
}
