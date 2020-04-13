using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.User
{
	class UserDaoEF : BaseDaoEF<long, Data.Entity.User>, IUserDao
	{
		public UserDaoEF(DbContext dbContext) : base(dbContext)
		{
		}

		public async Task<Data.Entity.User> GetByUsernameAndPasswordAsync(string username, string password)
		{
			var user = await Task.Run(
				() => Entities.SingleOrDefault(x => x.UserName == username && x.Password == password));

			return user;
		}
	}
}
