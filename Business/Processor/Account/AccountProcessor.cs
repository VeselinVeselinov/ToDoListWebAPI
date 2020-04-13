using ToDoListWebAPI.DataAccess.Dao.Account;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.Business.Convertor.Account;

namespace ToDoListWebAPI.Business.Processor.Account
{
	class AccountProcessor : BaseProcessor<long, Data.Entity.Account, AccountParam, AccountResult,
		IAccountParamConverter, IAccountResultConverter, IAccountDao>, IAccountProcessor
	{
		public AccountProcessor(IAccountParamConverter paramConverter, IAccountResultConverter resultConverter,
			IAccountDao dao) 
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(AccountParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(AccountParam param)
		{
			var account = Dao.FindByField("email", param.Email).Count;
			if (account != 0)
			{
				throw new System.ArgumentException("Email is already in use! ");
			}
		}
	}
}
