using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.ShareStatus
{
	class ShareStatusDaoEF : BaseDaoEF<long, Data.Entity.ShareStatus>, IShareStatusDao
	{
		public ShareStatusDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
