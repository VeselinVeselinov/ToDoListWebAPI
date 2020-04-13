using ToDoListWebAPI.Business.Convertor.AccountStatus;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.AccountStatus;

namespace ToDoListWebAPI.Business.Processor.AccountStatus
{
	class AccountStatusProcessor : BaseProcessor<long, Data.Entity.AccountStatus, AccountStatusParam, AccountStatusResult
		, IAccountStatusParamConverter, IAccountStatusResultConverter, IAccountStatusDao>, IAccountStatusProcessor
	{
		public AccountStatusProcessor(IAccountStatusParamConverter paramConverter, IAccountStatusResultConverter resultConverter,
			IAccountStatusDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(AccountStatusParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(AccountStatusParam param)
		{ }
	}
}
