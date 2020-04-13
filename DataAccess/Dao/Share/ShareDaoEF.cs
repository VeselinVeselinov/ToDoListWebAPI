using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Share
{
	class ShareDaoEF : BaseDaoEF<long, Data.Entity.Share>, IShareDao
	{
		public ShareDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
