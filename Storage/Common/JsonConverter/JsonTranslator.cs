using Newtonsoft.Json;
using System.Collections.Generic;
using ToDoListWebAPI.Data.Common;

namespace ToDoListWebAPI.Storage.Common.JsonConverter
{
    public static class JsonTranslator
    {
        /// <summary>
		/// Converts an object into a json format string
		/// </summary>
		/// <param name="obj">Object</param>
		/// <returns>Converted to json format object</returns>
        public static string ObjToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
		/// Converts a json format string into a list of objects
		/// </summary>
		/// <typeparam name="TEntity">The type of the entities in the result list</typeparam>
		/// <param name="jsonString">Json format string</param>
		/// <returns>List of entities of type T</returns>
        public static List<TEntity> JsonToList<TEntity>(string jsonString)
            where TEntity:Persistent
        {
            return JsonConvert.DeserializeObject<List<TEntity>>(jsonString);
        }
    }
}
