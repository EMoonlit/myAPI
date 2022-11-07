using MyApi.Domain.Validations;

namespace MyApi.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string CodeErp { get; private set; }
    public decimal Price { get; private set; }
    public ICollection<Purchase> Purchases { get; set; }
    
    public Product(string name, string codeErp, decimal price)
    {
        Validation(name, codeErp, price);
        Id = Guid.NewGuid();
        Purchases = new List<Purchase>();
    }

    private void Validation(string name, string codeErp, decimal price)
    {
        DomainValidationsExceptions.When(string.IsNullOrEmpty(name), "Name is Required");
        DomainValidationsExceptions.When(string.IsNullOrEmpty(codeErp), "CodeErp is Required");
        DomainValidationsExceptions.When(price < 0, "Price is Required");

        Name = name;
        CodeErp = codeErp;
        Price = price;
    }
}