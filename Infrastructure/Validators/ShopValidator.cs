using Core.Shop.DTO;
using FluentValidation;

namespace Infrastructure.Validators
{
    public class ShopValidator:AbstractValidator<CreateShopDTO>
    {
        public ShopValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.Address)
                .NotEmpty();

            RuleFor(x => x.Telephone)
                .NotEmpty();
        }
    }
}
