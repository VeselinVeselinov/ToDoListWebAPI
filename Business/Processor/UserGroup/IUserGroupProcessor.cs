using ToDoListWebAPI.Business.Convertor.UserGroup;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.UserGroup
{
    public interface IUserGroupProcessor:IBaseProcessor<long, UserGroupParam, UserGroupResult>
    {
    }
}
