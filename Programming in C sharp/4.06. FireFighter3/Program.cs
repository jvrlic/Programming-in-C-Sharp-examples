namespace _4._06._FireFighter3
{
    public class Point
    {
        public Point(int x, int y) {; }
    }

    public class Firefighter
    {
        public string Name { get; set; }

        /*
        public virtual void ExtinguishFire()
        {
            Console.WriteLine("{0} is putting out the fire!", Name);
        }
         * */

        // This calls TrainHoseOnFire and TurnOnHose as part of the
        // process for extinguishing the fire
        public virtual void ExtinguishFire()
        {
            Console.WriteLine("{0} is putting out the fire!", Name);
            TrainHoseOnFire();
            TurnOnHose();
        }
        private void TurnOnHose()
        {
            Console.WriteLine("The fire is going out.");
        }
        private void TrainHoseOnFire()
        {
            Console.WriteLine("Training the hose on the fire.");
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
         * */
        public override void ExtinguishFire()
        {
            // Get our number one to put out the fire instead
            TellFirefighterToExtinguishFire(NumberOne);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // A reference to Joe, Harry's number one
            Firefighter joe = new Firefighter { Name = "Joe" };
            joe.ExtinguishFire();
            FireChief harry = new FireChief { Name = "Harry", NumberOne = joe };
            harry.ExtinguishFire();
            FireChief harryWife = new FireChief { Name = "HarryWife", NumberOne = harry };
            harryWife.ExtinguishFire();
            Console.ReadKey();
        }
    }
}