using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.NoteType
{
	class NoteTypeData:BaseStorage<long,Data.Entity.NoteType>,INoteTypeData
	{
		public override string GetPath()
		{
			return @"Storage\NoteType\NoteTypeStorage.json";
		}

		protected override long GetPK(Data.Entity.NoteType entity)
		{
			return entity.Id;
		}
	}
}
