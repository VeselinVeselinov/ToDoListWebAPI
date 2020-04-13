using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.AccountStatus
{
	class AccountStatusResultConverter : BaseResultConverter<Data.Entity.AccountStatus
		, AccountStatusResult>,IAccountStatusResultConverter
    {
		public override void ConvertSpecific(Data.Entity.AccountStatus entity, AccountStatusResult result) { }

		public override AccountStatusResult GetNewResult()
		{
			return new AccountStatusResult();
		}
	}
}
