// See https://aka.ms/new-console-template for more information
using System;

namespace laba3_try
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] Models = {"BMW","Mercedes", "Tesla", "Banderomobil`", "Volkswagen", "ZAZ"};
            Console.WriteLine("Оберіть марку автомобіля");
            foreach (var n in Models)
                Console.WriteLine(n);
            string Model = Console.ReadLine();
            wheel wheel = new wheel(15);
            Engine engine = new Engine(400);
            Car car = new Car(Model, wheel,engine);
            Console.Clear();
            Console.WriteLine(car);

            //демонстрація роботи перевизначених методів GetHashCode Equals ToString

            //Engine engine_1 = new Engine(100);
            //Engine engine1 = new Engine(100);
            //Console.WriteLine(engine1.Equals(engine_1));
            //Console.WriteLine(engine);
            //Console.WriteLine(engine1.GetHashCode());
            //wheel wheel_1 = new wheel(14);
            //wheel wheel1 = new wheel(15);
            //Console.WriteLine(wheel.GetHashCode());
            //Console.WriteLine(wheel1.Equals(wheel_1));
            //Console.WriteLine(wheel);
            //Car car1 = new Car(Model, wheel_1, engine);
            //Console.WriteLine(car.Equals(car1));
            //Console.WriteLine(car);
            //Console.WriteLine(car.GetHashCode());
            //Console.WriteLine(car1.GetHashCode());


            string menu = "Щоб їхати, натисність 'w' \nЩоб замінити колесо, натисніть 'r'\nЩоб заправитися, натисність 'f'";
            bool b = true;
            Console.WriteLine(menu);

            while (b)
            {
                var key = Console.ReadKey();
                if (key.KeyChar == 'w')
                {
                    Console.Clear();
                    car.ride();
                    Console.WriteLine(menu);
                    key = Console.ReadKey();
                }
                else if (key.KeyChar == 'r')
                {
                    Console.Clear();
                    car.ChangeWheel();
                    Console.WriteLine(menu);
                    key = Console.ReadKey();
                }
                else if (key.KeyChar == 'f')
                {
                    Console.Clear();
                    car.refuel();
                    Console.WriteLine(menu);
                    key = Console.ReadKey();
                }
            }
        }
        
    }
}
