using System;
namespace laba3_try
{
    public class Engine
    {
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            Engine n = (Engine)obj;
            return (EnginePower == n.EnginePower);
        }

        public override int GetHashCode()
        {
            return EnginePower;
        }

        public override string ToString()
        {
            return (String.Format("Потужність двигуна: {0}",EnginePower));
        }

        private int EnginePower;

        public Engine(int EnginePower)
        {
            this.EnginePower = EnginePower;
        }

        public void Work()
        {
            Console.WriteLine("Двигун працює");
        }

        public static void Stop()
        {
            Console.WriteLine("Двигун вимкнено");
        }
    }
}

