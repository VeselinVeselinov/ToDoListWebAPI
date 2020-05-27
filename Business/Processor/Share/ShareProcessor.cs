using ToDoListWebAPI.Business.Convertor.Share;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.Share;

namespace ToDoListWebAPI.Business.Processor.Share
{
	class ShareProcessor : BaseProcessor<long, Data.Entity.Share, ShareParam, ShareResult
		, IShareParamConverter, IShareResultConverter, IShareDao>, IShareProcessor
	{
		public ShareProcessor(IShareParamConverter paramConverter, IShareResultConverter resultConverter,
			IShareDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(ShareParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(ShareParam param, long id)
		{ }
	}
}
