namespace FluentValidation_demo.Models.TH
{
    public class QuoteTH : QuoteBase
    {
        public ValueObject ValueObject { get; set; }
    }

    public class ValueObject
    {
        public string Value { get; set; }
    }
}
