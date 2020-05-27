using System.Collections.Generic;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Note
{
    interface INoteDao : IBaseDao<long, Data.Entity.Note>
    {
        List<Data.Entity.Note> GetByIdAndCategory(long accountId, string categoryName);

        List<Data.Entity.Note> GetByIdAndName(long accountId, string name);

        List<Data.Entity.Note> GetByIdAndContent(long accountId, string content);

        List<Data.Entity.Note> GetByIdAndType(long accountId, string typeName);
    }
}
