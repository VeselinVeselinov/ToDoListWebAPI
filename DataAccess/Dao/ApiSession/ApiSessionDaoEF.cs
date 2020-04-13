using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.ApiSession
{
    public class ApiSessionDaoEF : BaseDaoEF<long, Data.Common.ApiSession.ApiSession>, IApiSessionDao
    {
        public ApiSessionDaoEF(DbContext dbContext) : base(dbContext)
        {
        }

        public Task<Data.Common.ApiSession.ApiSession> GetByAuthToken(string authToken)
        {
            return Task.Run(() => Entities.Where(
                entity => entity.AuthToken.Equals(authToken))
                .FirstOrDefault());
        }
    }
}
