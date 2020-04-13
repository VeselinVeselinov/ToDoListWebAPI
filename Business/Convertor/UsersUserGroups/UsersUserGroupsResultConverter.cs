using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UsersUserGroups
{
    public class UsersUserGroupsResultConverter : BaseResultConverter<Data.Entity.UsersUserGroup, UsersUserGroupsResult>
        , IUsersUserGroupsResultConverter
    {
        public override void ConvertSpecific(Data.Entity.UsersUserGroup entity, UsersUserGroupsResult result)
        {
            result.UserId = entity.User.Id;
            result.UserName = entity.User.UserName;
            result.GroupId = entity.Group.Id;
            result.GroupName = entity.Group.Name;
        }

        public override UsersUserGroupsResult GetNewResult()
        {
            return new UsersUserGroupsResult();
        }
    }
}
