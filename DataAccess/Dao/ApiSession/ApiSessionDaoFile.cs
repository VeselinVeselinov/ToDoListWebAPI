using System.Linq;
using System.Threading.Tasks;
using ToDoListWebAPI.Storage.ApiSession;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.ApiSession
{
    public class ApiSessionDaoFile : BaseDaoFile<long, Data.Common.ApiSession.ApiSession, IApiSessionData>, IApiSessionDao
    {
        public ApiSessionDaoFile(IApiSessionData dataStorage) : base(dataStorage)
        {
        }

        public Task<Data.Common.ApiSession.ApiSession> GetByAuthToken(string authToken)
        {
            return Task.Run(() => DataStorage.GetStorage().Values.Where(
                entity => entity.AuthToken.Equals(authToken))
                .FirstOrDefault());
        }

        protected override long GetPK(Data.Common.ApiSession.ApiSession entity)
        {
            return entity.Id;
        }
    }
}
