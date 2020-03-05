using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Vs_Cleaner
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                var applicationRootPath = AppDomain.CurrentDomain.BaseDirectory;
                CleanFolder(applicationRootPath);
            }
            else
            {
                foreach (var arg in args)
                {
                    CleanFolder(arg);
                }
            }
        }

        public static void CleanFolder(string rootDirectoryPath)
        {
            Console.WriteLine($"Cleaning filepath '{rootDirectoryPath}'.");

            var searchRegex = new Regex("(^bin$|^obj$)");
            var directoryPaths = FileHelper.FindDirectories(rootDirectoryPath, searchRegex, true);

            if (directoryPaths == null || directoryPaths.Count == 0)
                Console.WriteLine("No directories found.");
            else
                Console.WriteLine("Found the following directories.");

            foreach (var directoryPath in directoryPaths)
            {
                Console.WriteLine(directoryPath);
                Directory.Delete(directoryPath, true);
            }
        }
    }
}