using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.DataAccess.Dao.UserGroupStatus;

namespace ToDoListWebAPI.Business.Convertor.UserGroup
{
    public class UserGroupParamConverter : BaseParamConverter<UserGroupParam, Data.Entity.UserGroup>
        , IUserGroupParamConverter
    {
        private IUserGroupStatusDao _statusDao;

        public IUserGroupStatusDao StatusDao
        {
            get { return _statusDao; }
            set { _statusDao = value; }
        }

        public UserGroupParamConverter(IUserGroupStatusDao statusDao)
        {
            _statusDao = statusDao;
        }

        public override void ConvertSpecific(UserGroupParam param, Data.Entity.UserGroup entity) 
        {
            entity.Status = StatusDao.Find(param.StatusId);
        }

        public override Data.Entity.UserGroup GetEntity(UserGroupParam param)
        {
            return new Data.Entity.UserGroup()
            {
                Id = param.Id,
                Code = param.Code
            };
        }
    }
}
