using Microsoft.Extensions.Options;
using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.DataAccess.Dao.UserStatus;
using ToDoListWebAPI.Authentication.Common.Hash;
using ToDoListWebAPI.Authentication.Common.Hash.Config;

namespace ToDoListWebAPI.Business.Convertor.User
{
	class UserParamConverter:BaseParamConverter<UserParam, Data.Entity.User>, IUserParamConverter
    {
		private IUserStatusDao _statusDao;

		public IUserStatusDao StatusDao
		{
			get { return _statusDao; }
			set { _statusDao = value; }
		}

		private SecretKeySettings _secretKeySettings;

		public SecretKeySettings SecretKeySettings
		{
			get { return _secretKeySettings; }
			set { _secretKeySettings = value; }
		}

		public UserParamConverter(IUserStatusDao statusDao, IOptions<SecretKeySettings> secretKeySettings)
		{
			_statusDao = statusDao;
			_secretKeySettings = secretKeySettings.Value;
		}

		public string HashPassword(string password)
		{
			string secret = SecretKeySettings.SecretKey;
			var salt = System.Text.Encoding.UTF8.GetBytes(secret);
			password = Hash.Compute(password, salt);

			return password;
		}

		public override void ConvertSpecific(UserParam param, Data.Entity.User entity)
		{
			if (param.Password == "********")
			{
				param.Password = entity.Password;
			}
			else param.Password = HashPassword(param.Password);

			entity.Status = StatusDao.Find(param.StatusId);
		}

		public override Data.Entity.User GetEntity(UserParam param)
		{
			return new Data.Entity.User()
			{
				Id = param.Id
			};
		}
	}
}
