using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using ToDoListWebAPI.Business.Convertor.User;

namespace ToDoListWebAPI.Authentication.AuthProvider.Common
{
    public interface IBaseAuthProvider<PK>
    {
        Task<UserResult> AuthenticateAsync(HttpRequest request);

        Task<List<string>> GetUserRolesAsync(PK id);

        Task<AuthenticationTicket> BuildAuthenticationTicket(UserResult userResult, AuthenticationScheme scheme);
    }
}
