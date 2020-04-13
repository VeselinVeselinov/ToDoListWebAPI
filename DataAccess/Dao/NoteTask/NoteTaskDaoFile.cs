using ToDoListWebAPI.Storage.NoteTask;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NoteTask
{
	class NoteTaskDaoFile : BaseDaoFile<long, Data.Entity.NoteTask, INoteTaskData>, INoteTaskDao
	{
		public NoteTaskDaoFile(INoteTaskData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.NoteTask entity)
		{
			return entity.Id;
		}
	}
}
