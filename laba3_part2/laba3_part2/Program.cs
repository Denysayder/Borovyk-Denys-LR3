// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
namespace laba3_part2
{

    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("На яку суму заповнити кімнату?");
            int TotalPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть вік дитини");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Room room = new Room();
            foreach (var n in room.FillRoom(TotalPrice, Age))
                Console.WriteLine(n);

            Console.WriteLine("Для сортування іграшок за ціною натисніть 'Enter'");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {   Console.WriteLine();
                room.SortByPrice(room.FillRoom(TotalPrice, Age));
            }

            Console.WriteLine("Щоб знайти в кімнаті іграшку, введіть її ціну");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Тепер її властивість");
            string Property = Console.ReadLine();
            room.FindToyInRoom(Price, Property, room.FillRoom(TotalPrice, Age));
        }
    }
}
