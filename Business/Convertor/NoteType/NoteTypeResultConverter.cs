using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NoteType
{
	class NoteTypeResultConverter : BaseResultConverter<Data.Entity.NoteType, NoteTypeResult>, INoteTypeResultConverter
	{
		public override void ConvertSpecific(Data.Entity.NoteType entity, NoteTypeResult result) { }

		public override NoteTypeResult GetNewResult()
		{
			return new NoteTypeResult();
		}
	}
}
