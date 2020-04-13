using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.ShareStatus
{
	class ShareStatusResultConverter : BaseResultConverter<Data.Entity.ShareStatus,ShareStatusResult>
		, IShareStatusResultConverter
    {
		public override void ConvertSpecific(Data.Entity.ShareStatus entity, ShareStatusResult result) { }

		public override ShareStatusResult GetNewResult()
		{
			return new ShareStatusResult();
		}
	}
}
