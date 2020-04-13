using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.NoteTask
{
	class NoteTaskData:BaseStorage<long, Data.Entity.NoteTask>,INoteTaskData
	{
		public override string GetPath()
		{
			return @"Storage\NoteTask\NoteTaskStorage.json";
		}

		protected override long GetPK(Data.Entity.NoteTask entity)
		{
			return entity.Id;
		}
	}
}
