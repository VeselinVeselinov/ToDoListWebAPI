using Microsoft.AspNetCore.Http;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Convertor.ApiSession;
using ToDoListWebAPI.Business.Convertor.Account;

namespace ToDoListWebAPI.Business.Processor.Authentication
{
    public interface IAuthProcessor
    {
        void Register(AccountParam param, HttpRequest request);

        ApiSessionResult CreateApiSession(UserResult userResult, string hashedAuthToken);

        string GetAuthToken(HttpContext httpContext);

        void TerminateApiSession(HttpContext httpContext);
    }
}
