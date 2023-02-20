namespace _2._3.If
{
    class Program
    {
        static readonly double fuelKilosConsumed = 34.42;
        static readonly int kmTravelled = 300;

        static void Main(string[] args)
        {
            var fuelTankCapacityKilos = 80d;
            var lapLength = 5.141d;
            var fuelKilosPerKm = fuelKilosConsumed / kmTravelled;
            var fuelKilosRemaining = fuelTankCapacityKilos - fuelKilosConsumed;
            var predictedDistanceUntilOutOfFuel = fuelKilosRemaining / fuelKilosPerKm;
            var predictedLapsUntilOutOfFuel = predictedDistanceUntilOutOfFuel / lapLength;
            if (predictedLapsUntilOutOfFuel < 4)
            {
                Console.WriteLine("Low on fuel. Laps remaining: " + predictedLapsUntilOutOfFuel);
            }
        }
    }
}
