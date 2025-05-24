using KairaCQRSMediator.DataAccess.Entities;
using System.Linq.Expressions;

namespace KairaCQRSMediator.Repositories.ProductRepositories
{
    public interface IProductService : IRepository<Product>
    {
        Task<List<Product>> GetLast4Products(Expression<Func<Product, object>> include = null);
        Task<Product> GetRandomProduct(Expression<Func<Product, object>> include = null);
    }
}
