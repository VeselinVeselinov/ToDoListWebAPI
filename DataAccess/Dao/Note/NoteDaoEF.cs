using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Note
{
	class NoteDaoEF : BaseDaoEF<long, Data.Entity.Note>, INoteDao
	{
		public NoteDaoEF(DbContext dbContext) : base(dbContext)
		{
		}

		public List<Data.Entity.Note> GetByIdAndCategory(long accountId, string categoryName)
		{
			var result = Entities
				.Where(note => note.AccountId == accountId &&
				note.Category.Name.Equals(categoryName))
				.ToList();

			return result;
		}

		public List<Data.Entity.Note> GetByIdAndContent(long accountId, string content)
		{
			return Entities
					.Where(note => note.AccountId.Equals(accountId) &&
					note.Text.Contains(content))
					.ToList();
		}

		public List<Data.Entity.Note> GetByIdAndName(long accountId, string name)
		{
			var result = Entities
				.Where(note => note.AccountId == accountId &&
				note.Name.Equals(name))
				.ToList();

			return result;
		}

		public List<Data.Entity.Note> GetByIdAndType(long accountId, string typeName)
		{
			var result = Entities
				.Where(note => note.AccountId == accountId &&
				note.Type.Name.Equals(typeName))
				.ToList();

			return result;
		}
	}
}
