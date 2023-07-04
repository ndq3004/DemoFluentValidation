using FluentValidation;
using FluentValidation_demo.Models.TH;

namespace FluentValidation_demo
{
    public class QuoteTHValidator : AbstractValidator<QuoteTH>, IQuoteValidator<QuoteTH>
    {
        public QuoteTHValidator() 
        {
            RuleFor(x => x.ValueObject.Value).NotEmpty().WithMessage("Value is not allowed null");
        }

        public bool Validate(QuoteTH quote)
        {
            return true;
        }
    }
}
