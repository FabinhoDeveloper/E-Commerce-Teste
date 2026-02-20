using e_commerce_api.Source.Interface;
using e_commerce_api.Source.Models;

namespace e_commerce_api.Source.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public Task<User> AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, User entity)
        {
            throw new NotImplementedException();
        }
    }
}