using FluentValidation_demo.Models;

namespace FluentValidation_demo
{
    public interface IQuoteValidator<T> where T : QuoteBase
    {
        bool Validate(T quote);
    }
}
