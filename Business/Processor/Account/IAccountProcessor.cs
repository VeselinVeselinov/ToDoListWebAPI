using System.Collections.Generic;
using ToDoListWebAPI.Business.Convertor.Account;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.Account
{
	public interface IAccountProcessor:IBaseProcessor<long,AccountParam,AccountResult>
    {
        List<AccountResult> GetByIdAndName(long userId, string name);

        List<AccountResult> GetByIdAndFirstName(long userId, string firstName);

        List<AccountResult> GetByIdAndLastName(long userId, string lastName);

        List<AccountResult> GetByIdAndEmail(long userId, string email);

        List<AccountResult> GetByIdAndPhone(long userId, string phone);
    }
}
