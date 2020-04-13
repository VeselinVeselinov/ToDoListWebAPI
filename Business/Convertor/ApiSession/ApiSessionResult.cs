using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.ApiSession
{
    public class ApiSessionResult : BaseResultNamed
    {
        public long UserId { get; set; }

        public string AuthToken { get; set; }
    }
}
