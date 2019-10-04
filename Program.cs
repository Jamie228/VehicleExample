using System;

namespace VehicleExample
{
    public class Vehicle
    {
        string make;
        public string Model { get; set; }

        protected Position position;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int X
        {
            get { return position.x; }
        }

        public Vehicle(string make, string model)
        {
            this.make = make;
            this.Model = model;
        }

        public void MoveForward()
        {
            position.x += 1;
        }

        public struct Position
        {
            public int x, y;

            public Position(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }

    public class Car : Vehicle
    {
        public int numberOfWheels;
        public int currentGear;

        public Car(int numberOfWheels, string make, string model) : base(make, model)
        {
            this.numberOfWheels = numberOfWheels;
            currentGear = 0;
        }

        public void Reverse()
        {
            position.x -= 1;
        }
    }

    /* public class Motorbike : Vehicle
    {
        public int numberOfWheels;
        public int currentGear;

        public void Wheelie()
        {

        }
    } */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Vehicles");
            Car car1 = new Car(4, "Ford", "B-MAX");
            
            Console.WriteLine($"{car1.Model} position: {car1.X}");
            
            for(int i=0; i < 10; i ++)
            {
                car1.MoveForward();
            }
            Console.WriteLine($"{car1.Model} position: {car1.X}");
        }
    }
}
