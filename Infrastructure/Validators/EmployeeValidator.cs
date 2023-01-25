using Core.Employee.DTO;
using FluentValidation;

namespace Infrastructure.Validators
{
    public class EmployeeValidator:AbstractValidator<CreateEmployeeDTO>
    {
        public EmployeeValidator()
        {
            RuleFor(x=>x.Name)
                .NotEmpty();

            RuleFor(x => x.EmployeeTypeId)
                .NotNull()
                .GreaterThan(0)
                .WithMessage("The value must be greater than 0");

            RuleFor(x => x.Telephone)
                .NotEmpty();

            RuleFor(x => x.Address)
                .NotEmpty();

            RuleFor(x => x.EmploymentDate)
                .NotEmpty();
        }
    }
}
