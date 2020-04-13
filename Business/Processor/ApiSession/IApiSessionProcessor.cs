using System.Threading.Tasks;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.Business.Convertor.ApiSession;

namespace ToDoListWebAPI.Business.Processor.ApiSession
{
    public interface IApiSessionProcessor : IBaseProcessor<long, ApiSessionParam, ApiSessionResult>
    {
        Task<ApiSessionResult> GetByAuthTokenAsync(string authToken);
    }
}
