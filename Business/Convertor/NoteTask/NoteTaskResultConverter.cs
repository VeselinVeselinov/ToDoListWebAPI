using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NoteTask
{
	class NoteTaskResultConverter : BaseResultConverter<Data.Entity.NoteTask, NoteTaskResult>, INoteTaskResultConverter
    {
		public override void ConvertSpecific(Data.Entity.NoteTask entity, NoteTaskResult result)
		{
			result.NoteId = entity.Note.Id;
			result.NoteName = entity.Note.Name;
		}

		public override NoteTaskResult GetNewResult()
		{
			return new NoteTaskResult();
		}
	}
}
