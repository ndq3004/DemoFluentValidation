using FluentValidation;
using FluentValidation_demo.Models;
using FluentValidation_demo.Models.MY;

namespace FluentValidation_demo
{
    public class QuoteMYValidator : AbstractValidator<QuoteMY>, IQuoteValidator<QuoteMY>
    {
        public QuoteMYValidator() 
        {
            RuleFor(x => x.ValueObject.Value).NotEmpty().WithMessage("Value is not allowed null");
        }

        public bool Validate(QuoteMY quote)
        {
            return true;
        }
    }
}
