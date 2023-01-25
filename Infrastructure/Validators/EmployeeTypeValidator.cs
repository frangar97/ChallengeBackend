using Core.EmployeeType.DTO;
using FluentValidation;

namespace Infrastructure.Validators
{
    public class EmployeeTypeValidator:AbstractValidator<CreateEmployeeTypeDTO>
    {
        public EmployeeTypeValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.Salary)
                .NotEmpty();
        }
    }
}
