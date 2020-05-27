using System.Linq;
using ToDoListWebAPI.DataAccess.Dao.Account;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.Business.Convertor.Account;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ToDoListWebAPI.Business.Processor.Account
{
	class AccountProcessor : BaseProcessor<long, Data.Entity.Account, AccountParam, AccountResult,
		IAccountParamConverter, IAccountResultConverter, IAccountDao>, IAccountProcessor
	{
		private readonly IHttpContextAccessor _httpContextAccessor;

		public AccountProcessor(IAccountParamConverter paramConverter, IAccountResultConverter resultConverter,
			IAccountDao dao, IHttpContextAccessor httpContextAccessor) 
			: base(paramConverter, resultConverter, dao)
		{
			_httpContextAccessor = httpContextAccessor;
		}

		public List<AccountResult> GetByIdAndEmail(long userId, string email)
		{
			List<AccountResult> result = new List<AccountResult>();

			Dao.GetByIdAndEmail(userId, email)
				.ForEach(acc => result.Add(ResultConverter.Convert(acc)));
			result = CheckIfActive(result);

			return result;
		}

		public List<AccountResult> GetByIdAndFirstName(long userId, string firstName)
		{
			List<AccountResult> result = new List<AccountResult>();

			Dao.GetByIdAndFirstName(userId, firstName)
				.ForEach(acc => result.Add(ResultConverter.Convert(acc)));
			result = CheckIfActive(result);

			return result;
		}

		public List<AccountResult> GetByIdAndLastName(long userId, string lastName)
		{
			List<AccountResult> result = new List<AccountResult>();

			Dao.GetByIdAndLastName(userId, lastName)
				.ForEach(acc => result.Add(ResultConverter.Convert(acc)));
			result = CheckIfActive(result);

			return result;
		}

		public List<AccountResult> GetByIdAndName(long userId, string name)
		{
			List<AccountResult> result = new List<AccountResult>();

			Dao.GetByIdAndName(userId, name)
				.ForEach(acc => result.Add(ResultConverter.Convert(acc)));
			result = CheckIfActive(result);

			return result;
		}

		public List<AccountResult> GetByIdAndPhone(long userId, string phone)
		{
			List<AccountResult> result = new List<AccountResult>();

			Dao.GetByIdAndPhone(userId, phone)
				.ForEach(acc => result.Add(ResultConverter.Convert(acc)));
			result = CheckIfActive(result);

			return result;
		}

		protected override long GetPK(AccountParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(AccountParam param, long id)
		{
			if (id != 0)
			{
				var userId = _httpContextAccessor.HttpContext.User
					.FindFirst(claim => claim.Type == ClaimTypes.NameIdentifier)
					.Value;

				var userAccounts = Dao.FindByField("userid", userId)
					.Select(acc => acc.Id);

				var userRoles = _httpContextAccessor.HttpContext
					.User.Claims
					.Where(claim => claim.Type == ClaimTypes.Role)
					.Select(claim => claim.Value)
					.ToList();

				if (!userAccounts.Contains(id) && !userRoles.Contains("Administrator"))
				{
					throw new System.ArgumentException("You are not authorized to execute this command! ");
				}

			}

			if(param != null)
			{
				var account = Dao.FindByField("email", param.Email)
				.FirstOrDefault();

				if (account != null && account.Id != id)
				{
					throw new System.ArgumentException("Email is already in use! ");
				}
			}
		}
	}
}
