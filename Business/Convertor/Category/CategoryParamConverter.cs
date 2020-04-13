using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Category
{
	class CategoryParamConverter:BaseParamConverter<CategoryParam, Data.Entity.Category>, ICategoryParamConverter
    {
		public override void ConvertSpecific(CategoryParam param, Data.Entity.Category entity) { }

		public override Data.Entity.Category GetEntity(CategoryParam param)
		{
			return new Data.Entity.Category()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
