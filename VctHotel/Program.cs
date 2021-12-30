using System;

namespace VctHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quartosDisponiveis = 10;
            Rooms[] rooms = new Rooms[quartosDisponiveis];

            Console.Write("How many rooms will be rented? ");
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}");
                Console.Write("Your name: ");
                string name = Console.ReadLine();
                Console.Write("Your email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int r = int.Parse(Console.ReadLine());
                rooms[r] = new Rooms(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            for (int j = 0; j < quartosDisponiveis; j++)
            {
                if (rooms[j] != null)
                {
                    Console.WriteLine(j + ": " + rooms[j]);
                }
            }
        }
    }
}
