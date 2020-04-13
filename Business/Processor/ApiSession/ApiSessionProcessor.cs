using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.ApiSession;
using ToDoListWebAPI.Business.Convertor.ApiSession;
using System.Threading.Tasks;

namespace ToDoListWebAPI.Business.Processor.ApiSession
{
    public class ApiSessionProcessor : BaseProcessor<long, Data.Common.ApiSession.ApiSession,
        ApiSessionParam, ApiSessionResult, IApiSessionParamConverter, IApiSessionResultConverter, IApiSessionDao>,
        IApiSessionProcessor
    {
        public ApiSessionProcessor(IApiSessionParamConverter paramConvertor, IApiSessionResultConverter resultConvertor,
            IApiSessionDao dao) : base(paramConvertor, resultConvertor, dao)
        {
        }

        public async Task<ApiSessionResult> GetByAuthTokenAsync(string authToken)
        {
            var apiSession = await Dao.GetByAuthToken(authToken);
            ApiSessionResult sessionResult = ResultConverter.Convert(apiSession);

            return sessionResult;
        }

        protected override long GetPK(ApiSessionParam entity)
        {
            return entity.Id;
        }

        protected override void ValidateParametersSpecific(ApiSessionParam param)
        { }
    }
}
