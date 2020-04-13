using System;
using System.Linq;
using System.Collections.Generic;
using ToDoListWebAPI.Data.Common;
using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Common
{
	public abstract class BaseDaoFile<PK, TEntity, TStorage> : IBaseDao<PK, TEntity>
		where PK : IComparable, IComparable<PK>, IConvertible
		where TEntity : Persistent
		where TStorage : IBaseStorage<PK, TEntity>
	{
		private TStorage _dataStorage;

		public TStorage DataStorage
		{
			get { return _dataStorage; }
			set { _dataStorage = value; }
		}

		public BaseDaoFile(TStorage dataStorage)
		{
			_dataStorage = dataStorage;
		}

		protected abstract PK GetPK(TEntity entity);

		public void Erase(PK id)
		{
			TEntity entity = Find(id);
			Erase(entity);

			DataStorage.SaveToDataSource();
		}

		public void Erase(TEntity entity)
		{
			DataStorage.GetStorage().Remove(GetPK(entity));
		}

		public void Erase(List<PK> idList)
		{
			idList.ForEach(id => Erase(id));
		}

		public void Delete(PK id)
		{
			TEntity entity = Find(id);
		}

		public void Delete(TEntity entity)
		{
			entity.Active = 0;

			Update(entity);
		}

		public void Delete(List<PK> idList)
		{
			idList.ForEach(id => Delete(id));
		}

		public TEntity Find(PK id)
		{
			if (!DataStorage.GetStorage().ContainsKey(id))
			{
				throw new KeyNotFoundException();
			}

			return DataStorage.GetStorage()
						.Where(entity => entity.Key.Equals(id))
						.FirstOrDefault()
						.Value;
		}

		public List<TEntity> Find()
		{
			return DataStorage
					.GetStorage()
					.Values
					.ToList();
		}

		public List<TEntity> FindByField(string fieldName, string value)
		{
			TEntity entity = DataStorage.GetStorage().First().Value;

			foreach (var item in entity.GetType().GetProperties())
			{
				if (item.Name.Equals(fieldName, StringComparison.OrdinalIgnoreCase))
				{
					fieldName = item.Name;
				}
			}

			return DataStorage.GetStorage().Values.ToList().Where(
				entity => entity.GetType()
					.GetProperty(fieldName).GetValue(entity).ToString()
					.Equals(value, StringComparison.OrdinalIgnoreCase)
					).ToList();
		}

		public TEntity Save(TEntity entity)
		{
			DataStorage.GetStorage().Add(GetPK(entity), entity);

			DataStorage.SaveToDataSource();

			return entity;
		}

		public List<TEntity> Save(List<TEntity> entities)
		{
			entities.ForEach(entity => Save(entity));

			return entities;
		}

		public TEntity Update(TEntity entity)
		{
			Erase(GetPK(entity));

			Save(entity);

			return entity;
		}

		public List<TEntity> Update(List<TEntity> entities)
		{
			entities.ForEach(entity => Update(entity));

			return entities;
		}
	}
}
