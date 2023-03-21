namespace X._09_Filenames
{
    class Program
    {
        static IEnumerable<string> GetAllFilesInDirectory(string directoryPath)
        {
            return Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories);
        }

        static void Main(string[] args)
        {
            var bigFiles = from file in GetAllFilesInDirectory(@"c:\")
                           where new FileInfo(file).Length > 10000000
                           select file;

            foreach (string file in bigFiles)
            {
                Console.WriteLine(file);
            }
        }
    }
}