using KairaCQRSMediator.DataAccess.Entities;
using System.Linq.Expressions;

namespace KairaCQRSMediator.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T,object>> include=null);
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
