using SimpleHttp.Models.ValueObjects;
using HttpMethod = SimpleHttp.Models.ValueObjects.HttpMethod;

namespace SimpleHttp.Models;

public class HttpRequest
{
    public HttpMethod Method { get; set; }
    public HttpPath Path { get; set; }
    public HttpVersion Version { get; set; }
    public Dictionary<HeaderName, HeaderValue> Headers { get; set; } = new();
    public HttpBody Body { get; set; }
}