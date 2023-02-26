namespace _2._4._If_else
{
    class Driver
    {
        public static void TellNotToOvertake() {; }
        public static void WarnAboutSafetyCar() {; }
        public static void ReducePay() {; }
        public static void Resuscitate() {; }
        public static void CallBackToPit() {; }
        public static void TellToDriveFaster() {; }
    }

    class Factory
    {
        public static void OrderNewCar() {; }
    }

    internal class Program
    {
        private static readonly bool ourDriverCausedIncident = true;
        private static readonly bool feelingGenerous = true;

        static void Main(string[] args)
        {
            var raceStatus = args[3];
            if (raceStatus == "YellowFlag")
            {
                Driver.TellNotToOvertake();
            }
            else if (raceStatus == "SafetyCar")
            {
                Driver.WarnAboutSafetyCar();
            }
            else if (raceStatus == "RedFlag")
            {
                if (ourDriverCausedIncident)
                {
                    Factory.OrderNewCar();
                    Driver.ReducePay();
                    if (feelingGenerous)
                    {
                        Driver.Resuscitate();
                    }
                }
                else
                {
                    Driver.CallBackToPit();
                }
            }
            else
            {
                Driver.TellToDriveFaster();
            }
        }
    }
}