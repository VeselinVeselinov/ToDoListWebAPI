using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication;
using ToDoListWebAPI.Business.Convertor.User;
using ToDoListWebAPI.Authentication.AuthProvider.Common;

namespace ToDoListWebAPI.Authentication.AuthHandler
{
    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private IEnumerable<IBaseAuthProvider<long>> _providers;

        public IEnumerable<IBaseAuthProvider<long>> Providers
        {
            get { return _providers; }
            set { _providers = value; }
        }

        public BasicAuthHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IEnumerable<IBaseAuthProvider<long>> providers) 
            : base(options, logger, encoder, clock)
        {
            _providers = providers;
        }

        protected async override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization") && !Request.Headers.ContainsKey("AuthToken"))
            {
                return AuthenticateResult.Fail("Some form of authentication creditentials should be included! ");
            }
            
            UserResult userResult = null;
            try
            {
                foreach (var provider in Providers)
                {
                    if (userResult == null)
                    {
                        userResult = await provider.AuthenticateAsync(Request);
                    }
                }
            }
            catch
            {
                return AuthenticateResult.Fail("Authentication has failed.");
            }

            if (userResult == null)
            {
                return AuthenticateResult.Fail("Wrong username or password.");
            }

            userResult.Password = null;
            var firstProvider = Providers.First();
            var ticket = await firstProvider.BuildAuthenticationTicket(userResult, Scheme);

            return AuthenticateResult.Success(ticket);
        }
    }
}