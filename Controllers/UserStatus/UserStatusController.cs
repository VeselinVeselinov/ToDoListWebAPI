using ToDoListWebAPI.Business.Convertor.UserStatus;
using ToDoListWebAPI.Business.Processor.UserStatus;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.UserStatus
{
    public class UserStatusController : BaseController<long, UserStatusParam, UserStatusResult, IUserStatusProcessor>
    {
        public UserStatusController(IUserStatusProcessor processor) : base(processor)
        {
        }
    }
}