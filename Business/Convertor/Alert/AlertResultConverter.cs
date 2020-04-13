using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Alert
{
	class AlertResultConverter : BaseResultConverter<Data.Entity.Alert, AlertResult>, IAlertResultConverter
    {
		public override void ConvertSpecific(Data.Entity.Alert entity, AlertResult result)
		{
			result.NoteId = entity.Note.Id;
			result.NoteName = entity.Note.Name;
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Status.Name;
		}

		public override AlertResult GetNewResult()
		{
			return new AlertResult();
		}
	}
}
