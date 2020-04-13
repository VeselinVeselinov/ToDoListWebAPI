using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Category
{
	class CategoryDaoEF : BaseDaoEF<long, Data.Entity.Category>, ICategoryDao
	{
		public CategoryDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
