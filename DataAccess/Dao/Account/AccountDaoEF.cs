using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Account
{
	class AccountDaoEF : BaseDaoEF<long, Data.Entity.Account>, IAccountDao
	{
		public AccountDaoEF(DbContext dbContext) : base(dbContext)
		{
		}

		public List<Data.Entity.Account> GetByIdAndEmail(long userId, string email)
		{
			return Entities
					.Where(account => account.UserId.Equals(userId) &&
					account.Email.Equals(email))
					.ToList();
		}

		public List<Data.Entity.Account> GetByIdAndFirstName(long userId, string firstName)
		{
			return Entities
					.Where(account => account.UserId.Equals(userId) &&
					account.FirstName.Equals(firstName))
					.ToList();
		}

		public List<Data.Entity.Account> GetByIdAndLastName(long userId, string lastName)
		{
			return Entities
					.Where(account => account.UserId.Equals(userId) &&
					account.LastName.Equals(lastName))
					.ToList();
		}

		public List<Data.Entity.Account> GetByIdAndName(long userId, string name)
		{
			return Entities
					.Where(account => account.UserId.Equals(userId) &&
					account.Name.Equals(name))
					.ToList();
		}

		public List<Data.Entity.Account> GetByIdAndPhone(long userId, string phone)
		{
			return Entities
					.Where(account => account.UserId.Equals(userId) &&
					account.Phone.Equals(phone))
					.ToList();
		}
	}
}
