namespace _3._8._PolarPoint3D
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

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}