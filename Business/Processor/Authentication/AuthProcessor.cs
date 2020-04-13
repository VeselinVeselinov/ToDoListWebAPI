using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Business.Processor.User;
using ToDoListWebAPI.Authentication.Common.Hash;
using ToDoListWebAPI.Business.Processor.ApiSession;
using ToDoListWebAPI.Business.Convertor.ApiSession;
using ToDoListWebAPI.Business.Convertor.Account;
using ToDoListWebAPI.Business.Processor.Account;

namespace ToDoListWebAPI.Business.Processor.Authentication
{
    public class AuthProcessor : IAuthProcessor
    {
        private readonly IAccountProcessor _accountProcessor;

        private IApiSessionProcessor _apiSessionProcessor;

        public IApiSessionProcessor ApiSessionProcessor
        {
            get { return _apiSessionProcessor; }
            set { _apiSessionProcessor = value; }
        }

        private IUserProcessor _userProcessor;

        public IUserProcessor UserProcessor
        {
            get { return _userProcessor; }
            set { _userProcessor = value; }
        }

        public AuthProcessor(IApiSessionProcessor apiSessionProcessor,
            IUserProcessor userProcessor, IAccountProcessor accountProcessor)
        {
            _apiSessionProcessor = apiSessionProcessor;
            _userProcessor = userProcessor;
            _accountProcessor = accountProcessor;
        }

        public void Register(AccountParam param, HttpRequest request)
        {
            string[] credentials = GetHeaderCredentials(request);
            ValidateParameters(credentials[0], param.Email);

            UserParam userParam = new UserParam()
            {
                UserName = credentials[0],
                Password = credentials[1],
                StatusId = 1
            };
            UserResult user = UserProcessor.Create(userParam);

            param.UserId = user.Id;
            param.StatusId = 1;
            _accountProcessor.Create(param);
        }

        public ApiSessionResult CreateApiSession(UserResult userResult, string hashedAuthToken)
        {
            ApiSessionParam sessionParam = new ApiSessionParam()
            {
                Code = userResult.UserName + $"{System.DateTime.Now.TimeOfDay}",
                Name = userResult.StatusName,
                Description = $"This is {userResult.UserName}'s api session. Created on {System.DateTime.Now}",
                Active = userResult.Active,
                UserId = userResult.Id,
                AuthToken = hashedAuthToken
            };

            ApiSessionResult apiSession = ApiSessionProcessor.Create(sessionParam);

            return apiSession;
        }

        public string GetAuthToken(HttpContext httpContext)
        {
            var userId = httpContext.User.FindFirst
                (claim => claim.Type == ClaimTypes.NameIdentifier)
                .Value;

            byte[] salt = Salt.GenerateSalt();
            string authToken = System.Guid.NewGuid().ToString("N");
            string hashedAuthToken = Hash.Compute(authToken, salt);
            hashedAuthToken = TrimToken(hashedAuthToken);

            UserResult userResult = UserProcessor.FindByField("id", userId).SingleOrDefault();
            ApiSessionResult sessionResult = CreateApiSession(userResult, hashedAuthToken);

            return sessionResult.AuthToken;
        }

        public void TerminateApiSession(HttpContext httpContext)
        {
            string authToken = httpContext.Request.Headers["AuthToken"].ToString();
            ApiSessionResult sessionResult = ApiSessionProcessor
                .FindByField("authToken", authToken)
                .SingleOrDefault();

            ApiSessionProcessor.Erase(sessionResult.Id);
        }

        private string TrimToken(string token)
        {
            token = token.Replace("/", "");
            token = token.Replace("+", "");

            return token;
        }

        private void ValidateParameters(string username, string email)
        {
            var existingUserName = UserProcessor
                .FindByField("username", username)
                .SingleOrDefault();

            var existingEmail = _accountProcessor
                .FindByField("email", email)
                .SingleOrDefault();

            switch (existingUserName != null, existingEmail != null)
            {
                case (true, false):
                    throw new System.ArgumentException("Username is already in use! ");
                case (false, true):
                    throw new System.ArgumentException("Email is already in use! ");
                case (true, true):
                    throw new System.ArgumentException("Both username and email are already in use! ");
                default:
                    break;
            }
        }

        private static string[] GetHeaderCredentials(HttpRequest request)
        {
            string[] credentials = null;
            if (request.Headers.ContainsKey("Registration"))
            {
                var authHeader = request.Headers["Registration"].ToString();
                var credentialBytes = System.Convert.FromBase64String(authHeader);
                credentials = System.Text.Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
            }

            return credentials;
        }
    }
}
