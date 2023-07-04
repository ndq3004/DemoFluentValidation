using FluentValidation;
using FluentValidation_demo.Models;
using FluentValidation_demo.Models.TH;

namespace FluentValidation_demo
{
    public class QuoteDefaultValidator : AbstractValidator<QuoteBase>, IQuoteValidator<QuoteBase>
    {
        public QuoteDefaultValidator() 
        {
            RuleFor(x => x.Value).NotEmpty().WithMessage("Value is not allowed null");
        }

        public bool Validate(QuoteBase quote)
        {
            return true;
        }
    }
}
