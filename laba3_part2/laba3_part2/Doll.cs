using System;
namespace laba3_part2
{
    public class Doll : Toy
    {
        public Doll(int price, string name, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.name = name;
        }
        private string name;
        public override string ClassName { get => "Doll"; set => ClassName = value; }
        public override string Property { get => name; set => name = value; }
    }
}

