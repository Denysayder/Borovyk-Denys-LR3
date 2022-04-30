using System;
namespace laba3_try
{
    public class wheel
    {
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            wheel n = (wheel)obj;
            return (diametr == n.diametr);
        }

        public override int GetHashCode()
        {
            return diametr;
        }

        public override string ToString()
        {
            return (String.Format("Діаметр колеса: {0}", diametr));
        }

        private int diametr;

        public wheel(int diametr)
        {
            this.diametr = diametr;
        }

        public void spin()
        {
            Console.WriteLine("Колеса крутяться");
        }

        public void change()
        {
            Console.WriteLine("Старе колесо знято");
            Console.WriteLine("Нове колесо встановлено");
        }

        public static void stop()
        {
            Console.WriteLine("Колеса зупинені");
        }
    }
}

