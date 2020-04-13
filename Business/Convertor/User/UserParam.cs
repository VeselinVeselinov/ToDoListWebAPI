using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.User
{
	public class UserParam:BaseParam
    {
		public string UserName { get; set; }

		public string Password { get; set; }

		public long StatusId { get; set; }
	}
}
