using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NoteType
{
	class NoteTypeParamConverter : BaseParamConverter<NoteTypeParam, Data.Entity.NoteType>, INoteTypeParamConverter
	{
		public override void ConvertSpecific(NoteTypeParam param, Data.Entity.NoteType entity) { }

		public override Data.Entity.NoteType GetEntity(NoteTypeParam param)
		{
			return new Data.Entity.NoteType()
			{
				Id=param.Id,
				Code=param.Code
			};
		}
	}
}
