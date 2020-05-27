using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.User
{
	class UserResultConverter : BaseResultConverter<Data.Entity.User, UserResult>, IUserResultConverter
    {
		public override void ConvertSpecific(Data.Entity.User entity, UserResult result)
		{
			result.Password = "This is a well kept secret. ;)";
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Status.Name;
		}

		public override UserResult GetNewResult()
		{
			return new UserResult();
		}
	}
}
