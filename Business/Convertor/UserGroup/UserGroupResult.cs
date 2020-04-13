using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UserGroup
{
    public class UserGroupResult:BaseResultNamed
    {
        public long StatusId { get; set; }

        public string StatusName { get; set; }
    }
}
