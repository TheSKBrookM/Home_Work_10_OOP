using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ДР_10_2.Creatures;

namespace ДР_10_2
{

    class MagicBag<T> where T : IMagicCreature
    {
        private readonly List<(string CreatureType, GiftEnum Gift, DateTime Time)> gifts = new List<(string, GiftEnum, DateTime)>();

        private readonly Random random = new Random();

        public GiftEnum GetGift(T creature)
        {
            var creatureType = creature.CreatureType;
            var lastGiftIndex = -1;

            // Знаходимо індекс останнього подарунку, який було видано для цієї істоти
            for (var i = gifts.Count - 1; i >= 0; i--)
            {
                if (gifts[i].CreatureType == creatureType)
                {
                    lastGiftIndex = i;
                    break;
                }
            }

            var today = DateTime.Today;

            // Якщо для цієї істоти ще не видавали жодного подарунка або останній подарунок було видано вчора,
            // то генеруємо новий подарунок
            if (lastGiftIndex == -1 || gifts[lastGiftIndex].Gift == GiftEnum.None || gifts[lastGiftIndex].Time < today)
            {
                var gift = (GiftEnum)(random.Next(1, 4));
                gifts.Add((creatureType, gift, DateTime.Now));
                Console.WriteLine("{0} got a {1}!\n", creature.CreatureType, gift);
                return gift;
            }
            else
            {
                // Якщо для цієї істоти вже було видано подарунок сьогодні, то повертаємо None
                Console.WriteLine("{0} got no gift.\n", creature.CreatureType);
                return GiftEnum.None;
            }
        }
    }

}
