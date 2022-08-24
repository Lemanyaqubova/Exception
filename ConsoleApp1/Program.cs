using ConsoleApp1.Utilies;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("n3", 4, 2);
            Hotel hotel1 = new Hotel("Hilton", 8);

            Console.WriteLine(room1.ToString());
           
        }
    }
}
