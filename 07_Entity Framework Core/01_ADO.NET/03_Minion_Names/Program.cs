using System;
using System.Text;
using Microsoft.Data.SqlClient;

namespace _03_Minion_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string connect = @"Server=.;Database=MinionDB;Integrated Security=true;;TrustServerCertificate = True;";
            string villainId = Console.ReadLine();

            using (var sqlConnection = new SqlConnection(connect))
            {
                sqlConnection.Open();

                string commandExtractName = @"SELECT Name FROM Villains
                                          WHERE Id = @VillainId";

                var commandName = new SqlCommand(commandExtractName, sqlConnection);
                commandName.Parameters.AddWithValue("@VillainId", villainId);

                string villainName = (string)commandName.ExecuteScalar();

                StringBuilder sb = new StringBuilder();
                int counter = 0;

                string commandString = @"SELECT v.Name, m.Name, m.Age FROM MinionsVillains mv
                                         JOIN Minions m ON mv.MinionId = m.Id
                                         JOIN Villains v ON mv.VillainId = v.Id
                                         WHERE VillainId = @VillainId
                                         ORDER BY m.Name";

                SqlCommand command = new SqlCommand(commandString, sqlConnection);
                command.Parameters.AddWithValue("@VillainId", villainId);

                var reader = command.ExecuteReader();

                if (villainName == null)
                {
                    sb.AppendLine($"No villain with ID {villainId} exist in the database.");
                }
                else if (!reader.HasRows)
                {
                    sb.AppendLine($"Villain: {villainName}");
                    sb.AppendLine("no minions");
                }
                else
                {
                    while (reader.Read())
                    {
                        if (counter == 0)
                        {
                            sb.AppendLine($"Villain: {(string)reader[0]}");
                        }

                        counter++;
                        sb.AppendLine($"{counter}. {reader[1]} {reader[2]}");
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
