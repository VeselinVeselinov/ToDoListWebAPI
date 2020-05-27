using ToDoListWebAPI.Business.Convertor.UserGroupStatus;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.UserGroupStatus;

namespace ToDoListWebAPI.Business.Processor.UserGroupStatus
{
    public class UserGroupStatusProcessor : BaseProcessor<long, Data.Entity.UserGroupStatus,
        UserGroupStatusParam, UserGroupStatusResult, IUserGroupStatusParamConverter, IUserGroupStatusResultConverter,
        IUserGroupStatusDao>, IUserGroupStatusProcessor
    {
        public UserGroupStatusProcessor(IUserGroupStatusParamConverter paramConvertor,
            IUserGroupStatusResultConverter resultConvertor, IUserGroupStatusDao dao) 
            : base(paramConvertor, resultConvertor, dao)
        {
        }

        protected override long GetPK(UserGroupStatusParam entity)
        {
            return entity.Id;
        }

        protected override void ValidateParametersSpecific(UserGroupStatusParam param, long id)
        { }
    }
}
