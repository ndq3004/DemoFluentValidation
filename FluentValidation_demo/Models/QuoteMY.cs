namespace FluentValidation_demo.Models.MY
{
    public class QuoteMY : QuoteBase
    {
        public ValueObject ValueObject { get; set; }
    }

    public class ValueObject
    {
        public string Value { get; set; }
    }
}
