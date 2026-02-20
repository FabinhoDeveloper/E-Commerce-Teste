using e_commerce_api.Source.Database;
using e_commerce_api.Source.Interface;
using e_commerce_api.Source.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_api.Source.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Order> AddAsync(Order entity)
        {
            await _context.Orders.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            return order ?? throw new KeyNotFoundException("Order not found");
        }

        public async Task<List<Order>> GetAsync()
        {
            return await _context.Orders
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task Update(int id, Order entity)
        {
            var order = await _context.Orders.FindAsync(id)
                ?? throw new KeyNotFoundException("Order not found");

            _context.Entry(order).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Order entity)
        {
            _context.Orders.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}