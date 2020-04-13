using ToDoListWebAPI.Business.Convertor.AlertStatus;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.AlertStatus;

namespace ToDoListWebAPI.Business.Processor.AlertStatus
{
	class AlertStatusProcessor : BaseProcessor<long, Data.Entity.AlertStatus, AlertStatusParam, AlertStatusResult
		, IAlertStatusParamConverter, IAlertStatusResultConverter, IAlertStatusDao>, IAlertStatusProcessor
	{
		public AlertStatusProcessor(IAlertStatusParamConverter paramConverter, IAlertStatusResultConverter resultConverter,
			IAlertStatusDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(AlertStatusParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(AlertStatusParam param)
		{ }
	}
}
