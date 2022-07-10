using System;
using System.Text;
using Microsoft.Data.SqlClient;

namespace _08_Increase_Minion_Age
{
    class Program
    {
        private const string connectionString = @"Server=.;Database=MinionDB;Integrated Security=true;TrustServerCertificate=true;";
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string[] minionsId = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                StringBuilder sb = new StringBuilder();

                string updateAgesQuery = $@"UPDATE Minions SET Age += 1,  Name = UPPER(LEFT(Name, 1)) + LOWER(RIGHT(Name, LEN(Name)-1)) WHERE Id IN ({string.Join(", ", minionsId)})";
                SqlCommand command = new SqlCommand(updateAgesQuery, connection);
                command.ExecuteNonQuery();
                
                string takeNameAndAgeQuery = $@"SELECT Name, Age FROM Minions WHERE Id IN ({string.Join(", ", minionsId)})";
                SqlCommand takeChangedNameAndAge = new SqlCommand(takeNameAndAgeQuery, connection);
                               
                SqlDataReader reader = takeChangedNameAndAge.ExecuteReader();

                while (reader.Read())
                {
                    sb.AppendLine(($"{(string)reader["Name"]} {((int)reader["Age"]).ToString()}"));
                }
                
                Console.WriteLine(sb);
            }
        }
    }
}
