using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<CompanyRoster> companyRoster = new List<CompanyRoster>();
            List<string> departments = new List<string>();
            List<decimal> averageSaleryDep = new List<decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                CompanyRoster employee = new CompanyRoster(data[0], decimal.Parse(data[1]), data[2]);
                companyRoster.Add(employee);

                if (!departments.Contains(employee.Department))
                {
                    departments.Add(employee.Department);
                }
            }

            foreach (string department in departments)
            {
                int countEmployees = 0;
                decimal averageSalery = 0;
                foreach (CompanyRoster employee in companyRoster)
                {
                    if (employee.Department.Contains(department))
                    {
                        countEmployees++;
                        averageSalery += employee.Salery;
                    }
                }
                averageSaleryDep.Add(averageSalery / countEmployees);
            }

            int maxAvaregeSalery = averageSaleryDep.IndexOf(averageSaleryDep.Max());
            List<CompanyRoster> final = companyRoster.Where(x => x.Department == departments[maxAvaregeSalery])
                                                     .OrderByDescending(x=> x.Salery)
                                                     .ToList();

            Console.WriteLine($"Highest Average Salary: {departments[maxAvaregeSalery]}");
            for (int i = 0; i < final.Count; i++)
            {
                Console.WriteLine($"{final[i].Name} {final[i].Salery:f2}");
            }
        }
    }

    class CompanyRoster
    {

        public CompanyRoster(string name, decimal salery, string department)
        {
            Name = name;
            Salery = salery;
            Department = department;
        }
        public string Name { get; set; }
        public decimal Salery { get; set; }
        public string Department { get; set; }
    }
}
