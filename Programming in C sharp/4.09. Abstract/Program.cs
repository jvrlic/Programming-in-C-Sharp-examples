namespace _4._09._Abstract
{
    public class Point
    {
        public Point(int x, int y) {; }
    }

    //public class Firefighter
    public abstract class Firefighter
    {
        public string Name { get; set; }

        //protected abstract void TestAbstract();
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
        /*
        private void TurnOnHose()
        {
            Console.WriteLine("The fire is going out.");
        }
        private void TrainHoseOnFire()
        {
            Console.WriteLine("Training the hose on the fire.");
        }
         * */
        protected virtual void TurnOnHose()
        {
            Console.WriteLine("The fire is going out.");
        }
        protected virtual void TrainHoseOnFire()
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

    class TraineeFirefighter : Firefighter
    {
        private bool hoseTrainedOnFire;
        protected override void TurnOnHose()
        {
            if (hoseTrainedOnFire)
            {
                // Call on the base implementation
                base.TurnOnHose();
            }
            else
            {
                Console.WriteLine("There's water going everywhere!");
            }
        }
        protected override void TrainHoseOnFire()
        {
            hoseTrainedOnFire = true;
            base.TrainHoseOnFire();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Firefighter joe = new Firefighter { Name = "Joe" };
            Firefighter bill = new TraineeFirefighter { Name = "Bill" };
            bill.ExtinguishFire();
            Firefighter pero = new FireChief { Name = "Pero" };
            pero.ExtinguishFire();
        }
    }
}