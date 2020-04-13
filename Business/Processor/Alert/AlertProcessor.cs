using ToDoListWebAPI.Business.Convertor.Alert;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.Alert;

namespace ToDoListWebAPI.Business.Processor.Alert
{
	class AlertProcessor : BaseProcessor<long, Data.Entity.Alert, AlertParam, AlertResult
		, IAlertParamConverter, IAlertResultConverter, IAlertDao>, IAlertProcessor
	{
		public AlertProcessor(IAlertParamConverter paramConverter, IAlertResultConverter resultConverter,
			IAlertDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(AlertParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(AlertParam param)
		{ }
	}
}
