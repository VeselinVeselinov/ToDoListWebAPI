namespace ToDoListWebAPI.Business.Convertor.Common
{
	public interface IBaseParamConverter<TParam, TEntity>
	{
		TEntity ConvertStandart(TParam param, TEntity entity);

		void ConvertSpecific(TParam param, TEntity entity);

		TEntity Convert(TParam param, TEntity entity);
	}
}
