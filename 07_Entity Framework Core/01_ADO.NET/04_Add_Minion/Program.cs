using System;
using Microsoft.Data.SqlClient;

namespace _04_Add_Minion
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connection = @"Server=.;Database = MinionDB;Integrated Security = true;TrustServerCertificate = True;";
            string[] minionInfo = Console.ReadLine().Split();
            string[] villainInfo = Console.ReadLine().Split();

            string minionName = minionInfo[1];
            int minionAge = int.Parse(minionInfo[2]);
            string minionTown = minionInfo[3];

            string villainName = villainInfo[1];

            using (var sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                string commandForTown = @"SELECT * FROM Towns WHERE Name = @minionTown";
                var sqlCommand = new SqlCommand(commandForTown, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@minionTown", minionTown);

                var reader = sqlCommand.ExecuteReader();


                if (!reader.HasRows)
                {
                    sqlConnection.Close();
                    sqlConnection.Open();
                    string commandText = @"INSERT INTO Towns (Name, CountryId) VALUES (@minionTown, 1)";
                    sqlCommand.CommandText = commandText;
                    sqlCommand.ExecuteNonQuery();

                    Console.WriteLine($"Town {minionTown} was added to the database.");
                }

                sqlConnection.Close();
                sqlConnection.Open();
                sqlCommand.CommandText = @"SELECT Name FROM Villains WHERE Name = @villainName";
                sqlCommand.Parameters.AddWithValue("@villainName", villainName);
                reader = sqlCommand.ExecuteReader();


                if (!reader.HasRows)
                {
                    sqlConnection.Close();
                    sqlConnection.Open();
                    sqlCommand.CommandText = @"INSERT INTO Villains (Name, EvilnessFactorId) VALUES (@villainName, 1)";
                    sqlCommand.ExecuteNonQuery();

                    Console.WriteLine($"Villain {villainName} was added to the database.");
                }

                sqlConnection.Close();
                sqlConnection.Open();
                sqlCommand.CommandText = @"SELECT Name FROM Minions WHERE Name = @minionName";
                sqlCommand.Parameters.AddWithValue("@minionName", minionName);
                reader = sqlCommand.ExecuteReader(); 

                if (!reader.HasRows)
                {
                    sqlConnection.Close();
                    sqlConnection.Open();
                    sqlCommand.CommandText = @"INSERT INTO Minions (Name, Age, TownId) VALUES (@minionName, @minionAge, 1)";
                    sqlCommand.Parameters.AddWithValue("@minionAge", minionAge);
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.CommandText = @"INSERT INTO MinionsVillains
                                               VALUES(
                                                      (SELECT Id FROM Minions WHERE Name = @minionName), 
                                                      (SELECT Id FROM Villains WHERE Name = @villainName)
                                                      )";
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
                }
            }
        }
    }
}
