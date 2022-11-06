using AutoMapper;
using MyApi.Application.DTOs;
using MyApi.Domain.Entities;

namespace MyApi.Application.Mappings;

public class DtoToDomainMapping : Profile
{
    public DtoToDomainMapping()
    {
        CreateMap<PersonDTO, Person>();
    }
}