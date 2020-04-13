using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NoteStatus
{
	class NoteStatusResultConverter : BaseResultConverter<Data.Entity.NoteStatus, NoteStatusResult>, INoteStatusResultConverter
    {
		public override void ConvertSpecific(Data.Entity.NoteStatus entity, NoteStatusResult result) { }

		public override NoteStatusResult GetNewResult()
		{
			return new NoteStatusResult();
		}
	}
}
