using MyApi.Domain.Entities;

namespace MyApi.Domain.Repositories;

public interface IPersonRepository
{
    Task<Person> GetByIdAsync(Guid id);
    Task<ICollection<Person>> GetAllAsync();
    Task<Person> CreateAsync(Person person);
    Task EditAsync(Person person);
    Task RemoveAsync(Person person);
}