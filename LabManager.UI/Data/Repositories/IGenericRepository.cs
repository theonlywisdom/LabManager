using System.Threading.Tasks;

namespace LabManager.UI.Data.Repositories
{
    public interface IGenericRepository<T>
    {
        public Task<T> GetByIdAsync(int id);
        Task SaveAsync();
        bool HasChanges();
        Task<T> Create(T model);
        void Add(T model);
        void Remove(T model);
    }
}
