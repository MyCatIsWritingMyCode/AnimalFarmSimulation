using Microsoft.Data.Sqlite;
using Refresh1_24.Model;

List<Cat> cars = new List<Cat>();
cars.Add(new Cat("Cake", new DateTime(2022, 5, 1)));

Console.WriteLine(cars[0].Name);
var dbConnection = new SqliteConnection("Data Source=../../../databases/database_farm.db");
dbConnection.Open();
var command = dbConnection.CreateCommand();
command.CommandText =
@"
    CREATE TABLE test_a(
    id INTEGER,
    name TEXT,
    PRIMARY KEY(id)
    );
";
var result = command.ExecuteScalar();

