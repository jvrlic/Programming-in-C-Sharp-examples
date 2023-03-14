namespace _4._04._FireChief2
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
        public Firefighter NumberOne;

        private void TellFirefighterToExtinguishFire(Firefighter colleague)
        {
            colleague.ExtinguishFire();
        }
        /*
        public void ExtinguishFire()
        {
            // Get our number one to put out the fire instead
            TellFirefighterToExtinguishFire(NumberOne);
        }
        */

        public new void ExtinguishFire()
        {
            // Get our number one to put out the fire instead
            TellFirefighterToExtinguishFire(NumberOne);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var joe = new Firefighter { Name = "Joe" };
            // Firefighter harry is really a firechief, with joe as his NumberOne
            var harry = new FireChief { Name = "Harry", NumberOne = joe };
            // Harry is just a firefighter, so he can extinguish fires
            // but we want him to get joe to do the work
            harry.ExtinguishFire();
        }
    }
}