using System.Collections.Generic;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Account
{
	interface IAccountDao : IBaseDao<long, Data.Entity.Account>
    {
        List<Data.Entity.Account> GetByIdAndName(long userId, string name);

        List<Data.Entity.Account> GetByIdAndFirstName(long userId, string firstName);

        List<Data.Entity.Account> GetByIdAndLastName(long userId, string lastName);

        List<Data.Entity.Account> GetByIdAndEmail(long userId, string email);

        List<Data.Entity.Account> GetByIdAndPhone(long userId, string phone);
    }
}
