using ToDoListWebAPI.Business.Convertor.AccountStatus;
using ToDoListWebAPI.Business.Processor.AccountStatus;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.AccountStatus
{
    public class AccountStatusController : BaseController<long, AccountStatusParam, AccountStatusResult, IAccountStatusProcessor>
    {
        public AccountStatusController(IAccountStatusProcessor processor):base(processor)
        {

        }
    }
}