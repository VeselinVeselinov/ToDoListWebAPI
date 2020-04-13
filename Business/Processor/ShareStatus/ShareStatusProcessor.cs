using ToDoListWebAPI.Business.Convertor.ShareStatus;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.ShareStatus;

namespace ToDoListWebAPI.Business.Processor.ShareStatus
{
	class ShareStatusProcessor : BaseProcessor<long, Data.Entity.ShareStatus, ShareStatusParam, ShareStatusResult
		, IShareStatusParamConverter, IShareStatusResultConverter, IShareStatusDao>, IShareStatusProcessor
	{
		public ShareStatusProcessor(IShareStatusParamConverter paramConverter, IShareStatusResultConverter resultConverter,
			IShareStatusDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(ShareStatusParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(ShareStatusParam param)
		{ }
	}
}
