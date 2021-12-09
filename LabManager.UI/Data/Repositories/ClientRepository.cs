using LabManager.DataAccess;
using LabManager.Model;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LabManager.UI.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client, DbSeedContext>, IClientRepository
    {
        public ClientRepository(DbSeedContext context) : base(context)
        {
        }

        public override async Task<Client> GetByIdAsync(int id)
        {
            return await Context.Clients
                .Include(c => c.Addresses)
                .SingleAsync(c => c.Id == id);
        }

    }
}
