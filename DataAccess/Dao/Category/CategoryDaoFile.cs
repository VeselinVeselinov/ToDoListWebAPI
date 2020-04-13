using ToDoListWebAPI.Storage.Category;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Category
{
	class CategoryDaoFile : BaseDaoFile<long, Data.Entity.Category, ICategoryData>, ICategoryDao
	{
		public CategoryDaoFile(ICategoryData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.Category entity)
		{
			return entity.Id;
		}
	}
}
