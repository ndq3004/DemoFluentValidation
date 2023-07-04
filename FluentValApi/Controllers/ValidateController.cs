using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FluentValApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValidateController : ControllerBase
    {
        private readonly Func<string, IQuoteValidator> _quoteValidator;
        public ValidateController(Func<string, IQuoteValidator> quoteValidator)
        {
            _quoteValidator = quoteValidator;
        }

        [HttpGet(Name = "validate")]
        public ValidationResult Get()
        {
            return _quoteValidator("MY").Validate(new Models.QuoteBase());
        }
    }
}