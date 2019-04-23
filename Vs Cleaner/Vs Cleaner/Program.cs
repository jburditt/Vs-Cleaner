using System;
using System.Text.RegularExpressions;

namespace Vs_Cleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicationRootPath = AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine($"Root filepath is '{applicationRootPath}'.");

            var searchRegex = new Regex("(bin$|obj$)");
            var directoryPaths = FileHelper.FindDirectories(applicationRootPath, searchRegex, true);

            if (directoryPaths == null || directoryPaths.Count == 0)
                Console.WriteLine("No directories found.");
            else
                Console.WriteLine("Found the following directories.");

            foreach (var directoryPath in directoryPaths)
                Console.WriteLine(directoryPath);
        }
    }
}