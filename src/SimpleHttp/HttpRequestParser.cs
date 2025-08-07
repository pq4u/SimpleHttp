using System.Net.Http.Headers;
using SimpleHttp.Models;
using SimpleHttp.Models.ValueObjects;
using HttpMethod = SimpleHttp.Models.ValueObjects.HttpMethod;

namespace SimpleHttp;

public class HttpRequestParser
{
    public static HttpRequest Parse(string rawRequest)
    {
        var lines = rawRequest.Split(new string[] { "\r\n" }, StringSplitOptions.None);
        
        var requestLine = ParseRequestLine(lines[0]);
        var headers = ParseHeaders(lines, out int bodyStartIndex);
        return new HttpRequest();
    }


    private static (HttpMethod Method, HttpPath Path, HttpVersion Version) ParseRequestLine(string line)
    {
        var parts = line.Split(' ');
        if (parts.Length != 3)
            throw new ArgumentException("Invalid request line format");
        
        var method = HttpMethod.Create(parts[0]);
        var path = HttpPath.Create(parts[1]);
        var parsedVersion = ParseVersion(parts[2]);
        var version = HttpVersion.Create(parsedVersion.Major, parsedVersion.Minor);
        
        return (method, path, version);
    }
    
    private static Dictionary<HeaderName, HeaderValue> ParseHeaders(string[] lines, out int bodyStartIndex)
    {
        var headers = new Dictionary<HeaderName, HeaderValue>();
        bodyStartIndex = -1;

        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrEmpty(lines[i]))
            {
                bodyStartIndex = i + 1;
                break;
            }
            
            var name = lines[i].Split(new string[] { ": " }, StringSplitOptions.None)[0];
            var value = lines[i].Substring(name.Length + 2);
            
            headers.Add(HeaderName.Create(name), HeaderValue.Create(value));
        }

        return headers;
    }

    private static (int Major, int Minor) ParseVersion(string version)
    {
        if (version.Substring(0, 5) != "HTTP/")
            throw new ArgumentException("Invalid version");
        
        var rawVersion = version.Substring(5);
        var splittedVersion = rawVersion.Split('.');
        var major =  int.Parse(splittedVersion[0]);
        var minor =  int.Parse(splittedVersion[1]);
        return (major, minor);
    }
}