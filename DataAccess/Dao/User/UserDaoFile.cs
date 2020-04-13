using System.Linq;
using System.Threading.Tasks;
using ToDoListWebAPI.Storage.User;
using ToDoListWebAPI.DataAccess.Dao.Common;


namespace ToDoListWebAPI.DataAccess.Dao.User
{
	class UserDaoFile : BaseDaoFile<long, Data.Entity.User, IUserData>, IUserDao
	{
		public UserDaoFile(IUserData dataStorage) : base(dataStorage)
		{
		}

		public async Task<Data.Entity.User> GetByUsernameAndPasswordAsync(string username, string password)
		{
			return await Task.Run(
				() => DataStorage.GetStorage().Values.SingleOrDefault
				(user => user.UserName.Equals(username) && user.Password.Equals(password)));
		}

		protected override long GetPK(Data.Entity.User entity)
		{
			return entity.Id;
		}
	}
}
