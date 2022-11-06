using FluentValidation;

namespace MyApi.Application.DTOs.Validations;

public class PersonDTOValidator : AbstractValidator<PersonDTO>
{
    public PersonDTOValidator()
    {
        RuleFor(x => x.Document)
            .NotEmpty()
            .NotNull()
            .WithMessage("Document is required!");

        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Name is required!");

        RuleFor(x => x.Phone)
            .NotEmpty()
            .NotNull()
            .WithMessage("Phone is required!");
    }
}