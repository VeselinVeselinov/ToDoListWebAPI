using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Note
{
    interface INoteDao : IBaseDao<long, Data.Entity.Note>
    {
    }
}
