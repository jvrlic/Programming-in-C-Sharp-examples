using System.Drawing;

namespace _4._1._FireChief
{
    public class Firefighter
    {
        public string Name { get; set; }
        public void ExtinguishFire()
        {
            Console.WriteLine("{0} is putting out the fire!", Name);
        }
        public void Drive(Firetruck truckToDrive, Point coordinates)
        {
            if (truckToDrive.Driver != this)
            {
                // We can't drive the truck if we're not the driver
                // But just silently failing is BADBAD
                // What we need is some kind of structured means
                // of telling the client about the failure
                // We'll get to that in Chapter 6
                return;
            }
            truckToDrive.Drive(coordinates);
        }

    }

    public class Firetruck
    {
        public Firefighter Driver { get; set; }
        public void Drive(Point coordinates)
        {
            if (Driver == null)
            {
                // We can't drive if there's no driver
                return;
            }
            Console.WriteLine("Driving to {0}", coordinates);
        }
    }

    public class FireChief : Firefighter
    {
        public void TellFirefighterToExtinguishFire(Firefighter colleague)
        {
            colleague.ExtinguishFire();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}