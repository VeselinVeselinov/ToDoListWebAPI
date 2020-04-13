using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using ToDoListWebAPI.Data.Common;
using ToDoListWebAPI.Business.Convertor.Common.CustomAttributes;

namespace ToDoListWebAPI.Business.Convertor.Common
{
	public abstract class BaseParamConverter<TParam, TEntity> : IBaseParamConverter<TParam, TEntity>
		where TParam : BaseParam
		where TEntity : Persistent
	{
		/// <summary>
		/// Sets an entity's properties from an input param.
		/// </summary>
		/// <param name="param">The input information. </param>
		/// <param name="oldEntity">Existing entity in the system - if there's one. </param>
		/// <returns>Mapped entity. </returns>
		public TEntity Convert(TParam param, TEntity oldEntity)
		{
			TEntity entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = GetEntity(param);
			}

			ConvertSpecific(param, entity);
			entity = ConvertStandart(param, entity);

			return entity;
		}

		/// <summary>
		/// Sets the entity's specific properties - the entity type properties. 
		/// </summary>
		/// <param name="param">Input param model with info. </param>
		/// <param name="entity">Empty entity. </param>
		/// <returns>Mapped entity. </returns>
		public abstract void ConvertSpecific(TParam param, TEntity entity);

		/// <summary>
		/// Returns the entity with its id and/or code properties set.
		/// </summary>
		/// <param name="param">The input info. </param>
		/// <returns>Entity with set id/code. </returns>
		public abstract TEntity GetEntity(TParam param);

		/// <summary>
		/// Maps the entity's properties with the corresponding param properties.
		/// </summary>
		/// <param name="param">Input param with info. </param>
		/// <param name="entity">Empty entity. </param>
		/// <returns>Mapped entity. </returns>
		public TEntity ConvertStandart(TParam param, TEntity entity)
		{
			// A dictionary that holds only the properties of param that don't have the Track attribute 
			//		or have it but its bool value - IsIgnored is not true

			IDictionary<string,PropertyInfo> paramInfo = param.GetType()
				.GetProperties()
				.Where(
					prop => prop.GetCustomAttribute<Track>() == null ||
					prop.GetCustomAttribute<Track>().IsIgnored != true
				)
				.ToDictionary(
					paramProp => paramProp.Name,
					paramProp => paramProp
				);

			IDictionary<string, PropertyInfo> entityInfo = entity.GetType()
				.GetProperties()
				.ToDictionary(
					prop => prop.Name,
					prop => prop
				);

			foreach (var paramPair in paramInfo)
			{
				var att = (Track)Attribute.GetCustomAttribute(paramPair.Value, typeof(Track));

				if (att != null)
				{
					entity.GetType()
						.GetProperty(att.Destination)
						.SetValue(entity, 
						paramPair.Value.GetValue(param));
				}
				else
				{
					if (entityInfo.ContainsKey(paramPair.Key))
					{
						entity.GetType()
							.GetProperty(paramPair.Key)
							.SetValue(entity, 
							paramPair.Value.GetValue(param));
					}
				}
			}

			return entity;
		}
	}
}
