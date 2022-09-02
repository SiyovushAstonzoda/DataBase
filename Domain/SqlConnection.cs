namespace Domain;

public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString, TimeSpan timeout)
        : base(connectionString, timeout)
    {
    }
    public override void Open()
    {
      Console.WriteLine("Opening connection to SQL Server...");
    }
    public override void Closed()
    {
        System.Console.WriteLine("Closing connection to SQL Server...");
    }
}
