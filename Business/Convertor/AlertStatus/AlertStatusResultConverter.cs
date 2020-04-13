using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.AlertStatus
{
	class AlertStatusResultConverter : BaseResultConverter<Data.Entity.AlertStatus, AlertStatusResult>, IAlertStatusResultConverter
    {
		public override void ConvertSpecific(Data.Entity.AlertStatus entity, AlertStatusResult result) { }

		public override AlertStatusResult GetNewResult()
		{
			return new AlertStatusResult();
		}
	}
}
