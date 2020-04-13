using ToDoListWebAPI.Controllers.Common;
using ToDoListWebAPI.Business.Convertor.Account;
using ToDoListWebAPI.Business.Processor.Account;

namespace ToDoListWebAPI.Controllers.Account
{
    public class AccountService : BaseController<long, AccountParam, AccountResult, IAccountProcessor>
    {
        public AccountService(IAccountProcessor processor) : base(processor)
        {
        }
    }
}