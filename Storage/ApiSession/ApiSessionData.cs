using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.ApiSession
{
    public class ApiSessionData : BaseStorage<long, Data.Common.ApiSession.ApiSession>, IApiSessionData
    {
        public override string GetPath()
        {
            return @"Storage\ApiSession\ApiSessionStorage.json";
        }

        protected override long GetPK(Data.Common.ApiSession.ApiSession entity)
        {
            return entity.Id;
        }
    }
}
