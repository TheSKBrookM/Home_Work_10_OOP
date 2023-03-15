using ДР_10_2.Creatures;
using System;
using System.Security.Cryptography;

namespace ДР_10_2
{

    class Program
    {
        public static IMagicCreature Check(string creature)
        {
            Elf elf;
            Dragon dragon;
            Unicorn unicorn;
            Human human;
            Fairy fairy;
            Wolf wolf;

            switch (creature.ToLower())
            {
                case "elf":
                    return elf = new Elf();
                case "dragon":
                    return dragon = new Dragon();
                case "unicorn":
                    return unicorn = new Unicorn();
                case "human":
                    return human = new Human();
                case "fairy":
                    return fairy = new Fairy();
                case "wolf":
                    return wolf = new Wolf();
                default:
                    return null;
            }

        }

        static void Main(string[] args)
        {
            MagicBag<IMagicCreature> magicBag = new MagicBag<IMagicCreature>();

            Console.WriteLine("elf, dragon, unicorn, human, fairy, wolf");

            while (true)
            {
                Console.Write("\nWrite your type from the list: ");
                var name = Console.ReadLine();

                var creature = Check(name);

                var creatures = new List<IMagicCreature>();

                if (creature != null)
                {
                    creatures.Add(creature);
                }
                else
                {
                    Console.WriteLine(name + " does not exist");
                }

                foreach (var item in creatures)
                {
                    magicBag.GetGift(item);
                }
            }
            Console.ReadKey();
        }
    }
}