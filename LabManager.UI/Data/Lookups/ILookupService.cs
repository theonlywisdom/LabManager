using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.Data.Lookups
{
    public interface ILookupService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
    }

    public interface IClientLookupService : ILookupService<ClientLookUpItem>
    {
    }
}
