namespace _2._5._Switch
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
            switch (raceStatus)
            {
                case "YellowFlag":
                    Driver.TellNotToOvertake();
                    break;
                case "SafetyCar":
                    Driver.WarnAboutSafetyCar();
                    break;
                case "RedFlag":
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
                    break;
                default:
                    Driver.TellToDriveFaster();
                    break;
            }
        }
    }
}