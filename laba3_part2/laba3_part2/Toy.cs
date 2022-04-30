using System;
namespace laba3_part2
{
    public abstract class Toy
    {
        public abstract string ClassName { get; set; }
        public abstract string Property { get; set; }
        public int price;
        public int Age;
        public override string ToString()
        {
            return (String.Format("{0} {1}",Property, ClassName));
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            Toy toy = (Toy)obj;
            return (Property == toy.Property) && (price == toy.price);
        }
    }
}

