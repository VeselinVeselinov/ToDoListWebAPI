namespace ToDoListWebAPI.Data.Common.ApiSession
{
    public class ApiSession : PersistentNamed
    {
        public long  UserId { get; set; }

        public string AuthToken { get; set; }
    }
}
