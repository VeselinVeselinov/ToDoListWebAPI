using System;
using System.Linq;
using ToDoListWebAPI.Data.Common;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoListWebAPI.DataAccess.Dao.Common
{
	public abstract class BaseDaoEF<PK, TEntity> : IBaseDao<PK, TEntity>
		where TEntity : Persistent
	{
		protected DbContext Context { get; set; }

		protected DbSet<TEntity> Entities { get; set; }

		public BaseDaoEF(DbContext dbContext)
		{
			Context = dbContext;
			Entities = Context.Set<TEntity>();
		}

		public void Erase(PK id)
		{
			TEntity entity = Find(id);

			Erase(entity);
		}

		public void Erase(TEntity entity)
		{
			Entities.Remove(entity);
			Context.SaveChanges();
		}

		public void Erase(List<PK> idList)
		{
			idList.ForEach(id => Erase(id));
		}

		public TEntity Find(PK id)
		{
			TEntity entity = Entities.Find(id);

			if (entity == null)
			{
				throw new KeyNotFoundException();
			}

			return entity;
		}

		public List<TEntity> Find()
		{
			return Entities.ToList();
		}

		public List<TEntity> FindByField(string fieldName, string value)
		{
			TEntity entity = Entities.First();

			foreach (var item in entity.GetType().GetProperties())
			{
				if (item.Name.Equals(fieldName, StringComparison.OrdinalIgnoreCase))
				{
					fieldName = item.Name;
				}
			}

			return Entities.ToList().Where(
				entity => entity.GetType()
					.GetProperty(fieldName).GetValue(entity).ToString()
					.Equals(value, StringComparison.OrdinalIgnoreCase)
					).ToList();
		}

		public TEntity Save(TEntity entity)
		{
			Context.Entry(entity).State = EntityState.Added;
			Context.SaveChanges();

			return entity;
		}

		public List<TEntity> Save(List<TEntity> entities)
		{
			entities.ForEach(entity=>Save(entity));

			return entities;
		}

		public TEntity Update(TEntity entity)
		{
			Context.Entry(entity).State = EntityState.Modified;
			Context.SaveChanges();

			return entity;
		}

		public List<TEntity> Update(List<TEntity> entities)
		{
			entities.ForEach(entity=>Update(entity));

			return entities;
		}

		public void Delete(PK id)
		{
			TEntity entity = Find(id);

			Delete(entity);
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
	}
}
