namespace Cwiczenia3;

public class OverfillException : System.Exception
{
    public OverfillException() : base() { }

    public OverfillException(string message) : base(message)
    {
        Console.WriteLine(message);
    }
}