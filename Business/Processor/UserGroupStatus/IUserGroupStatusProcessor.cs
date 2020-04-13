using ToDoListWebAPI.Business.Convertor.UserGroupStatus;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.UserGroupStatus
{
    public interface IUserGroupStatusProcessor : IBaseProcessor<long, UserGroupStatusParam, UserGroupStatusResult>
    {
    }
}
