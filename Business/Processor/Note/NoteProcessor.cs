using ToDoListWebAPI.Business.Convertor.Note;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.Note;

namespace ToDoListWebAPI.Business.Processor.Note
{
	class NoteProcessor : BaseProcessor<long, Data.Entity.Note, NoteParam, NoteResult,
		INoteParamConverter, INoteResultConverter, INoteDao>, INoteProcessor
	{
		public NoteProcessor(INoteParamConverter paramConverter, INoteResultConverter resultConverter,
			INoteDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(NoteParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(NoteParam param)
		{ }
	}
}
