namespace MyApi.Domain.Validations;

public class DomainValidationsExceptions : Exception
{
    public DomainValidationsExceptions(string error) : base(error)
    {
        
    }

    public static void When(bool hasError, string message)
    {
        if (hasError)
            throw new DomainValidationsExceptions(message);
    }
}