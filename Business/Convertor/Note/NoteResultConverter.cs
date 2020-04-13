using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Note
{
	class NoteResultConverter : BaseResultConverter<Data.Entity.Note, NoteResult>, INoteResultConverter
	{
		public override void ConvertSpecific(Data.Entity.Note entity, NoteResult result)
		{
			result.AccountId = entity.Account.Id;
			result.AccountName = entity.Account.Name;
			result.CategoryId = entity.Category.Id;
			result.CategoryName = entity.Category.Name;
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Status.Name;
			result.TypeId = entity.Type.Id;
			result.TypeName = entity.Type.Name;
		}

		public override NoteResult GetNewResult()
		{
			return new NoteResult();
		}
	}
}
