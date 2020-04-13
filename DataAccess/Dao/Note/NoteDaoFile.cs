using ToDoListWebAPI.Storage.Note;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Note
{
	class NoteDaoFile : BaseDaoFile<long, Data.Entity.Note, INoteData>, INoteDao
	{
		public NoteDaoFile(INoteData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.Note entity)
		{
			return entity.Id;
		}
	}
}
