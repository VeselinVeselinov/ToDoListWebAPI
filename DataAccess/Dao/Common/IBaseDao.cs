using System.Collections.Generic;

namespace ToDoListWebAPI.DataAccess.Dao.Common
{
	public interface IBaseDao<PK,TEntity>
	{
		TEntity Save(TEntity entity);
		List<TEntity> Save(List<TEntity> entities);

		TEntity Update(TEntity entity);
		List<TEntity> Update(List<TEntity> entities);

		void Erase(PK id);
		void Erase(TEntity entity);
		void Erase(List<PK> idList);

		void Delete(PK id);
		void Delete(TEntity entity);
		void Delete(List<PK> idList);

		TEntity Find(PK id);
		List<TEntity> Find();
		List<TEntity> FindByField(string fieldName, string value);
	}
}
