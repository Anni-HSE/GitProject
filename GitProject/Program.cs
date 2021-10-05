using System;

namespace GitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет как дела");

            Random rnd = new Random();

            int n = rnd.Next(1, 10);
            Console.WriteLine($"{n}");
        }
    }
}
