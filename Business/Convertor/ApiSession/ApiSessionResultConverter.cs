using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.ApiSession
{
    public class ApiSessionResultConverter : BaseResultConverter<Data.Common.ApiSession.ApiSession, ApiSessionResult>,
        IApiSessionResultConverter
    {
        public override void ConvertSpecific(Data.Common.ApiSession.ApiSession entity, ApiSessionResult result) { }

        public override ApiSessionResult GetNewResult()
        {
            return new ApiSessionResult();
        }
    }
}
