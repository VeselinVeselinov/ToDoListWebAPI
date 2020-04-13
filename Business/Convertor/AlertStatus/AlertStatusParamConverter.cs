using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.AlertStatus
{
	class AlertStatusParamConverter: BaseParamConverter<AlertStatusParam, Data.Entity.AlertStatus>, IAlertStatusParamConverter
    {
		public override void ConvertSpecific(AlertStatusParam param, Data.Entity.AlertStatus entity){ }

		public override Data.Entity.AlertStatus GetEntity(AlertStatusParam param)
		{
			return new Data.Entity.AlertStatus()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
