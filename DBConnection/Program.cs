// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

string connectionString = "Server=localhost;Database=DotNetDB;TrustServerCertificate=true;Trusted_Connection=true;";

IDbConnection dbConnection = new SqlConnection(connectionString); 

string sqlCommand = "SELECT GETDATE()";

DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);

Console.WriteLine(rightNow);