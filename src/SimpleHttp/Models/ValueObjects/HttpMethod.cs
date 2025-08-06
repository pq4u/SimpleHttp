namespace SimpleHttp.Models.ValueObjects;

public record HttpMethod
{
    public string Value { get; }
    
    private HttpMethod(string value) => Value = value;
    
    public static HttpMethod Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Http method cannot be null or empty");
        
        var upperValue = value.ToUpperInvariant();
        if (!IsValidMethod(upperValue))
            throw new ArgumentException($"Invalid http method: {value}");
        
        return new(upperValue);
    }
    
    private static bool IsValidMethod(string method) =>
        method is "GET" or "POST" or "PUT" or "DELETE" or "PATCH" or "HEAD" or "OPTIONS";
}