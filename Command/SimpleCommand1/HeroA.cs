using System;

namespace GoF_TryOut.Commands.Example2.StraightCode
{
    public class HeroA
    {
        public void Jump()
        {
            Console.WriteLine("HeroA Jumped");
        }

        public void Run()
        {
            Console.WriteLine("HeroA Running");
        }

        public void Shoot()
        {
            Console.WriteLine("HeroA Shooted");
        }

        public void SwapWeapon()
        {
            Console.WriteLine("HeroA Swaped Weapons");
        }
    }
}