using ToDoListWebAPI.Business.Convertor.UsersUserGroups;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.UsersUserGroups;

namespace ToDoListWebAPI.Business.Processor.UsersUserGroups
{
    public class UsersUserGroupsProcessor : BaseProcessor<long, Data.Entity.UsersUserGroup, UsersUserGroupsParam
        , UsersUserGroupsResult, IUsersUserGroupsParamConverter, IUsersUserGroupsResultConverter, IUsersUserGroupsDao>
        , IUsersUserGroupsProcessor
    {
        public UsersUserGroupsProcessor(IUsersUserGroupsParamConverter paramConvertor
            , IUsersUserGroupsResultConverter resultConvertor, IUsersUserGroupsDao dao) : base(paramConvertor, resultConvertor, dao)
        {
        }

        protected override long GetPK(UsersUserGroupsParam entity)
        {
            return entity.Id;
        }

        protected override void ValidateParametersSpecific(UsersUserGroupsParam param)
        { }
    }
}
