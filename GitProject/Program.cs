using System;

namespace GitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BrawlStars leon = new BrawlStars("Leon", 2250);
            BrawlStars elPrimo = new BrawlStars("El Primo", 4250);
            Console.WriteLine($"КТО КРУЧИ?? {leon.Brawlik} или {elPrimo.Brawlik}");
            leon.Health > elPrimo.Health ? Console.WriteLine(leon.Brawlik) : Console.WriteLine(elPrimo.Brawlik);

        }
    }

    class BrawlStars
    {
        public string Brawlik { get; set; }
        public int Health { get; set; }

        public BrawlStars(string nameHero, int healthHero)
        {
            Brawlik = nameHero;
            Health = healthHero;
        }
    }
}
