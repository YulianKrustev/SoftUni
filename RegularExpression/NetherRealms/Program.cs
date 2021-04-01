using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        class Daemon
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public double Damage { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Health} health, {Damage:f2} damage";
            }
        }
        static void Main(string[] args)
        {
            string[] deamonNames = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            List<Daemon> daemonsList = new List<Daemon>();

            for (int i = 0; i < deamonNames.Length; i++)
            {
                Daemon daemon = new Daemon();
                daemon.Name = deamonNames[i];
                Regex health = new Regex(@"[^0-9+\-*\/.]");
                int deamonHealth = 0;
                MatchCollection deamonsHealth = health.Matches(deamonNames[i]);

                foreach (Match item in deamonsHealth)
                {
                    deamonHealth += char.Parse(item.Value);
                }

                daemon.Health = deamonHealth;

                Regex damage = new Regex(@"[+-]?[\d]+\.?[\d]*");
                MatchCollection daemonDamage = damage.Matches(deamonNames[i]);
                double daemonD = 0;

                foreach (Match item in daemonDamage)
                {
                    daemonD += double.Parse(item.Value);
                }

                foreach (var item in deamonNames[i])
                {
                    if (item == '*')
                    {
                        daemonD *= 2;
                    }
                    else if (item == '/')
                    {
                        daemonD /= 2;
                    }
                }
                daemon.Damage = daemonD;
                daemonsList.Add(daemon);

            }

            daemonsList = daemonsList.OrderBy(x => x.Name).ToList();

            foreach (var deamon in daemonsList)
            {
                Console.WriteLine(deamon);
            }
        }
    }
}
