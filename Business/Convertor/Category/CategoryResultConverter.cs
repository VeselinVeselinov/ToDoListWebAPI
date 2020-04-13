using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Category
{
	class CategoryResultConverter : BaseResultConverter<Data.Entity.Category, CategoryResult>, ICategoryResultConverter
    {
		public override void ConvertSpecific(Data.Entity.Category entity, CategoryResult result) { }

		public override CategoryResult GetNewResult()
		{
			return new CategoryResult();
		}
	}
}
