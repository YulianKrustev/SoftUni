using System;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace _09_Increase_Age_Stored_Procedure
{
    class Program
    {
        private const string connectionString = @"Server=.;Database=MinionDB;Integrated Security=true;TrustServerCertificate=true;";
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int minionId = int.Parse(Console.ReadLine());

                string result = IncreaseMinionAgeById(connection, minionId);

                Console.WriteLine(result);
            }
        }

        private static string IncreaseMinionAgeById(SqlConnection connection, int minionId)
        {
            StringBuilder sb = new StringBuilder();
            string procName = "usp_GetOlder";
            SqlCommand increaseAgeCmd = new SqlCommand(procName, connection);
            increaseAgeCmd.CommandType = CommandType.StoredProcedure;
            increaseAgeCmd.Parameters.AddWithValue("@minionId", minionId);

            increaseAgeCmd.ExecuteNonQuery();

            string getMinionInfoQuery = @"SELECT Name, Age FROM Minions WHERE Id = @minionId";
            SqlCommand getMinionInfoCmd = new SqlCommand(getMinionInfoQuery, connection);
            getMinionInfoCmd.Parameters.AddWithValue("@minionId", minionId);

            SqlDataReader reader = getMinionInfoCmd.ExecuteReader();

            reader.Read();
            string minionName = reader["Name"]?.ToString();
            string minionAge = reader["Age"]?.ToString();

            sb.AppendLine($"{minionName} - {minionAge} years old.");
            return sb.ToString().TrimEnd();
        }
    }
}
