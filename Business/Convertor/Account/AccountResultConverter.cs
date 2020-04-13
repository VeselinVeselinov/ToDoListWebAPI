using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Account
{
	class AccountResultConverter : BaseResultConverter<Data.Entity.Account, AccountResult>, IAccountResultConverter
	{
		public override void ConvertSpecific(Data.Entity.Account entity, AccountResult result)
		{
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Status.Name;
			result.UserId = entity.User.Id;
			result.UserName = entity.User.UserName;
		}

		public override AccountResult GetNewResult()
		{
			return new AccountResult();
		}
	}
}
