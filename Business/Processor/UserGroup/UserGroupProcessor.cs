using ToDoListWebAPI.Business.Convertor.UserGroup;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.UserGroup;

namespace ToDoListWebAPI.Business.Processor.UserGroup
{
    public class UserGroupProcessor : BaseProcessor<long, Data.Entity.UserGroup, UserGroupParam, UserGroupResult
        , IUserGroupParamConverter, IUserGroupResultConverter, IUserGroupDao>, IUserGroupProcessor
    {
        public UserGroupProcessor(IUserGroupParamConverter paramConvertor, IUserGroupResultConverter resultConvertor
            , IUserGroupDao dao) : base(paramConvertor, resultConvertor, dao)
        {
        }

        protected override long GetPK(UserGroupParam entity)
        {
            return entity.Id;
        }

        protected override void ValidateParametersSpecific(UserGroupParam param)
        { }
    }
}
