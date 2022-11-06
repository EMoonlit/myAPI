using MyApi.Domain.Validations;

namespace MyApi.Domain.Entities;

public class Product
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public string CodeErp { get; private set; }
    public decimal Price { get; private set; }
    public ICollection<Purchase> Purchases { get; set; }
    
    public Product(string name, string codeErp, decimal price)
    {
        Validation(name, codeErp, price);
        Purchases = new List<Purchase>();
    }

    public Product(string id, string name, string codeErp, decimal price)
    {
        DomainValidationsExceptions.When(string.IsNullOrEmpty(id), "Id is Required");
        Validation(name, codeErp, price);
        Id = id;
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