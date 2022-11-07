using MyApi.Domain.Validations;

namespace MyApi.Domain.Entities;

public class Purchase
{
    public Guid Id { get; private set; }
    public Guid ProductId { get; private set; }
    public Guid PersonId { get; private set; }
    public DateTime Date { get; private set; }
    public Person Person { get; set; }
    public Product Product { get; set; }
    
    
    public Purchase(Guid productId, Guid personId)
    {
        Validation( productId, personId);
        Id = Guid.NewGuid();
    }

    private void Validation(Guid productId, Guid personId)
    {
        ProductId = productId;
        PersonId = personId;
        Date = DateTime.Now;
    }
}