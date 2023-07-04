using FluentValApi.Models;
using FluentValidation.Results;

namespace FluentValApi
{
    public interface IQuoteValidator
    {
        ValidationResult Validate(QuoteBase quote);
    }
}
