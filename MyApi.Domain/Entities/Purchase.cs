using MyApi.Domain.Validations;

namespace MyApi.Domain.Entities;

public class Purchase
{
    public string Id { get; private set; }
    public string ProductId { get; private set; }
    public string PersonId { get; private set; }
    public DateTime Date { get; private set; }
    public Person Person { get; set; }
    public Product Product { get; set; }
    
    public Purchase(string productId, string personId)
    {
        Validation( productId, personId);
    }
    
    public Purchase(string id, string productId, string personId)
    {
        DomainValidationsExceptions.When(string.IsNullOrEmpty(id), "Id is Required");
        Validation( productId, personId);
        Id = id;
    }

    private void Validation(string productId, string personId)
    {
        DomainValidationsExceptions.When(string.IsNullOrEmpty(productId), "ProductId is Required");
        DomainValidationsExceptions.When(string.IsNullOrEmpty(personId), "PersonId is Required");


        ProductId = productId;
        PersonId = personId;
        Date = DateTime.Now;
    }
}