using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.UserGroupStatus
{
    public class UserGroupStatusParamConverter : BaseParamConverter<UserGroupStatusParam, Data.Entity.UserGroupStatus>,
         IUserGroupStatusParamConverter
    {
        public override void ConvertSpecific(UserGroupStatusParam param, Data.Entity.UserGroupStatus entity) { }

        public override Data.Entity.UserGroupStatus GetEntity(UserGroupStatusParam param)
        {
            return new Data.Entity.UserGroupStatus()
            {
                Id = param.Id,
                Code = param.Code
            };
        }
    }
}
