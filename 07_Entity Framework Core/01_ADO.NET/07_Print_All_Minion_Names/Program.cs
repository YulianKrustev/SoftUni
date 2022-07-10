using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace _07_Print_All_Minion_Names
{
    class Program
    {
        private const string connectionString = @"Server=.;Database=MinionDB;Integrated Security=true;TrustServerCertificate=true;";
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string takeAllMinionNamesQuery = @"SELECT Name FROM Minions";
                SqlCommand takeAllMinionNamesCmd = new SqlCommand(takeAllMinionNamesQuery, connection);
                SqlDataReader reader = takeAllMinionNamesCmd.ExecuteReader();
                List<string> minionNames = new List<string>();

                while (reader.Read())
                {
                    minionNames.Add((string)reader[0]);
                }

                int n = minionNames.Count - 1;

                for (int i = 0; i < minionNames.Count; i++)
                {
                    Console.WriteLine(minionNames[i]);

                    if (n == i)
                    {
                        break;
                    }

                    Console.WriteLine(minionNames[n--]);

                    if (n == i)
                    {
                        break;
                    }

                }
            }
        }
    }
}
