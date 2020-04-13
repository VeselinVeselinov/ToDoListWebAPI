using ToDoListWebAPI.Controllers.Common;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Processor.User;

namespace ToDoListWebAPI.Controllers.User
{
    public class UserController : BaseController<long, UserParam, UserResult, IUserProcessor>
    {
        public UserController(IUserProcessor processor) : base(processor)
        {
        }
    }
}