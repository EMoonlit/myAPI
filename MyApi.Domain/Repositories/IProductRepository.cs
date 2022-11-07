using MyApi.Domain.Entities;

namespace MyApi.Domain.Repositories;

public interface IProductRepository
{
    Task<Product> GetByIdAsync(Guid id);
    Task<ICollection<Product>> GetAllAsync();
    Task<Product> CreateAsync(Product product);
    Task EditAsync(Product product);
    Task RemoveAsync(Product product);

}