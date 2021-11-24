using System;
using System.IO;


namespace Ulesanne2

{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\Week13ulesanded";
            string starsFile = "stars";
            string planetFile = "planets";
            string FullStarPath = $@"{rootDirectory}\{starsFile}.txt";
            string FullPlanetsPath = $@"{rootDirectory}\{planetFile}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool starsfullpathexists = File.Exists(starsFile);
            bool planetfullpathexists = File.Exists(FullPlanetsPath);
            
            if (directoryExists && starsfullpathexists && planetfullpathexists)
            {
                Console.WriteLine($"{starsFile} and {planetFile} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(FullStarPath);
                File.Create(FullPlanetsPath);
                Console.WriteLine($"{starsFile} and {planetFile} have been created in {rootDirectory}.");

            }
            else
            {
                File.Create(FullStarPath);
                File.Create(FullPlanetsPath);
                Console.WriteLine($"{starsFile} and {planetFile} has been created in {rootDirectory}.");
            }
        }
    }
}
