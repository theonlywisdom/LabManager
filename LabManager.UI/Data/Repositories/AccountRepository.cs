using LabManager.DataAccess;
using LabManager.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.Data.Repositories
{
    public class AccountRepository : GenericRepository<Account, DbSeedContext>, IAccountRepository
    {
        public AccountRepository(DbSeedContext context) : base(context)
        {

        }

        public override async Task<Account> GetByIdAsync(int id)
        {
            using (var ctx = base.Context)
            {
                Account entity = await ctx.Accounts
                    .Include(a => a.AccountHolder)
                    .FirstOrDefaultAsync(a => a.AccountHolder.Id == id);

                return entity;
            }
        }

        public async Task<Account> GetByEmailAsync(string email)
        {
            using (var ctx = base.Context)
            {
                Account entity = await ctx.Accounts
                    .Include(a => a.AccountHolder)
                    .FirstOrDefaultAsync(a => a.AccountHolder.Email == email);

                return entity;
            }
        }

        public async Task<Account> GetByUsernameAsync(string username)
        {
            using (var ctx = base.Context)
            {
                Account entity = await ctx.Accounts
                    .Include(a => a.AccountHolder)
                    .FirstOrDefaultAsync(a => a.AccountHolder.UserName == username);

                return entity;
            }
        }

        public async Task<IEnumerable<Account>> GetAllAsync()
        {
            using (var ctx = base.Context)
            {
                IEnumerable<Account> entities = await ctx.Accounts
                    .Include(a => a.AccountHolder)
                    .ToListAsync();

                return entities;
            }
        }
    }

    public interface IAccountRepository : IGenericRepository<Account>
    {
        Task<Account> GetByUsernameAsync(string username);
        Task<Account> GetByEmailAsync(string email);
        Task<IEnumerable<Account>> GetAllAsync();
    }
}
