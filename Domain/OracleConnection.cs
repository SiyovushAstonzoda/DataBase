namespace Domain;

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString,TimeSpan timout)
        : base(connectionString, timout)
    {
    }

    public override void Open()
    {
        Console.WriteLine("Opening connection to Oracle...");
        Console.WriteLine($"Oracle has no timeout");
    }

    public override void Closed()
    {
        Console.WriteLine("Closing connection to Oracle...");
    }
}