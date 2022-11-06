using AutoMapper;
using MyApi.Application.DTOs;
using MyApi.Domain.Entities;

namespace MyApi.Application.Mappings;

public class DomainToDtoMapping : Profile
{
    public DomainToDtoMapping()
    {
        CreateMap<Person, PersonDTO>();
    }
}