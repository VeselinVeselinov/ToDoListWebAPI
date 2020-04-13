using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Processor.User;
using ToDoListWebAPI.Authentication.AuthProvider.Common;
using ToDoListWebAPI.Business.Processor.UsersUserGroups;

namespace ToDoListWebAPI.Authentication.AuthProvider.BasicAuthentication
{
    public class BasicAuthProvider : BaseAuthProvider<long>, IBasicAuthProvider
    {
        public BasicAuthProvider(IUserProcessor userProcessor,
            IUsersUserGroupsProcessor usersUserGroupsProcessor)
            : base(userProcessor, usersUserGroupsProcessor)
        {
        }

        protected override long GetPK(UserResult userResult)
        {
            return userResult.Id;
        }

        public override async Task<UserResult> AuthenticateAsync(HttpRequest request)
        {
            UserResult result = null;
            if (request.Headers.ContainsKey("Authorization"))
            {
                var authHeader = AuthenticationHeaderValue.Parse(request.Headers["Authorization"]);
                var credentialBytes = System.Convert.FromBase64String(authHeader.Parameter);
                var credentials = System.Text.Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                var username = credentials[0];
                var password = credentials[1];

                result = await UserProcessor.GetByUsernameAndPasswordAsync(username, password);
            }

            return result;
        }
    }
}
