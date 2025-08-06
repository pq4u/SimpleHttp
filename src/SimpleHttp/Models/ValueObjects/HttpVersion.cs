namespace SimpleHttp.Models.ValueObjects;

public record HttpVersion
{
    public int Major { get; }
    public int Minor { get; }
   
    private HttpVersion(int major, int minor)
    {
        Major = major;
        Minor = minor;
    }
   
    public static HttpVersion Create(int major, int minor)
    {
        if (major < 0 || minor < 0)
            throw new ArgumentException("Version numbers must be non-negative");
       
        if (major > 2 || (major == 1 && minor > 1))
            throw new ArgumentException("Unsupported http version");
       
        return new (major, minor);
    }
   
    public override string ToString() => $"HTTP/{Major}.{Minor}";
}