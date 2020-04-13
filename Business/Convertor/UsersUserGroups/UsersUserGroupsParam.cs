using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UsersUserGroups
{
    public class UsersUserGroupsParam : BaseParam
    {
        public long UserId { get; set; }

        public long GroupId { get; set; }
    }
}
