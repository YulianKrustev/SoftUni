using Microsoft.Data.SqlClient;

namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.;Database=master;Integrated Security=true;;TrustServerCertificate = True;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "CREATE DATABASE MinionDB";
                command.ExecuteNonQuery();
                command.CommandText = "Use MinionDB";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE Countries (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE Towns (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), CountryId INT NOT NULL REFERENCES Countries(Id))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE Minions (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), Age INT, TownId INT REFERENCES Towns(Id))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE EvilnessFactors (Id INT PRIMARY KEY, Name VARCHAR(10) UNIQUE NOT NULL)";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), EvilnessFactorId INT REFERENCES EvilnessFactors(Id))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE MinionsVillains(MinionId INT REFERENCES Minions(Id), VillainId INT REFERENCES Villains(Id), PRIMARY KEY(MinionId, VillainId))";
                command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO Countries VALUES ('Bulgaria'), ('United Kingdom'), ('United States of America'), ('France')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Towns (Name, CountryId) VALUES ('Sofia',1), ('Burgas',1), ('Varna', 1), ('London', 2),('Liverpool', 2),('Ocean City', 3),('Paris', 4)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Minions (Name, Age, TownId) VALUES ('bob',10,1),('kevin',12,2),('stuart',9,3), ('rob',22,3), ('michael',5,2),('pep',3,2)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO EvilnessFactors VALUES (1, 'Super Good'), (2, 'Good'), (3, 'Bad'), (4, 'Evil'), (5, 'Super Evil')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Gru', 2),('Victor', 4),('Simon Cat', 3),('Pusheen', 1),('Mammal', 5)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO MinionsVillains VALUES (1, 2), (3, 1), (1, 3), (3, 3), (4, 1), (2, 2), (1, 1), (3, 4), (1, 4), (1, 5), (5, 1)";
                command.ExecuteNonQuery();

            }
        }
    }
}