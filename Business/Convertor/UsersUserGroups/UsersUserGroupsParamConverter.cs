using ToDoListWebAPI.DataAccess.Dao.User;
using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.DataAccess.Dao.UserGroup;

namespace ToDoListWebAPI.Business.Convertor.UsersUserGroups
{
    public class UsersUserGroupsParamConverter : BaseParamConverter<UsersUserGroupsParam, Data.Entity.UsersUserGroup>
        , IUsersUserGroupsParamConverter
    {
        private IUserDao _userDao;

        public IUserDao UserDao
        {
            get { return _userDao; }
            set { _userDao = value; }
        }

        private IUserGroupDao _groupDao;

        public IUserGroupDao GroupDao
        {
            get { return _groupDao; }
            set { _groupDao = value; }
        }

        public UsersUserGroupsParamConverter(IUserGroupDao groupDao, IUserDao userDao)
        {
            _groupDao = groupDao;
            _userDao = userDao;
        }

        public override void ConvertSpecific(UsersUserGroupsParam param, Data.Entity.UsersUserGroup entity)
        {
            entity.User = UserDao.Find(param.UserId);
            entity.Group = GroupDao.Find(param.GroupId);
        }

        public override Data.Entity.UsersUserGroup GetEntity(UsersUserGroupsParam param)
        {
            return new Data.Entity.UsersUserGroup()
            {
                Id=param.Id
            };
        }
    }
}
