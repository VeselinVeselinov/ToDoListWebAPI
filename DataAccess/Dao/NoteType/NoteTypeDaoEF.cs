using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NoteType
{
	class NoteTypeDaoEF : BaseDaoEF<long, Data.Entity.NoteType>, INoteTypeDao
	{
		public NoteTypeDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
