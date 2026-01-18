using PAC.Back_end.Domain.Entities;

namespace PAC.Back_end.Application.Interfaces.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task<Product?> AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(int id);
}
