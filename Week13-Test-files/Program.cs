
using System;
using System.IO;

namespace Week13_Test_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = $@"C:\Users\opilane\Samples\Week13ulesanded";

            Console.WriteLine("Sistage faili nimi");
            string kasutajanimi = Console.ReadLine();

            string newDirectoryFullPath = $@"{rootdirectory}\{kasutajanimi}.txt";

            bool directoryexists = Directory.Exists(newDirectoryFullPath);

            if (directoryexists)
            {
                Console.WriteLine($"{kasutajanimi} on juba eksiteeritud");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"{kasutajanimi} loodud kausta Samples");
            }
            
        }
    }
}
