using System;
using Microsoft.Data.SqlClient;

namespace _02_Villain_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.;Database=MinionDB;Integrated Security=true;;TrustServerCertificate = True;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT CONCAT(v.Name, ' - ', COUNT(mv.MinionId)) AS Output FROM Villains v " +
                                      "JOIN MinionsVillains mv ON v.Id = mv.VillainId " +
                                      "GROUP BY v.Name " +
                                      "HAVING COUNT(mv.MinionId) > 3 " +
                                      "ORDER BY COUNT(mv.MinionId) DESC";
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                }
            }
        }
    }
}