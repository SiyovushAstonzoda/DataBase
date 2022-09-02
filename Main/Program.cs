using Domain;

var oracle = new OracleConnection("Data Source=MyOracleDB;Integrated Security=yes;", TimeSpan.FromMinutes(2));

var sql = new SqlConnection("Driver={PostgreSQL};Server=IP address;Port=5432;Database=myDataBase;Uid=myUsername;Pwd=myPassword;", TimeSpan.FromSeconds(20));

var command = new DbCommand(oracle, "Select all from students. ");
command.Execute();
