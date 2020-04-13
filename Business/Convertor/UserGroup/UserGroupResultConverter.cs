using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UserGroup
{
    public class UserGroupResultConverter : BaseResultConverter<Data.Entity.UserGroup, UserGroupResult>
        , IUserGroupResultConverter
    {
        public override void ConvertSpecific(Data.Entity.UserGroup entity, UserGroupResult result) 
        {
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
        }

        public override UserGroupResult GetNewResult()
        {
            return new UserGroupResult();
        }
    }
}
