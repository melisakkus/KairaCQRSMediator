using KairaCQRSMediator.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KairaCQRSMediator.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly KairaContext _context;
        protected readonly DbSet<T> _table;
        public GenericRepository(KairaContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _table.FindAsync(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, object>> include = null)
        {
            if (include != null)
            {
                return await _table.AsNoTracking().Include(include).ToListAsync();
            }
            return await _table.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
