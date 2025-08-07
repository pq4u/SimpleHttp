using System.Net;
using System.Net.Sockets;
using System.Text;
using SimpleHttp;
using SimpleHttp.Models.ValueObjects;

internal class Program
{
    static void Main()
    {
        var listener = new TcpListener(IPAddress.Any, 8080);

        listener.Start();
        Console.WriteLine("Listening on port 8080");

        while (true)
        {
            var client = listener.AcceptTcpClient();
            Console.WriteLine("Client connected");
            HandleClient(client);
        }
    }

    static void HandleClient(TcpClient client)
    {
        using (var stream = client.GetStream())
        using (var reader = new StreamReader(stream))
        using (var writer = new StreamWriter(stream))
        {
            var headerBuilder = new StringBuilder();
            
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                headerBuilder.AppendLine(line);
                if (string.IsNullOrEmpty(line)) break;
            }
            
            var headerText = headerBuilder.ToString();

            var contentLength = GetContentLength(headerText);

            var bodyBuffer = new char[contentLength];
            reader.Read(bodyBuffer, 0, contentLength);
            var bodyText = new string(bodyBuffer);

            var fullRequest = headerText + bodyText;
            
            try
            {
                var httpRequest = HttpRequestParser.Parse(fullRequest);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            writer.WriteLine("HTTP/1.1 200 OK");
            writer.WriteLine("Content-Type: text/plain");
            writer.WriteLine("");
            writer.WriteLine("Hello world");
            writer.Flush();
        }
    }
    
    static int GetContentLength(string headerText)
    {
        var lines = headerText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
   
        foreach (var line in lines.Skip(1))
        {
            var colonIndex = line.IndexOf(':');
            var headerName = line.Substring(0, colonIndex).Trim();
       
            if (string.Equals(headerName, "Content-Length", StringComparison.OrdinalIgnoreCase))
            {
                var headerValue = line.Substring(colonIndex + 1).Trim();
           
                if (int.TryParse(headerValue, out int length) && length >= 0)
                {
                    return length;
                }
            }
        }
   
        return 0;
    }
}
