using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int studentTicket = 0;
            int kidTicket = 0;
            int standardTicket = 0;
            double alltickets = 0;
      
            while (movie != "Finish")
            {
                int capacity = int.Parse(Console.ReadLine());
                string ticketType = "";
                double ticketCounter = 0;
                while (ticketCounter < capacity)
                {
                    ticketType = Console.ReadLine();
                    if (ticketType == "kid")
                    {
                        kidTicket++;
                    } 
                    else if (ticketType == "student")
                    {
                        studentTicket++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicket++;
                    }
                    else if (ticketType == "End")
                    {
                        break;
                    }
                    ticketCounter++;
                    alltickets++;
                }
                Console.WriteLine($"{movie} - {(ticketCounter / capacity) * 100:f2}% full.");

                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {alltickets}");
            Console.WriteLine($"{1.00 *(studentTicket / alltickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{1.00 *(standardTicket / alltickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{1.00 *(kidTicket / alltickets) * 100:f2}% kids tickets.");
        }
    }
}
