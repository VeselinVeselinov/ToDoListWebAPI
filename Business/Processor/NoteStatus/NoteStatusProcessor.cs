using ToDoListWebAPI.Business.Convertor.NoteStatus;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.NoteStatus;

namespace ToDoListWebAPI.Business.Processor.NoteStatus
{
	class NoteStatusProcessor : BaseProcessor<long, Data.Entity.NoteStatus, NoteStatusParam, NoteStatusResult
		, INoteStatusParamConverter, INoteStatusResultConverter, INoteStatusDao>, INoteStatusProcessor
	{
		public NoteStatusProcessor(INoteStatusParamConverter paramConverter, INoteStatusResultConverter resultConverter,
			INoteStatusDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(NoteStatusParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(NoteStatusParam param, long id)
		{ }
	}
}
