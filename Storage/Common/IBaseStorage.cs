using System;
using System.Collections.Generic;
using ToDoListWebAPI.Data.Common;

namespace ToDoListWebAPI.Storage.Common
{
	public interface IBaseStorage<PK,TEntity>
		where PK : IComparable, IComparable<PK>, IConvertible
		where TEntity :Persistent
	{
		void SaveToDataSource();

		void LoadStorage();

		List<TEntity> GetFromDataSource();

		string GetPath();

		Dictionary<PK, TEntity> GetStorage();
	}
}
