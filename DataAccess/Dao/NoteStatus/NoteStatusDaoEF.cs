using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NoteStatus
{
	class NoteStatusDaoEF : BaseDaoEF<long, Data.Entity.NoteStatus>, INoteStatusDao
	{
		public NoteStatusDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
