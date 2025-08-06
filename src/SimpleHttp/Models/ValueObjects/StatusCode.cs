namespace SimpleHttp.Models.ValueObjects;

public record StatusCode
{
    public int Value { get; }
    public string ReasonPhrase { get; }
   
    private StatusCode(int value, string reasonPhrase)
    {
        Value = value;
        ReasonPhrase = reasonPhrase;
    }

    public static StatusCode Create(int value, string reasonPhrase)
    {
        if (value < 100 || value > 599)
            throw new ArgumentException("Status code must be integer between 100-599");

        if (string.IsNullOrWhiteSpace(reasonPhrase))
            throw new ArgumentException("Reason phrase cannot be null or empty");

        return new StatusCode(value, reasonPhrase);
    }
}