using System;
using System.Text;
using Microsoft.Data.SqlClient;

namespace _06_RemoveVillain
{
    class Program
    {
        private const string connectionString = @"Server=.;Database=MinionDB;Integrated Security=true;TrustServerCertificate=true;";
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int villianId = int.Parse(Console.ReadLine());
                string result = RemoveVillainById(connection, villianId);

                Console.WriteLine(result);
            }
        }

        private static string RemoveVillainById(SqlConnection connection, int villianId)
        {
            StringBuilder sb = new StringBuilder();

            using SqlTransaction sqlTransaction = connection.BeginTransaction();

            string getVillainNameQuery = @"SELECT Name FROM Villains WHERE Id = @villainId";

            using SqlCommand getVillainNameCmd = new SqlCommand(getVillainNameQuery, connection);
            getVillainNameCmd.Parameters.AddWithValue("@villainId", villianId);
            getVillainNameCmd.Transaction = sqlTransaction;

            string villainName = getVillainNameCmd.ExecuteScalar()?.ToString();

            if (villainName == null)
            {
                sb.AppendLine($"No such villain was found.");
            }
            else
            {
                try
                {
                    string relaseMinionsQueryText = @"DELETE FROM MinionsVillains WHERE VillainId = @villainId";

                    using SqlCommand releaseMinionCmd = new SqlCommand(relaseMinionsQueryText, connection);
                    releaseMinionCmd.Parameters.AddWithValue("@villainId", villianId);
                    releaseMinionCmd.Transaction = sqlTransaction;
                    int releasedMinionsCount = releaseMinionCmd.ExecuteNonQuery();

                    string deleteVillainQueryText = @"DELETE FROM Villains WHERE Id = @villainId";

                    using SqlCommand delteVillainCmd = new SqlCommand(deleteVillainQueryText, connection);
                    delteVillainCmd.Parameters.AddWithValue("@villainId", villianId);
                    delteVillainCmd.Transaction = sqlTransaction;

                    delteVillainCmd.ExecuteNonQuery();

                    sqlTransaction.Commit();

                    sb.AppendLine($"{villainName} was deleted.").AppendLine($"{releasedMinionsCount} minions were released.");
                }
                catch (Exception ex)
                {
                    sb.AppendLine(ex.Message);

                    try
                    {
                        sqlTransaction.Rollback();
                    }
                    catch (Exception ex1)
                    {

                        sb.AppendLine(ex1.Message);
                    }
                }
            }

            return sb.ToString().Trim();
        }
    }
}
