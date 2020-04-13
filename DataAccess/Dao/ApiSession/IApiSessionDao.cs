using System.Threading.Tasks;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.ApiSession
{
    public interface IApiSessionDao : IBaseDao<long, Data.Common.ApiSession.ApiSession>
    {
        Task<Data.Common.ApiSession.ApiSession> GetByAuthToken(string authToken);
    }
}
