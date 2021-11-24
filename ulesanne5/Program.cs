using System;
using System.IO;

namespace ulesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So Interesting You'll Say, OMG!");
            Console.WriteLine("enter the nr of facts you want to see");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            FunFact(usernumber);
        }
        private static void FunFact(int FunNum)
        {
            string filepath = @"C:\Users\opilane\samples\week13ulesanded\funfacts.txt";
            string[] Facts = File.ReadAllLines(filepath);

            if (FunNum > Facts.Length)
            {
                FunNum = Facts.Length;
            }

            for (int i = 0; i < FunNum; i++)
            {
                Console.WriteLine(Facts[i]);
            }

        }
    }
}