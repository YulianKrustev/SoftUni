using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.None);
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                    trainers[trainerName].Pokemons.Add(pokemon);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(pokemon);
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.None);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (Trainer trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(x => x.Element == command))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;

                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
