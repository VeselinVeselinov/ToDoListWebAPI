using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UserStatus
{
	class UserStatusParamConverter : BaseParamConverter<UserStatusParam, Data.Entity.UserStatus>
		, IUserStatusParamConverter
    {
		public override void ConvertSpecific(UserStatusParam param, Data.Entity.UserStatus entity) { }

		public override Data.Entity.UserStatus GetEntity(UserStatusParam param)
		{
			return new Data.Entity.UserStatus()
			{
				Id = param.Id,
				Code = param.Code
			};
		}
	}
}
