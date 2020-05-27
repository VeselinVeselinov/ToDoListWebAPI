using ToDoListWebAPI.Business.Convertor.NoteTask;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.NoteTask;

namespace ToDoListWebAPI.Business.Processor.NoteTask
{
	class NoteTaskProcessor : BaseProcessor<long, Data.Entity.NoteTask, NoteTaskParam, NoteTaskResult
		, INoteTaskParamConverter, INoteTaskResultConverter, INoteTaskDao>, INoteTaskProcessor
	{
		public NoteTaskProcessor(INoteTaskParamConverter paramConverter, INoteTaskResultConverter resultConverter,
			INoteTaskDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(NoteTaskParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(NoteTaskParam param, long id)
		{ }
	}
}
