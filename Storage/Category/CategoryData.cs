using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.Category
{
	class CategoryData:BaseStorage<long, Data.Entity.Category>, ICategoryData
	{
		public override string GetPath()
		{
			return @"Storage\Category\CategoryStorage.json";
		}

		protected override long GetPK(Data.Entity.Category entity)
		{
			return entity.Id;
		}
	}
}
