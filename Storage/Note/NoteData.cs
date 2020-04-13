using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.Note
{
	class NoteData:BaseStorage<long,Data.Entity.Note>,INoteData
	{
		public override string GetPath()
		{
			return @"Storage\Note\NoteStorage.json";
		}

		protected override long GetPK(Data.Entity.Note entity)
		{
			return entity.Id;
		}
	}
}
