using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UserGroupStatus
{
    public class UserGroupStatusResultConverter : BaseResultConverter<Data.Entity.UserGroupStatus, UserGroupStatusResult>, 
        IUserGroupStatusResultConverter
    {
        public override void ConvertSpecific(Data.Entity.UserGroupStatus entity, UserGroupStatusResult result) { }

        public override UserGroupStatusResult GetNewResult()
        {
            return new UserGroupStatusResult();
        }
    }
}
