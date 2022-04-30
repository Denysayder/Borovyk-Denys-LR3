using System;
using Newtonsoft.Json;
namespace laba3_part2
{
    public class Room
    {
        public Room()
        {

        }

        public void SortByPrice(List<Toy> AllToys)
        {
            var PriceAscending =
            from p in AllToys
            orderby p.price
            select p;
            foreach (var n in PriceAscending)
                Console.WriteLine(n.price + " " + n);
        }

        public List<Toy> GetToyList()
        {
            List<Toy> Toys = new List<Toy>();
            Toys.Add(new Ball(25, "Green", 3));
            Toys.Add(new SmallCar(50, "Passenger", 3));
            Toys.Add(new Cube(150, "Plastic with Magnets",10));
            Toys.Add(new Doll(50, "Barbie", 6));
            Toys.Add(new BigCar(70, "Truck",3));
            Toys.Add(new Ball(20, "Blue",3));
            Toys.Add(new Doll(40, "LoL",6));
            Toys.Add(new Cube(120, "Plastic",10));
            Toys.Add(new MediumCar(60, "Loader", 6));
            Toys.Add(new Doll(50, "Ken",6));
            Toys.Add(new Cube(90, "Wooden",10));
            Toys.Add(new Cube(170, "Lego", 12));
            Toys.Add(new Doll(30, "Masha", 3));
            Toys.Add(new Ball(30, "Red", 3));
            Toys.Add(new Ball(50, "Rainbow-colored", 3));
            Toys.Add(new BigCar(100, "garbage truck", 6));
            Toys.Add(new Ball(20, "light green", 3));
            Toys.Add(new Doll(60, "Piper", 3));
            Toys.Add(new Cube(200, "Magnet", 12));
            Toys.Add(new Doll(50, "Bratz", 6));
            Toys.Add(new MediumCar(60, "crane", 6));
            Toys.Add(new Ball(25, "Yellow", 3));
            Toys.Add(new SmallCar(200, "Radio-controlled", 3));
            return Toys;
        }

        public List<Toy> FillRoom(int TotalPrice, int Age)
        {
            Room room = new Room();
            List<Toy> ToyList = room.GetToyList();
            List<Toy> AddedToys = new List<Toy>();
            int CurrentPrice=0;
            if (TotalPrice > ToyList[0].price)
            {
                CurrentPrice = ToyList[0].price;
                AddedToys.Add(ToyList[0]);
            }
            foreach (var n in ToyList.Skip(1))
            {
                if (n.Age <= Age)
                {
                    AddedToys.Add(n);
                    CurrentPrice = CurrentPrice + AddedToys[AddedToys.Count - 1].price;
                }

                if (CurrentPrice > TotalPrice)
                {
                    CurrentPrice = CurrentPrice - AddedToys[AddedToys.Count - 1].price;
                    AddedToys.Remove(AddedToys[AddedToys.Count - 1]);
                }
            }
            return AddedToys;
        }

        public void FindToyInRoom(int Price, string Property, List<Toy> Toys)
        {
            bool IsFound = false;
            foreach (var n in Toys)
            {
                if (Price == n.price && Property == n.Property)
                {
                    Console.WriteLine("Іграшка знайдена!");
                    IsFound = true;
                }
            }
            if (IsFound==false)
            Console.WriteLine("Іграшка не знайдена");
        }
    }
}
