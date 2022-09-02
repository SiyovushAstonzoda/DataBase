namespace Domain;

public class DbCommand
{
    //instruction - command
    DbConnection _connection;
    private string? _command;
    public DbCommand(DbConnection dbConnection, string? instruction)
    {   
        _connection = dbConnection;
        _command = instruction;
    }

    public void Execute()
    {
        _connection.Open();
        Console.WriteLine("Executing command: " + _command);
        _connection.Closed();
    }
}
