using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NoteTask
{
	interface INoteTaskDao : IBaseDao<long, Data.Entity.NoteTask>
    {
	}
}
