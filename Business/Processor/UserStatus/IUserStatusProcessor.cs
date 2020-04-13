using ToDoListWebAPI.Business.Convertor.UserStatus;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.UserStatus
{
	public interface IUserStatusProcessor:IBaseProcessor<long, UserStatusParam, UserStatusResult>
    {
	}
}
