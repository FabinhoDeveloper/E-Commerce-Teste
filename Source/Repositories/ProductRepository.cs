using e_commerce_api.Source.Interface;
using e_commerce_api.Source.Models;

namespace e_commerce_api.Source.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public Task<Product> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Product entity)
        {
            throw new NotImplementedException();
        }
    }
}