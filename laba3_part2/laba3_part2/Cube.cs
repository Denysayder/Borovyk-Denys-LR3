using System;
namespace laba3_part2
{
    public class Cube : Toy
    {
        private string Material;
        public Cube(int price, string Material, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.Material = Material;
        }

        public override string ClassName { get => "Cube"; set => ClassName = value; }
        public override string Property { get => Material; set => Material = value; }
    }
}

