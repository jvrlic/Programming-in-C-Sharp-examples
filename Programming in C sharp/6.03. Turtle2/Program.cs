using _6._03.Turtle2;

namespace _6._03._Turtle2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arthurTheTurtle = new Turtle
            {
                PlatformWidth = 0.0,
                PlatformHeight = 10.0,
                MotorSpeed = 5.0
            };

            ShowPosition(arthurTheTurtle);
            // We want to proceed forwards
            arthurTheTurtle.LeftMotorState = MotorState.Running;
            arthurTheTurtle.LeftMotorState = (MotorState)5;
            arthurTheTurtle.RightMotorState = MotorState.Running;
            // For two seconds
            var result = arthurTheTurtle.RunFor(2.0);
            if (result != TurtleError.OK)
            {
                HandleError(result);
                return;
            }
            ShowPosition(arthurTheTurtle);
            // Now, let's rotate clockwise for a bit
            arthurTheTurtle.RightMotorState = MotorState.Reversed;
            // PI / 2 seconds should do the trick
            result = arthurTheTurtle.RunFor(Math.PI / 2.0);
            if (result != TurtleError.OK)
            {
                HandleError(result);
                return;
            }
            ShowPosition(arthurTheTurtle);
            // And let's go into reverse
            arthurTheTurtle.RightMotorState = MotorState.Reversed;
            arthurTheTurtle.LeftMotorState = MotorState.Reversed;
            // And run for 5 seconds
            result = arthurTheTurtle.RunFor(5);
            if (result != TurtleError.OK)
            {
                HandleError(result);
                return;
            }
            ShowPosition(arthurTheTurtle);
            // Then rotate back the other way
            arthurTheTurtle.RightMotorState = MotorState.Running;
            // And run for PI/4 seconds to give us 45 degrees
            result = arthurTheTurtle.RunFor(Math.PI / 4.0);
            if (result != TurtleError.OK)
            {
                HandleError(result);
                return;
            }
            ShowPosition(arthurTheTurtle);
            // And finally drive backwards for a bit
            arthurTheTurtle.RightMotorState = MotorState.Reversed;
            arthurTheTurtle.LeftMotorState = MotorState.Reversed;
            result = arthurTheTurtle.RunFor(Math.Cos(Math.PI / 4.0));
            if (result != TurtleError.OK)
            {
                HandleError(result);
                return;
            }
            ShowPosition(arthurTheTurtle);
            Console.ReadKey();

        }
        private static void ShowPosition(Turtle arthurTheTurtle)
        {
            Console.WriteLine(
            "Arthur is at ({0}) and is pointing at angle {1:0.00} radians.",
            arthurTheTurtle.CurrentPosition,
            arthurTheTurtle.CurrentOrientation);
        }
        private static void HandleError(TurtleError result)
        {
            Console.WriteLine("We hit turtle error {0}", result);
            Console.ReadKey();
        }
    }
}