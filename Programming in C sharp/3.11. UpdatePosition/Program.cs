namespace _3._11._UpdatePosition
{
    struct PolarPoint3D
    {
        public PolarPoint3D(double distance, double angle)
            : this(distance, angle, 0)
        { }
        public PolarPoint3D(double distance, double angle, double altitude)
            : this()
        {
            Distance = distance;
            Angle = angle;
            Altitude = altitude;
        }
        public double Distance
        {
            get;
            private set;
        }
        public double Angle
        {
            get;
            private set;
        }
        public double Altitude
        {
            get;
            private set;
        }
    }

    enum DirectionOfApproach : int
    {
        Approaching = 0,
        Leaving = 1
    }

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
        const double kilometersPerMile = 1.609344;
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
        public DirectionOfApproach Direction
        {
            get;
            set;
        }

        public PolarPoint3D Position
        {
            get;
            set;
        }

        public void UpdatePosition(double minutesToAdvance)
        {
            double hours = minutesToAdvance / 60.0;
            double milesMoved = SpeedInMilesPerHour * hours;
            double milesToTower = Position.Distance;
            if (Direction == DirectionOfApproach.Approaching)
            {
                milesToTower -= milesMoved;
                if (milesToTower < 0)
                {
                    // We've arrived!
                    milesToTower = 0;
                }
            }
            else
            {
                milesToTower += milesMoved;
            }
            PolarPoint3D newPosition = new PolarPoint3D(
            milesToTower, Position.Angle, Position.Altitude);

            Position = newPosition;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Plane someBoeing777 = new Plane("BA0049")
            {
                Direction = DirectionOfApproach.Approaching,
                SpeedInMilesPerHour = 150
            };
            Console.WriteLine(
            "Your plane has identifier {0}," +
            " and is traveling at {1:0.00}mph [{2:0.00}kph]",
            // Use the property getter
            someBoeing777.Identifier,
            someBoeing777.SpeedInMilesPerHour,
            someBoeing777.SpeedInKilometersPerHour);
            someBoeing777.SpeedInKilometersPerHour = 140.0;
            Console.WriteLine(
            "Your plane has identifier {0}," +
            " and is traveling at {1:0.00}mph [{2:0.00}kph]",
            // Use the property getter
            someBoeing777.Identifier,
            someBoeing777.SpeedInMilesPerHour,
            someBoeing777.SpeedInKilometersPerHour);
            Console.ReadKey();
        }

    }
}