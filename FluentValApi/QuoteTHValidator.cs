using FluentValidation;
using FluentValApi.Models.TH;
using FluentValApi.Models;
using FluentValidation.Results;

namespace FluentValApi
{
    public class QuoteTHValidator : IQuoteValidator
    {
        public ValidationResult Validate(QuoteBase quote)
        {
            QuoteTHFluentValidator validator = new QuoteTHFluentValidator();
            var thQuote = new QuoteTH(); //TODO: convert QuoteBase to QuoteTH
            return validator.Validate(thQuote);
        }
    }

    public class QuoteTHFluentValidator : AbstractValidator<QuoteTH>
    {
        public QuoteTHFluentValidator()
        {
            RuleFor(x => x.ValueObject.Value).NotEmpty().WithMessage("Hello");
        }
    }
}
