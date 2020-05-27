using System.Collections.Generic;
using ToDoListWebAPI.Data.Common;
using ToDoListWebAPI.DataAccess.Dao.Common;
using ToDoListWebAPI.Business.Convertor.Common;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;

namespace ToDoListWebAPI.Business.Processor.Common
{
	public abstract class BaseProcessor<PK, TEntity, TParam, TResult, TParamConvertor, TResultConvertor, TDao> : 
		IBaseProcessor<PK,TParam, TResult>
		where TEntity : Persistent
		where TParam : BaseParam
		where TResult : BaseResult
		where TParamConvertor : IBaseParamConverter<TParam, TEntity>
		where TResultConvertor : IBaseResultConverter<TEntity, TResult>
		where TDao : IBaseDao<PK, TEntity>
	{
		private TParamConvertor _paramConvertor;

		public TParamConvertor ParamConverter
		{
			get { return _paramConvertor; }
			set { _paramConvertor = value; }
		}

		private TResultConvertor _resultConvertor;

		public TResultConvertor ResultConverter
		{
			get { return _resultConvertor; }
			set { _resultConvertor = value; }
		}

		private TDao _dao;

		public TDao Dao
		{
			get { return _dao; }
			set { _dao = value; }
		}

		public BaseProcessor(TParamConvertor paramConvertor, TResultConvertor resultConvertor, TDao dao)
		{
			_paramConvertor = paramConvertor;
			_resultConvertor = resultConvertor;
			_dao = dao;
		}

		public TResult Create(TParam param)
		{
			ValidateParametersStandart(param);
			ValidateParametersSpecific(param, default); 

			TEntity entity = ParamConverter.Convert(param,null);

			Dao.Save(entity);

			return ResultConverter.Convert(entity);
		}

		public List<TResult> Create(List<TParam> param)
		{
			List<TEntity> entities = new List<TEntity>();
			param.ForEach(item => entities.Add(ParamConverter.Convert(item, null)));

			Dao.Save(entities);

			List<TResult> result = new List<TResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));

			return result;
		}

		public virtual void Erase(PK id)
		{
			Dao.Erase(id);
		}

		public void Erase(List<PK> idList)
		{
			Dao.Erase(idList);
		}

		public void Delete(PK id)
		{
			ValidateParametersSpecific(null, id);

			Dao.Delete(id);
		}

		public void Delete(List<PK> idList)
		{
			Dao.Delete(idList);
		}

		public TResult Find(PK id)
		{
			TEntity entity = Dao.Find(id);

			return ResultConverter.Convert(entity);
		}

		public List<TResult> Find()
		{
			List<TResult> results = new List<TResult>();

			Dao.Find()
				.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			results = CheckIfActive(results);

			return results;
		}

		public List<TResult> FindByField(string fieldName, string value)
		{
			List<TEntity> entities = Dao.FindByField(fieldName, value);
			List<TResult> result = new List<TResult>();

			entities.ForEach(entity=>result.Add(ResultConverter.Convert(entity)));
			result = CheckIfActive(result);

			return result;
		}

		public void Update(PK id, TParam param)
		{
			ValidateParametersSpecific(param, id);

			TEntity oldEntity = Dao.Find(id);
			TEntity newEntity = ParamConverter.Convert(param, oldEntity);
			
			Dao.Update(newEntity);
		}

		public void Update(List<TParam> param)
		{
			List<TEntity> entities = new List<TEntity>();

			foreach (var item in param)
			{
				TEntity oldEntity = Dao.Find(GetPK(item));
				TEntity newEntity = ParamConverter.Convert(item, oldEntity);

				entities.Add(newEntity);
			}

			Dao.Update(entities);
		}

		protected abstract PK GetPK(TParam entity);

		public void ValidateParametersStandart(TParam param)
		{
			var paramInfo = param.GetType().GetProperties()
				.ToDictionary(
					param => param.Name,
					param => param
				);

			foreach (var pair in paramInfo)
			{
				if (pair.Key.EndsWith("Id") 
					&& pair.Key.Length > 2 
					&& pair.Value.GetValue(param).ToString() == "0")
				{
					param.GetType()
						.GetProperty(pair.Key)
						.SetValue(param, 1);
				}
			}
		}

		public void ValidateParameters(List<TParam> param) { }

		protected virtual void ValidateParametersSpecific(TParam param, PK id) { }

		public List<TResult> CheckIfActive(List<TResult> results)
		{
			List<TResult> filteredResult = new List<TResult>();
			foreach (var result in results)
			{
				if (result.Active != 0)
				{
					filteredResult.Add(result);
				}
			}

			return filteredResult;
		}
	}
}
