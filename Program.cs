using System;

namespace VehicleExample
{
    public class Vehicle
    {
        public string make = "";
        public string model = "";
        public struct position
        {
            public int posx;
            public int posy;
        }
        public void MoveForward()
        {

        }
    }

    public class Car : Vehicle
    {
        public int numberOfWheels;
        public int currentGear;

        public void Reverse()
        {

        }
    }

    public class Motorbike : Vehicle
    {                
        public int numberOfWheels;
        public int currentGear;

        public void Wheelie()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
