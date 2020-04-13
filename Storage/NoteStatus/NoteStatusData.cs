using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.NoteStatus
{
	class NoteStatusData:BaseStorage<long, Data.Entity.NoteStatus>,INoteStatusData
	{
		public override string GetPath()
		{
			return @"Storage\NoteStatus\NoteStatusStorage.json";
		}

		protected override long GetPK(Data.Entity.NoteStatus entity)
		{
			return entity.Id;
		}
	}
}
