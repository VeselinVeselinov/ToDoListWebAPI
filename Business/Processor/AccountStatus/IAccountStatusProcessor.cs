using ToDoListWebAPI.Business.Convertor.AccountStatus;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.AccountStatus
{
	public interface IAccountStatusProcessor:IBaseProcessor<long,AccountStatusParam,AccountStatusResult>
    {
	}
}
