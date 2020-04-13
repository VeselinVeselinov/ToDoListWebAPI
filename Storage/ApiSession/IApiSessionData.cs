using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.ApiSession
{
    public interface IApiSessionData : IBaseStorage<long, Data.Common.ApiSession.ApiSession>
    {
    }
}
