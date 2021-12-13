using LabManager.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.Services
{
    public interface IAuthenticationService
    {
        public enum RegistrationResult
        {
            Success,
            PasswordsDoNotMatch,
            EmailAlreadyExists,
            UsernameAlreadyExists
        }

        Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword);
        Task<Account> Login(string username, string password);
    }
}
