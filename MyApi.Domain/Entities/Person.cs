using MyApi.Domain.Validations;

namespace MyApi.Domain.Entities;

public sealed class Person
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public string Document { get; private set; }
    public string Phone { get; private set; }
    public ICollection<Purchase> Purchases { get; set; }
    
    
    public Person(string name, string document, string phone)
    {
        Validation(name, document, phone);
        Purchases = new List<Purchase>();
    }

    public Person(string id, string name, string document, string phone)
    {
        DomainValidationsExceptions.When(string.IsNullOrEmpty(id), "Id is Required");
        Validation(name, document, phone);
        Id = id;
        Purchases = new List<Purchase>();
    }

    private void Validation(string name, string document, string phone)
    {
        DomainValidationsExceptions.When(string.IsNullOrEmpty(name), "Name is Required");
        DomainValidationsExceptions.When(string.IsNullOrEmpty(document), "Document is Required");
        DomainValidationsExceptions.When(string.IsNullOrEmpty(phone), "Phone is Required");

        Name = name;
        Document = document;
        Phone = phone;
    }
}