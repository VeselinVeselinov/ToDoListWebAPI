using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using ToDoListWebAPI.Business.Convertor.Note;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.Account;
using ToDoListWebAPI.DataAccess.Dao.Note;

namespace ToDoListWebAPI.Business.Processor.Note
{
	class NoteProcessor : BaseProcessor<long, Data.Entity.Note, NoteParam, NoteResult,
		INoteParamConverter, INoteResultConverter, INoteDao>, INoteProcessor
	{
		private readonly IHttpContextAccessor _httpContextAccessor;

		private readonly IAccountDao _accountDao;

		public NoteProcessor(INoteParamConverter paramConverter, INoteResultConverter resultConverter,
			INoteDao dao, IHttpContextAccessor httpContextAccessor, IAccountDao accountDao)
			: base(paramConverter, resultConverter, dao)
		{
			_accountDao = accountDao;
			_httpContextAccessor = httpContextAccessor;
		}

		public List<NoteResult> GetByIdAndCategory(long accountId, string categoryName)
		{
			List<NoteResult> result = new List<NoteResult>();

			Dao.GetByIdAndCategory(accountId, categoryName)
				.ForEach(note => result.Add(ResultConverter.Convert(note)));
			result = CheckIfActive(result);

			return result;
		}

		public List<NoteResult> GetByIdAndContent(long accountId, string content)
		{
			List<NoteResult> result = new List<NoteResult>();

			Dao.GetByIdAndContent(accountId, content)
				.ForEach(note => result.Add(ResultConverter.Convert(note)));
			result = CheckIfActive(result);

			return result;
		}

		public List<NoteResult> GetByIdAndName(long accountId, string name)
		{
			List<NoteResult> result = new List<NoteResult>();

			Dao.GetByIdAndName(accountId, name)
				.ForEach(note => result.Add(ResultConverter.Convert(note)));
			result = CheckIfActive(result);

			return result;
		}

		public List<NoteResult> GetByIdAndType(long accountId, string typeName)
		{
			List<NoteResult> result = new List<NoteResult>();

			Dao.GetByIdAndType(accountId, typeName)
				.ForEach(note => result.Add(ResultConverter.Convert(note)));
			result = CheckIfActive(result);

			return result;
		}

		protected override long GetPK(NoteParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(NoteParam param, long id)
		{
			if (id != 0)
			{
				var userId = _httpContextAccessor.HttpContext.User
					.FindFirst(claim => claim.Type == ClaimTypes.NameIdentifier)
					.Value;

				var noteAccountId = Dao.Find(id).AccountId;

				var userAccountIds = _accountDao
					.FindByField("userid", userId)
					.Select(acc => acc.Id)
					.ToList();

				if (!userAccountIds.Contains(noteAccountId))
				{
					throw new System.ArgumentException("You are not authorized to execute this command! ");
				}
			}
		}
	}
}
