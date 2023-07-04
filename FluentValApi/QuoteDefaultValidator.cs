using FluentValidation;
using FluentValApi.Models.MY;
using FluentValApi.Models;
using FluentValidation.Results;

namespace FluentValApi
{
    public class QuoteDefaultValidator : IQuoteValidator
    {
        public ValidationResult Validate(QuoteBase quote)
        {
            QuoteDefaultFluentValidator validator = new QuoteDefaultFluentValidator();
            var myQuote = new QuoteMY();
            return validator.Validate(myQuote);
        }
    }

    public class QuoteDefaultFluentValidator : AbstractValidator<QuoteBase>
    {
        public QuoteDefaultFluentValidator()
        {
            RuleFor(x => x.Value).NotEmpty().WithMessage("Hello");
        }
    }
}
