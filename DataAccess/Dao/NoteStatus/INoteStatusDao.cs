using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NoteStatus
{
	interface INoteStatusDao : IBaseDao<long, Data.Entity.NoteStatus>
    {
	}
}
