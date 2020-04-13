using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.AccountStatus
{
	class AccountStausParamConverter: BaseParamConverter<AccountStatusParam
		, Data.Entity.AccountStatus>, IAccountStatusParamConverter
	{
		public override void ConvertSpecific(AccountStatusParam param, Data.Entity.AccountStatus entity) { }

		public override Data.Entity.AccountStatus GetEntity(AccountStatusParam param)
		{
			return new Data.Entity.AccountStatus()
			{
				Id=param.Id,
				Code=param.Code
			};
		}
	}
}
