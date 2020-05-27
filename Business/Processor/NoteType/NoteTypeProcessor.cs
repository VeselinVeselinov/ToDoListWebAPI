using ToDoListWebAPI.Business.Convertor.NoteType;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.NoteType;

namespace ToDoListWebAPI.Business.Processor.NoteType
{
	class NoteTypeProcessor : BaseProcessor<long, Data.Entity.NoteType, NoteTypeParam, NoteTypeResult
		, INoteTypeParamConverter, INoteTypeResultConverter, INoteTypeDao>, INoteTypeProcessor
	{
		public NoteTypeProcessor(INoteTypeParamConverter paramConverter, INoteTypeResultConverter resultConverter,
			INoteTypeDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(NoteTypeParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(NoteTypeParam param, long id)
		{ }
	}
}
