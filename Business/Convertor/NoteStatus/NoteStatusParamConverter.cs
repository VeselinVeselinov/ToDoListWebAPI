using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NoteStatus
{
	class NoteStatusParamConverter:BaseParamConverter<NoteStatusParam, Data.Entity.NoteStatus>, INoteStatusParamConverter
    {
		public override void ConvertSpecific(NoteStatusParam param, Data.Entity.NoteStatus entity) { }

		public override Data.Entity.NoteStatus GetEntity(NoteStatusParam param)
		{
			return new Data.Entity.NoteStatus()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
