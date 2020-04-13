using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Note
{
	class NoteDaoEF : BaseDaoEF<long, Data.Entity.Note>, INoteDao
	{
		public NoteDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
