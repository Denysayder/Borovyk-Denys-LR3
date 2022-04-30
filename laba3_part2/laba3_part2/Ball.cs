using System;
namespace laba3_part2
{
    public class Ball : Toy
    {
        private string color;
        public Ball(int price, string color,int Age)
        {
            this.Age = Age;
            this.price = price;
            this.color = color;
        }

        public override string ClassName { get => "Ball"; set => ClassName = value; }
        public override string Property { get => color; set => color = value; }
    }
}

