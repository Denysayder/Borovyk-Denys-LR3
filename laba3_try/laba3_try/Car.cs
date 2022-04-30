using System;
namespace laba3_try
{
    public class Car
    {
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            Car c = (Car)obj;
            return (Model == c.Model);
        }

        public override int GetHashCode()
        {
            return Model.GetHashCode();
        }

        public override string ToString()
        {
            return (String.Format("Модель автомобіля: {0}", Model));
        }

        private string Model { get; set; }
        Engine engine;
        wheel wheel;
        private bool IsRide;

        public Car(string Model, wheel wheel, Engine engine)
        {
            this.Model = Model;
            this.engine = engine;
            this.wheel = wheel;
        }

        public void ride()
        {
            IsRide = true;
            engine.Work();
            wheel.spin();
            Console.WriteLine("Автомобiль їде");
        }

        public void ChangeWheel()
        {
            if (IsRide == true)
            {
                Car.stop();
                IsRide = false;
            }
            wheel.change();

        }

        public void refuel()
        {
            if (IsRide == true)
            {
                Car.stop();
                IsRide = false;
            }
            Console.WriteLine("Автомобiль заправляється");
        }

        public static void stop()
        {
            wheel.stop();
            Console.WriteLine("Автомобіль зупинено");
            Engine.Stop();
        }
    }
}

