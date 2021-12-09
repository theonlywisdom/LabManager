using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LabManager.UI.Data.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected readonly TContext Context;

        public GenericRepository(TContext context)
        {
            this.Context = context;
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }
    }
}
