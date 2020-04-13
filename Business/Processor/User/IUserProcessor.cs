using System.Threading.Tasks;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.User
{
	public interface IUserProcessor:IBaseProcessor<long, UserParam, UserResult>
    {
        Task<UserResult> GetByUsernameAndPasswordAsync(string username, string password);
    }
}
