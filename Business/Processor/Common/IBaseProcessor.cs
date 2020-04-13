using System.Collections.Generic;
using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Processor.Common
{
	public interface IBaseProcessor<PK,TParam, TResult>
		where TParam:BaseParam
		where TResult:BaseResult
	{
		TResult Create(TParam param);
		List<TResult> Create(List<TParam> param);

		void Update(PK id, TParam param);
		void Update(List<TParam> param);

		void Erase(PK id);
		void Erase(List<PK> idList);

		void Delete(PK id);
		void Delete(List<PK> idList);

		TResult Find(PK id);
		List<TResult> Find();
		List<TResult> FindByField(string fieldName, string value);

		void ValidateParametersStandart(TParam param);
		void ValidateParameters(List<TParam> param);
	}
}
