using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UsersUserGroups
{
    public class UsersUserGroupsResult : BaseResult
    {
        public long UserId { get; set; }

        public string UserName { get; set; }

        public long GroupId { get; set; }

        public string GroupName { get; set; }
    }
}
