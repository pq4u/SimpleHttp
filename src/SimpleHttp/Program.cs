using System.Net;
using System.Net.Sockets;

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
            var request = reader.ReadLine();
            Console.WriteLine($"Response: {request}");
            
            writer.WriteLine("HTTP/1.1 200 OK");
            writer.WriteLine("Content-Type: text/plain");
            writer.WriteLine("");
            writer.WriteLine("Hello world");
            writer.Flush();
        }
    }
}
