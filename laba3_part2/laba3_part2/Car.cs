using System;
namespace laba3_part2
{
    public abstract class Car : Toy
    {
        public string type;
    }

    public class SmallCar : Car
    {
        public SmallCar(int price, string type, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.type = type;
        }

        public override string ClassName { get => "Small Car"; set => ClassName = value; }
        public override string Property { get => type; set => type = value; }
    }

    public class MediumCar : Car
    {
        public MediumCar(int price, string type, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.type = type;
        }

        public override string ClassName { get => "Medium Car"; set => ClassName = value; }
        public override string Property { get => type; set => type = value; }
    }

    public class BigCar : Car
    {
        public BigCar(int price, string type, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.type = type;
        }

        public override string ClassName { get => "Big Car"; set => ClassName = value; }
        public override string Property { get => type; set => type = value; }
    }

}

