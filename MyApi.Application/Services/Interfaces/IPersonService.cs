using MyApi.Application.DTOs;

namespace MyApi.Application.Services.Interfaces;

public interface IPersonService
{
    Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDto);
}