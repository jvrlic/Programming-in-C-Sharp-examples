using _4._1._FireChief;

namespace _4._03._UsingDerived
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigChiefHarry = new FireChief { Name = "Harry" };
            // Another reference to Harry, but as a firefighter
            Firefighter stillHarry = bigChiefHarry;
            var joe = new Firefighter { Name = "Joe" };

            bigChiefHarry.TellFirefighterToExtinguishFire(stillHarry);
            bigChiefHarry.TellFirefighterToExtinguishFire(bigChiefHarry);
            bigChiefHarry.ExtinguishFire();
            stillHarry.TellFirefighterToExtinguishFire(joe);
        }
    }
}