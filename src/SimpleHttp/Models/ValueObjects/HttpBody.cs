using System.Text;

namespace SimpleHttp.Models.ValueObjects;

public record HttpBody
{
    public byte[] Content { get; }
    private HttpBody(byte[] value) => Content = value;
    public static HttpBody Empty => new(Array.Empty<byte>());
    public static HttpBody FromText(string text) => new(Encoding.UTF8.GetBytes(text));
    public string AsText() => Encoding.UTF8.GetString(Content);
    public int Length => Content.Length;
}