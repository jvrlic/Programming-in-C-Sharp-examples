using _4._1._FireChief;

namespace _4._02._UsingBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var truckOne = new Firetruck();
            var bigChiefHarry = new FireChief { Name = "Harry" };
            truckOne.Driver = bigChiefHarry;
            bigChiefHarry.Drive(truckOne, new Point(100, 300));
            var joe = new Firefighter { Name = "Joe" };
            bigChiefHarry.TellFirefighterToExtinguishFire(joe);


        }
    }
}