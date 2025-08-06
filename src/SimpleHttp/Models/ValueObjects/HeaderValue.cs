namespace SimpleHttp.Models.ValueObjects;

public record HeaderValue
{
    public string Value { get; }
   
    private HeaderValue(string value) => Value = value;
   
    public static HeaderValue Create(string value)
    {
        if (value == null)
            throw new ArgumentException("Header value cannot be null");
       
        return new HeaderValue(value.Trim());
    }
}