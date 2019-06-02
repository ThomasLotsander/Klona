using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Klona.Business.Helpers
{
    public static class CardHelper
    {


        // Hearts
        public static string Klona = "Klona";

        // Spads
        public static string Guardian = "Guardina";

        // Diamonds
        public static string Armor = "Armor";

        // Clubs
        public static string Blorg = "Blorg";

        public static string GetCardSuit(int number)
        {
            switch (number)
            {
                case 1:
                    return "Hearts";

                case 2:
                    return "Spads";

                case 3:
                    return "Diamonds";

                case 4:
                    return "Clubs";

                default:
                    return "Joker";
            }
        }

        public static string GetCardValue(int number)
        {
            switch (number)
            {
                case 10:
                    return "10";

                case 11:
                    return "Jack";

                case 12:
                    return "Queen";

                case 13:
                    return "King";

                case 14:
                    return "Ace";

                default:
                    return "Joker";

            }
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
