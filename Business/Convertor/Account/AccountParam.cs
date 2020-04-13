using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Account
{
	public class AccountParam : BaseParamNamed
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Address { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }

		public long UserId { get; set; }

		public long StatusId { get; set; }
	}
}
