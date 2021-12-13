using LabManager.Model;
using System;
using System.Threading.Tasks;

namespace LabManager.UI.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        //private readonly IAccountRepository
        public Task<Account> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<IAuthenticationService.RegistrationResult> Register(string email, string username, string password, string confirmPassword)
        {
            throw new NotImplementedException();
        }
    }
}
