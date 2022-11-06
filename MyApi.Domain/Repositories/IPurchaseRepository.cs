using MyApi.Domain.Entities;

namespace MyApi.Domain.Repositories;

public interface IPurchaseRepository
{
    Task<Purchase> GetByIdAsync(string id);
    Task<ICollection<Purchase>> GetAllAsync();
    Task<Purchase> CreateAsync(Purchase purchase);
    Task EditAsync(Purchase purchase);
    Task RemoveAsync(Purchase purchase);

    
}