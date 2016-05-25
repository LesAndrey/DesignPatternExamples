using System;

namespace GoF_TryOut.Commands.Example2.StraightCode
{
    public class HeroB
    {
        public void Jump()
        {
            Console.WriteLine("HeroB Jumped");
        }

        public void Run()
        {
            Console.WriteLine("HeroB Running");
        }

        public void CastMagic()
        {
            Console.WriteLine("HeroB CastMagic");
        }

        public void SwapSpell()
        {
            Console.WriteLine("Hero Swaped Spell");
        }
    }
}