using System.Threading.Tasks;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.User
{
	public interface IUserDao : IBaseDao<long, Data.Entity.User>
    {
		Task<Data.Entity.User> GetByUsernameAndPasswordAsync(string username, string password);
	}
}
