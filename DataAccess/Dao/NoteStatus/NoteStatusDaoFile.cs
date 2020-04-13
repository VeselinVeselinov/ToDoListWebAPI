using ToDoListWebAPI.Storage.NoteStatus;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NoteStatus
{
	class NoteStatusDaoFile : BaseDaoFile<long, Data.Entity.NoteStatus, INoteStatusData>, INoteStatusDao
	{
		public NoteStatusDaoFile(INoteStatusData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.NoteStatus entity)
		{
			return entity.Id;
		}
	}
}
