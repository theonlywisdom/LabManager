using System.Threading.Tasks;

namespace LabManager.UI.Data.Repositories
{
    public interface IGenericRepository<T>
    {
        public Task<T> GetByIdAsync(int id);

    }
}
