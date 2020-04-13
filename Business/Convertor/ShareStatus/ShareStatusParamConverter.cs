using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.ShareStatus
{
	class ShareStatusParamConverter:BaseParamConverter<ShareStatusParam, Data.Entity.ShareStatus>
		, IShareStatusParamConverter
    {
		public override void ConvertSpecific(ShareStatusParam param, Data.Entity.ShareStatus entity) { }

		public override Data.Entity.ShareStatus GetEntity(ShareStatusParam param)
		{
			return new Data.Entity.ShareStatus()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
