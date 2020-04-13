using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.Business.Convertor.Common.CustomAttributes;

namespace ToDoListWebAPI.Business.Convertor.Account
{
	public class AccountResult : BaseResultNamed
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Address { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }

		[Track("User","Id")]
		public long UserId { get; set; }

		[Track("User", "UserName")]
		public string UserName { get; set; }

		[Track("Status", "Id")]
		public long StatusId { get; set; }

		[Track("Status", "Name")]
		public string StatusName { get; set; }
	}
}
