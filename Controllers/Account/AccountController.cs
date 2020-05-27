using ToDoListWebAPI.Controllers.Common;
using ToDoListWebAPI.Business.Convertor.Account;
using ToDoListWebAPI.Business.Processor.Account;

namespace ToDoListWebAPI.Controllers.Account
{
    public class AccountController : BaseController<long, AccountParam, AccountResult, IAccountProcessor>
    {
        public AccountController(IAccountProcessor processor) : base(processor)
        {
        }
    }
}