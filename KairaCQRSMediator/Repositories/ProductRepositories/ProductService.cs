using KairaCQRSMediator.DataAccess.Context;
using KairaCQRSMediator.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KairaCQRSMediator.Repositories.ProductRepositories
{
    public class ProductService : GenericRepository<Product>, IProductService
    {
        public ProductService(KairaContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetLast4Products(Expression<Func<Product, object>> include = null)
        {
            var values = await _table.AsNoTracking().Include(include).ToListAsync();
            return values.OrderByDescending(x => x.ProductId).Take(4).ToList();
        }

        public async Task<Product> GetRandomProduct(Expression<Func<Product, object>> include = null)
        {
            var allProducts = await _table.AsNoTracking().Include(include).ToListAsync();
            Random random = new Random();
            int randomIndex = random.Next(0, allProducts.Count);
            var randomProduct = allProducts.ElementAt(randomIndex);
            return randomProduct;
        }
    }
}
