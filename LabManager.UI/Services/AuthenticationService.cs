using LabManager.Model;
using LabManager.UI.Data.Repositories;
using LabManager.UI.Exceptions;
using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;

namespace LabManager.UI.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IPasswordHasher _passwordHasher;

        public AuthenticationService(IAccountRepository accountRepository, IPasswordHasher passwordHasher)
        {
            _accountRepository = accountRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<Account> Login(string username, string password)
        {
            Account storedAccount = await _accountRepository.GetByUsernameAsync(username);

            PasswordVerificationResult passwordResult = _passwordHasher
                .VerifyHashedPassword(storedAccount.AccountHolder.PasswordHash, password);

            if (passwordResult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordException(username, password);
            }

            return storedAccount;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword)
        {
            RegistrationResult result = RegistrationResult.Success;

            if (password != confirmPassword)
            {
                result = RegistrationResult.PasswordsDoNotMatch;
            }

            Account emailUser = await _accountRepository.GetByEmailAsync(email);

            if (emailUser != null)
            {
                result = RegistrationResult.EmailAlreadyExists;
            }

            Account usernameAccount = await _accountRepository.GetByUsernameAsync(username);

            if (usernameAccount != null)
            {
                result = RegistrationResult.UsernameAlreadyExists;
            }

            if (result == RegistrationResult.Success)
            {
                string hashedPassword = _passwordHasher.HashPassword(password);

                User user = new User()
                {
                    Email = email,
                    UserName = username,
                    PasswordHash = hashedPassword,
                    DateJoined = DateTime.Now
                };


                Account account = new Account()
                {
                    AccountHolder = user
                };

                await _accountRepository.Create(account);
            }

            return result;
        }
    }
}
