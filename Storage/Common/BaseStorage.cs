using System;
using System.Collections.Generic;
using System.IO;
using ToDoListWebAPI.Data.Common;
using ToDoListWebAPI.Storage.Common.JsonConverter;

namespace ToDoListWebAPI.Storage.Common
{
	public abstract class BaseStorage<PK,TEntity>:IBaseStorage<PK,TEntity>
		where PK: IComparable, IComparable<PK>, IConvertible
		where TEntity : Persistent
	{
		protected string PathToDataSource { get; set; }

		protected List<TEntity> Data = new List<TEntity>();

		public Dictionary<PK, TEntity> Storage = new Dictionary<PK, TEntity>();

		public BaseStorage()
		{
			PathToDataSource = GetPath();
			PathToDataSource = Path.Combine(Directory.GetCurrentDirectory(), PathToDataSource);

			LoadStorage();
		}

		/// <summary>
		/// Loads the information the json file holds into a list and then converts into a key-value pair collection(dictionary/map).
		/// </summary>
		public void LoadStorage()
		{
			Data = GetFromDataSource();

			Data.ForEach(entity=>Storage.Add(GetPK(entity),entity));
		}

		/// <summary>
		/// Saves the information from a list into a data source, in this case - a file.
		/// </summary>
		public void SaveToDataSource()
		{
			using (StreamWriter writer = new StreamWriter(PathToDataSource))
			{
				string output = JsonTranslator.ObjToJson(Storage.Values);
				writer.Write(output);
			}
		}

		/// <summary>
		/// Fills the a list with the info from a data source, in this case - a file.
		/// </summary>
		/// <returns></returns>
		public List<TEntity> GetFromDataSource()
		{
			using (StreamReader reader = new StreamReader(PathToDataSource))
			{
				string jsonFileInput = reader.ReadToEnd();
				Data = JsonTranslator.JsonToList<TEntity>(jsonFileInput);

				return Data;
			}
		}
		 
		/// <summary>
		/// Gets the path to the data source for the current child of the BaseStorage
		/// </summary>
		public abstract string GetPath();

		/// <summary>
		/// Returns the storage (dictionary/map) so we can use it for data manipulation in the data access layer. 
		/// </summary>
		public Dictionary<PK,TEntity> GetStorage()
		{
			return Storage;
		}

		/// <summary>
		/// Returns the PK for the current child of BaseStorage.
		/// </summary>
		protected abstract PK GetPK(TEntity entity);
	}
}
