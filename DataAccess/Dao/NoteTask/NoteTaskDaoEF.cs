using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NoteTask
{
	class NoteTaskDaoEF : BaseDaoEF<long, Data.Entity.NoteTask>, INoteTaskDao
	{
		public NoteTaskDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
