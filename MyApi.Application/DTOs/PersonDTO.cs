namespace MyApi.Application.DTOs;

public class PersonDTO
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public string Document { get; set; }
    public string Phone { get; set; }
}