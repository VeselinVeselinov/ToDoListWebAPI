using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using ToDoListWebAPI.DataAccess.Dao.User;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.Authentication.Common.Hash.Config;
using System.Linq;

namespace ToDoListWebAPI.Business.Processor.User
{
	class UserProcessor : BaseProcessor<long, Data.Entity.User, UserParam, UserResult,
		IUserParamConverter, IUserResultConverter, IUserDao>, IUserProcessor
	{
		private SecretKeySettings _secretKeySettings;

		public SecretKeySettings SecretKeySettings
		{
			get { return _secretKeySettings; }
			set { _secretKeySettings = value; }
		}

		public UserProcessor(IUserParamConverter paramConverter, IUserResultConverter resultConverter,
			IUserDao dao, IOptions<SecretKeySettings> secretKeySettings)
			: base(paramConverter, resultConverter, dao)
		{
			_secretKeySettings = secretKeySettings.Value;
		}

		public async Task<UserResult> GetByUsernameAndPasswordAsync(string username, string password)
		{
			password = ParamConverter.HashPassword(password);
			var user = await Dao.GetByUsernameAndPasswordAsync(username, password);
			UserResult result = ResultConverter.Convert(user);

			return result;
		}

		protected override long GetPK(UserParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(UserParam param)
		{
			var user = Dao
				.FindByField("username", param.UserName)
				.FirstOrDefault();

			if (user != null)
			{
				throw new System.ArgumentException("Username is already in use! ");
			}
		}
	}
}
