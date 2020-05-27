using System;
using System.Linq;
using System.Collections.Generic;
using ToDoListWebAPI.Storage.Note;
using ToDoListWebAPI.DataAccess.Dao.Common;


namespace ToDoListWebAPI.DataAccess.Dao.Note
{
	class NoteDaoFile : BaseDaoFile<long, Data.Entity.Note, INoteData>, INoteDao
	{
		public NoteDaoFile(INoteData dataStorage) : base(dataStorage)
		{
		}

		public List<Data.Entity.Note> GetByIdAndCategory(long accountId, string categoryName)
		{
			return DataStorage.GetStorage().Values
				.Where(note => note.AccountId.Equals(accountId) &&
					   note.Category.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase)
					  )
				.ToList();
		}

		public List<Data.Entity.Note> GetByIdAndContent(long accountId, string content)
		{
			return DataStorage.GetStorage().Values
				.Where(note => note.AccountId.Equals(accountId) &&
					   note.Text.Contains(content)
					  )
				.ToList();
		}

		public List<Data.Entity.Note> GetByIdAndName(long accountId, string name)
		{
			return DataStorage.GetStorage().Values
				.Where(note => note.AccountId.Equals(accountId) &&
					   note.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
					  )
				.ToList();
		}

		public List<Data.Entity.Note> GetByIdAndType(long accountId, string typeName)
		{
			return DataStorage.GetStorage().Values
				.Where(note => note.AccountId.Equals(accountId) &&
					   note.Type.Name.Equals(typeName, StringComparison.OrdinalIgnoreCase)
					  )
				.ToList();
		}

		protected override long GetPK(Data.Entity.Note entity)
		{
			return entity.Id;
		}
	}
}
