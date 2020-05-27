using ToDoListWebAPI.Business.Convertor.UserStatus;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.UserStatus;

namespace ToDoListWebAPI.Business.Processor.UserStatus
{
	class UserStatusProcessor : BaseProcessor<long, Data.Entity.UserStatus, UserStatusParam, UserStatusResult
		, IUserStatusParamConverter, IUserStatusResultConverter, IUserStatusDao>, IUserStatusProcessor
	{
		public UserStatusProcessor(IUserStatusParamConverter paramConverter, IUserStatusResultConverter resultConverter,
			IUserStatusDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(UserStatusParam entity)
		{
			return entity.Id;
		}
	}
}
