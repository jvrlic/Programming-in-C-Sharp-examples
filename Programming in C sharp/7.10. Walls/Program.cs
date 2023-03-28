namespace _7._10._Walls
{
    class Program
    {
        static void Main(string[] args)
        {
            var walls = new int[,]
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1 },
                { 1, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };

            Console.WriteLine(CanCharacterMoveDown(0, 1, walls));

        }

        static bool CanCharacterMoveDown(int x, int y, int[,] walls)
        {
            int newY = y + 1;
            // Can't move off the bottom of the map
            if (newY == walls.GetLength(0)) { return false; }
            // Can only move down if there's no wall in the way
            return walls[newY, x] == 0;
        }
    }
}