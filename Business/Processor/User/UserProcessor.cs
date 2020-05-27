using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using ToDoListWebAPI.DataAccess.Dao.User;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.Authentication.Common.Hash.Config;
using System.Security.Claims;

namespace ToDoListWebAPI.Business.Processor.User
{
	class UserProcessor : BaseProcessor<long, Data.Entity.User, UserParam, UserResult,
		IUserParamConverter, IUserResultConverter, IUserDao>, IUserProcessor
	{
		private readonly IHttpContextAccessor _httpContextAccessor;

		private SecretKeySettings _secretKeySettings;

		public SecretKeySettings SecretKeySettings
		{
			get { return _secretKeySettings; }
			set { _secretKeySettings = value; }
		}

		public UserProcessor(IUserParamConverter paramConverter, IUserResultConverter resultConverter,
			IUserDao dao, IOptions<SecretKeySettings> secretKeySettings, IHttpContextAccessor httpContextAccessor)
			: base(paramConverter, resultConverter, dao)
		{
			_httpContextAccessor = httpContextAccessor;
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

		protected override void ValidateParametersSpecific(UserParam param, long id)
		{
			if (id != 0)
			{
				var userId = _httpContextAccessor.HttpContext.User
					.FindFirst(claim => claim.Type == ClaimTypes.NameIdentifier)
					.Value;

				var userRoles = _httpContextAccessor.HttpContext
					.User.Claims
					.Where(claim => claim.Type == ClaimTypes.Role)
					.Select(claim => claim.Value)
					.ToList();

				if (!userId.Equals(id) && !userRoles.Contains("Administrator"))
				{
					throw new System.ArgumentException("You are not authorized to execute this command! ");
				}
			}

			if (param != null)
			{
				if (param.Password.Length < 8)
				{
					throw new System.ArgumentException("Password is way too short - it should be at least 8 symbols long! ");
				}

				Data.Entity.User user = Dao.FindByField("username", param.UserName)
					.FirstOrDefault();

				if (user != null && user.Id != id)
				{
					throw new System.ArgumentException("Username is already in use! ");
				}
			}
		}
	}
}
