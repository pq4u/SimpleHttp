namespace SimpleHttp.Models.ValueObjects;

public record HeaderName
{
    public string Value { get; }
   
    private HeaderName(string value) => Value = value;
   
    public static HeaderName Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Header name cannot be null or empty");
       
        if (value.Any(c => char.IsControl(c) || c == ':'))
            throw new ArgumentException("Invalid header name characters");
       
        return new HeaderName(value.Trim());
    }
}