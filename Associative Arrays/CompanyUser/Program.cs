using System;
using System.Collections.Generic;

namespace CompanyUser
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, List<string>> companyList = new SortedDictionary<string, List<string>>();

            while (input != "End")
            {
                string[] data = input.Split(" -> ");
                string company = data[0];
                string id = data[1];

                if (companyList.ContainsKey(company) == false)
                {
                    companyList.Add(company, new List<string>());
                }

                if (!companyList[company].Contains(id))
                {
                    companyList[company].Add(id);
                }
                
                input = Console.ReadLine();
            }

            foreach (var company in companyList)
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
