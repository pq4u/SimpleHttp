namespace SimpleHttp.Models.ValueObjects;

public record HttpPath
{
    public string Value { get; }
    
    private HttpPath(string value) => Value = value;
    
    public static HttpPath Create(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Http path cannot be null or empty");
        
        if (!value.StartsWith('/'))
            throw new ArgumentException("Http path must start with '/'");
        
        if (value.Length > 2048)
            throw new ArgumentException("Http path too long");
        
        return new(value);
    }
}