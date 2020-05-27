using ToDoListWebAPI.Business.Convertor.Category;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.Category;

namespace ToDoListWebAPI.Business.Processor.Category
{
	class CategoryProcessor : BaseProcessor<long, Data.Entity.Category, CategoryParam, CategoryResult
		, ICategoryParamConverter, ICategoryResultConverter, ICategoryDao>, ICategoryProcessor
	{
		public CategoryProcessor(ICategoryParamConverter paramConverter, ICategoryResultConverter resultConverter,
			ICategoryDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(CategoryParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(CategoryParam param, long id)
		{ }
	}
}
