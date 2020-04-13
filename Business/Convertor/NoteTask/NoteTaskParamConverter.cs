using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.DataAccess.Dao.Note;

namespace ToDoListWebAPI.Business.Convertor.NoteTask
{
	class NoteTaskParamConverter:BaseParamConverter<NoteTaskParam, Data.Entity.NoteTask>, INoteTaskParamConverter
    {
		private INoteDao _noteDao;

		public INoteDao NoteDao
		{
			get { return _noteDao; }
			set { _noteDao = value; }
		}

		public NoteTaskParamConverter(INoteDao noteDao)
		{
			_noteDao = noteDao;
		}

		public override void ConvertSpecific(NoteTaskParam param, Data.Entity.NoteTask entity) 
		{
			entity.Note = NoteDao.Find(param.NoteId);
		}

		public override Data.Entity.NoteTask GetEntity(NoteTaskParam param)
		{
			return new Data.Entity.NoteTask()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
