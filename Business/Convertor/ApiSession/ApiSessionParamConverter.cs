using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.ApiSession
{
    public class ApiSessionParamConverter : BaseParamConverter<ApiSessionParam, Data.Common.ApiSession.ApiSession>,
        IApiSessionParamConverter
    {
        public override void ConvertSpecific(ApiSessionParam param, Data.Common.ApiSession.ApiSession entity) { }

        public override Data.Common.ApiSession.ApiSession GetEntity(ApiSessionParam param)
        {
            return new Data.Common.ApiSession.ApiSession()
            {
                Id = param.Id,
                Code = param.Code
            };
        }
    }
}
