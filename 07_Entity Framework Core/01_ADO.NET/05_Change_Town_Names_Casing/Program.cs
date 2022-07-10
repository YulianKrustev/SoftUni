using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace _05_Change_Town_Names_Casing
{
    class Program
    {
        private const string connectionString = @"Server=.;Database=MinionDB;Integrated Security=true;TrustServerCertificate=true;";

        static void Main(string[] args)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string countryNameInput = Console.ReadLine();
                string ensureTownExist = @"SELECT Name FROM Countries WHERE Name = @countryName";
                SqlCommand ensureTownExistCommand = new SqlCommand(ensureTownExist, sqlConnection);
                ensureTownExistCommand.Parameters.AddWithValue("@countryName", countryNameInput);
                string countryName = (string)ensureTownExistCommand.ExecuteScalar();
                StringBuilder sb = new StringBuilder();

                if (countryName == null)
                {
                    sb.AppendLine("No town names were affected");
                }
                else
                {
                    string changeCasingForTownsString = @$"UPDATE Towns SET Name = UPPER(Name) WHERE CountryId = (SELECT Id FROM Countries WHERE Name = @countryName)";
                    SqlCommand changeCasingForTownsCommand = new SqlCommand(changeCasingForTownsString, sqlConnection);
                    changeCasingForTownsCommand.Parameters.AddWithValue("@countryName", countryName);
                    string result = changeCasingForTownsCommand.ExecuteNonQuery().ToString();
                    sb.AppendLine($"{result} town names were affected.");

                    string takingChangedTownsString = @"SELECT Name FROM Towns WHERE CountryId = (SELECT Id FROM Countries WHERE Name = @countryName)";
                    SqlCommand takingChangedTownsCommand = new SqlCommand(takingChangedTownsString, sqlConnection);
                    takingChangedTownsCommand.Parameters.AddWithValue("@countryName", countryName);
                    SqlDataReader reader = takingChangedTownsCommand.ExecuteReader();

                    List<string> changedTowns = new List<string>();

                    while (reader.Read())
                    {
                        changedTowns.Add((string)reader[0]);
                    }

                    sb.AppendLine($"[{String.Join(", ", changedTowns)}]");
                }

                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}
