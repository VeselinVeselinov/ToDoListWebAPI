using ToDoListWebAPI.Business.Convertor.Account;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.Account
{
	public interface IAccountProcessor:IBaseProcessor<long,AccountParam,AccountResult>
    {
	}
}
