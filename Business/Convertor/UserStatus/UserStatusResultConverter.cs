using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UserStatus
{
	class UserStatusResultConverter : BaseResultConverter<Data.Entity.UserStatus, UserStatusResult>
		, IUserStatusResultConverter
    {
		public override void ConvertSpecific(Data.Entity.UserStatus entity, UserStatusResult result) { }

		public override UserStatusResult GetNewResult()
		{
			return new UserStatusResult();
		}
	}
}
