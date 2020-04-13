using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using ToDoListWebAPI.Business.Processor.User;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Processor.UsersUserGroups;

namespace ToDoListWebAPI.Authentication.AuthProvider.Common
{
    public abstract class BaseAuthProvider<PK> : IBaseAuthProvider<PK>
    {
        private IUserProcessor _userProcessor;

        public IUserProcessor UserProcessor
        {
            get { return _userProcessor; }
            set { _userProcessor = value; }
        }

        private IUsersUserGroupsProcessor _usersUserGroupsProcessor;

        public IUsersUserGroupsProcessor UsersUserGroupsProcessor
        {
            get { return _usersUserGroupsProcessor; }
            set { _usersUserGroupsProcessor = value; }
        }

        public BaseAuthProvider(IUserProcessor userProcessor,
            IUsersUserGroupsProcessor usersUserGroupsProcessor)
        {
            _usersUserGroupsProcessor = usersUserGroupsProcessor;
            _userProcessor = userProcessor;
        }

        public abstract Task<UserResult> AuthenticateAsync(HttpRequest request);

        protected abstract PK GetPK(UserResult userResult); 

        public async Task<List<string>> GetUserRolesAsync(PK id)
        {
            return await Task.Run(
                () => UsersUserGroupsProcessor.FindByField("userid", id.ToString())
                .Select(entity => entity.GroupName)
                .ToList());
        }

        public async Task<AuthenticationTicket> BuildAuthenticationTicket(UserResult userResult, AuthenticationScheme scheme)
        {
            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, userResult.Id.ToString()),
                new Claim(ClaimTypes.Name, userResult.UserName)
            };

            PK userId = GetPK(userResult);
            var roles = await GetUserRolesAsync(userId);

            foreach (var role in roles)
            {
                claims = claims.Concat(new Claim[] { new Claim(ClaimTypes.Role, role) }).ToArray();
            }

            var identity = new ClaimsIdentity(claims, scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, scheme.Name);

            return ticket;
        }
    }
}
