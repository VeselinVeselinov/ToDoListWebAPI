using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Processor.User;
using ToDoListWebAPI.Business.Processor.ApiSession;
using ToDoListWebAPI.Authentication.AuthProvider.Common;
using ToDoListWebAPI.Business.Processor.UsersUserGroups;

namespace ToDoListWebAPI.Authentication.AuthProvider.TokenAuthentication
{
    public class TokenAuthProvider : BaseAuthProvider<long>, ITokenAuthProvider
    {
        private IApiSessionProcessor _apiSessionprocessor;

        public IApiSessionProcessor ApiSessionProcessor
        {
            get { return _apiSessionprocessor; }
            set { _apiSessionprocessor = value; }
        }

        public TokenAuthProvider(IUserProcessor userProcessor,
            IUsersUserGroupsProcessor usersUserGroupsProcessor, 
            IApiSessionProcessor apiSessionProcessor)
            : base(userProcessor, usersUserGroupsProcessor)
        {
            _apiSessionprocessor = apiSessionProcessor;
        }

        protected override long GetPK(UserResult userResult)
        {
            return userResult.Id;
        }

        public override async Task<UserResult> AuthenticateAsync(HttpRequest request)
        {
            UserResult userResult = null;
            if (request.Headers.ContainsKey("AuthToken"))
            {
                string headerValue = request.Headers["AuthToken"].ToString();
                var apiSession = await ApiSessionProcessor.GetByAuthTokenAsync(headerValue);
                userResult = UserProcessor.Find(apiSession.UserId);
            }

            return userResult;
        }
    }
}
