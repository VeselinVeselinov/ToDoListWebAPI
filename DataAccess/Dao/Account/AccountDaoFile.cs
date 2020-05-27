using ToDoListWebAPI.Storage.Account;
using ToDoListWebAPI.DataAccess.Dao.Common;
using System.Collections.Generic;
using System.Linq;

namespace ToDoListWebAPI.DataAccess.Dao.Account
{
	class AccountDaoFile : BaseDaoFile<long, Data.Entity.Account, IAccountData>, IAccountDao
	{
		public AccountDaoFile(IAccountData dataStorage) : base(dataStorage)
		{
		}

		public List<Data.Entity.Account> GetByIdAndEmail(long userId, string email)
		{
			return DataStorage.GetStorage().Values
					.Where(account => account.UserId.Equals(userId) &&
					account.Email.Equals(email))
					.ToList();
		}

		public List<Data.Entity.Account> GetByIdAndFirstName(long userId, string firstName)
		{
			return DataStorage.GetStorage().Values
					.Where(account => account.UserId.Equals(userId) &&
					account.FirstName.Equals(firstName))
					.ToList();
		}

		public List<Data.Entity.Account> GetByIdAndLastName(long userId, string lastName)
		{
			return DataStorage.GetStorage().Values
					.Where(account => account.UserId.Equals(userId) &&
					account.LastName.Equals(lastName))
					.ToList();
		}

		public List<Data.Entity.Account> GetByIdAndName(long userId, string name)
		{
			return DataStorage.GetStorage().Values
					.Where(account => account.UserId.Equals(userId) &&
					account.Name.Equals(name))
					.ToList();
		}

		public List<Data.Entity.Account> GetByIdAndPhone(long userId, string phone)
		{
			return DataStorage.GetStorage().Values
					.Where(account => account.UserId.Equals(userId) &&
					account.Phone.Equals(phone))
					.ToList();
		}

		protected override long GetPK(Data.Entity.Account entity)
		{
			return entity.Id;
		}
	}
}
