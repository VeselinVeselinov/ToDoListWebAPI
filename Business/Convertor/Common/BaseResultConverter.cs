using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ToDoListWebAPI.Data.Common;

namespace ToDoListWebAPI.Business.Convertor.Common
{
	public abstract class BaseResultConverter<TEntity, TResult> : IBaseResultConverter<TEntity, TResult>
		where TResult:BaseResult
		where TEntity:Persistent
	{
		/// <summary>
		/// Returns a new instance of the result type.
		/// </summary>
		public abstract TResult GetNewResult();

		/// <summary>
		/// Generates a final result with mapped properties from the existing entity in the system.
		/// </summary>
		/// <param name="entity">Existing entity in the system.</param>
		/// <returns>Mapped result.</returns>
		public TResult Convert(TEntity entity)
		{
			TResult result = ConvertStandart(entity,GetNewResult());
			ConvertSpecific(entity, result);

			return result;
		}

		/// <summary>
		/// Sets the result's specific properties using metadata from the related entity properties.
		/// </summary>
		/// <param name="entity">Entity with info</param>
		/// <param name="result">Empty result</param>
		/// <returns>Result object with setted specific properties</returns>
		public abstract void ConvertSpecific(TEntity entity, TResult result);

		/// <summary>
		/// Maps the entity's properties to the param's corresponding properties.
		/// </summary>
		/// <param name="entity">Entity with information</param>
		/// <param name="result">Empty result</param>
		/// <returns>Mapped result object</returns>
		public TResult ConvertStandart(TEntity entity, TResult result)
		{
			// A dictionary that holds the entity's properties - ( key = property's name && value = property )

			Dictionary<string, PropertyInfo> entityInfo = entity.GetType()
															.GetProperties()
															.ToDictionary(prop => prop.Name, prop => prop);
			
			// A dictionary that holds the result's properties - ( key = property's name && value = property )

			Dictionary<string, PropertyInfo> resultInfo = result.GetType()
															.GetProperties()
															.ToDictionary(prop => prop.Name, prop => prop);

			foreach (var entityPair in entityInfo)
			{
				if (resultInfo.ContainsKey(entityPair.Key))
				{
					result.GetType()
						.GetProperty(entityPair.Key)
						.SetValue(
							result, 
							entityPair.Value.GetValue(entity)
						);
				}
			}

			return result;
		}
	}
}
