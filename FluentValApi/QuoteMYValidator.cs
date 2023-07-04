using FluentValidation;
using FluentValApi.Models.MY;
using FluentValApi.Models;
using FluentValidation.Results;

namespace FluentValApi
{
    public class QuoteMYValidator : IQuoteValidator
    {
        public ValidationResult Validate(QuoteBase quote)
        {
            QuoteMYFluentValidator validator = new QuoteMYFluentValidator();
            var myQuote = new QuoteMY(); //TODO: convert QuoteBase to QuoteMY
            return validator.Validate(myQuote);
        }
    }

    public class QuoteMYFluentValidator : AbstractValidator<QuoteMY>
    {
        public QuoteMYFluentValidator()
        {
            RuleFor(x => x.ValueObject.Value).NotEmpty().WithMessage("Hello");
        }
    }
}
