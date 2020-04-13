using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UserStatus
{
    interface IUserStatusParamConverter:IBaseParamConverter<UserStatusParam, Data.Entity.UserStatus>
    {
    }
}
