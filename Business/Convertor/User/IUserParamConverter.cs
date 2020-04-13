using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.User
{
    interface IUserParamConverter:IBaseParamConverter<UserParam, Data.Entity.User>
    {
        string HashPassword(string password);
    }
}
