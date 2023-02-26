﻿namespace _3._4._Plane4
{
    class Plane
    {
        // Constructor with a parameter
        public Plane(string newIdentifier)
        {
            Identifier = newIdentifier;
        }
        public string Identifier
        {
            get;
            private set;
        }
        double kilometersPerMile = 1.609344;
        public double SpeedInMilesPerHour
        {
            get
            {
                return SpeedInKilometersPerHour / kilometersPerMile;
            }
            set
            {
                SpeedInKilometersPerHour = value * kilometersPerMile;
            }
        }
        public double SpeedInKilometersPerHour
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var someBoeing777 = new Plane("BA0049");
            someBoeing777.SpeedInMilesPerHour = 150.0;
            Console.WriteLine("Your plane has identifier {0}, and is traveling at {1:0.00}mph [{2:0.00}kph]",
            someBoeing777.Identifier,
            someBoeing777.SpeedInMilesPerHour,
            someBoeing777.SpeedInKilometersPerHour);

            someBoeing777.SpeedInKilometersPerHour = 140.0;

            Console.WriteLine("Your plane has identifier {0}, and is traveling at {1:0.00}mph [{2:0.00}kph]",
            someBoeing777.Identifier,
            someBoeing777.SpeedInMilesPerHour,
            someBoeing777.SpeedInKilometersPerHour);

            Console.ReadKey();
        }
    }
}