using ToDoListWebAPI.Authentication.AuthProvider.Common;

namespace ToDoListWebAPI.Authentication.AuthProvider.TokenAuthentication
{
    public interface ITokenAuthProvider : IBaseAuthProvider<long>
    {
    }
}
