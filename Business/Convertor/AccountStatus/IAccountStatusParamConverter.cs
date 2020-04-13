using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.AccountStatus
{
    interface IAccountStatusParamConverter:IBaseParamConverter<AccountStatusParam,Data.Entity.AccountStatus>
    {
    }
}
