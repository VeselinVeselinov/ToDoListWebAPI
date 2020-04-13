using ToDoListWebAPI.Storage.NoteType;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NoteType
{
	class NoteTypeDaoFile : BaseDaoFile<long, Data.Entity.NoteType, INoteTypeData>, INoteTypeDao
	{
		public NoteTypeDaoFile(INoteTypeData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.NoteType entity)
		{
			return entity.Id;
		}
	}
}
