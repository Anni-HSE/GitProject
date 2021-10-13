using System;

namespace GitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dota2 hero = new Dota2("Pudge", "4526", 78, 300);
            hero.Show();
        }
    }

    class Dota2
    {
        string Hero { get; set; }
        string Health { get; set; }
        int Damage { get; set; }
        int Speed { get; set; }

        public Dota2(string hero, string health, int damage, int speed)
        {
            Hero = hero;
            Health = health;
            Damage = damage;
            Speed = speed;
        }

        public void Show()
        {
            Console.WriteLine($"Hero name = {Hero}, Hearo health = {Health}, Hero Damage = {Damage}, Hero speed = {Speed}");
        }

        
    }

    class BrawlStars
    {
        string Brawlik { get; set; }
    }
}
