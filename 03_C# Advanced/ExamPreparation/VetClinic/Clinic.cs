using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            pets = new List<Pet>(Capacity);
        }

        public int Capacity { get; set; }

        public int Count
        {
            get { return pets.Count; }
        }

        public void Add(Pet pet)
        {
            if (pets.Count < pets.Capacity)
            {
                pets.Add(pet);
            }       
        }

        public bool Remove(string name)
        {
            bool isFound = false;

            foreach (Pet pet1 in pets)
            {
                if (pet1.Name == name)
                {
                    isFound = pets.Remove(pet1);
                    break;
                }
            }
            return isFound;
        }

        public Pet GetPet(string name, string owner)
        {
            return pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            return pets.OrderByDescending(x => x.Age).First();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");

            foreach (Pet pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
