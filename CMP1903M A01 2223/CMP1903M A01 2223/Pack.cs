using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here
            foreach (int suit in Enumerable.Range(1,4))
            {
                foreach (int value in Enumerable.Range(1,12))
                {
                    pack.Add(new card(suit, value));
                }

            }

        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
