using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_A01_2223
{
    //Main program
    class Program
    {
        static void Main(string[] args)
        {
            Pack deck = new Pack();
            
            Console.WriteLine("Enter shuffle type: ");
            Console.WriteLine("1: fisheryates, 2: riffle, 3: no shuffle");
            string shuffle_type = Console.ReadLine();
            
            int shuffle_int = Int32.Parse(shuffle_type);
            
            deck.shuffleCardPack(shuffle_int);

            Console.WriteLine("Enter number of cards to be dealt");
            string amount_of_cards = Console.ReadLine();

            int amount_of_cards_int = Int32.Parse(amount_of_cards);

            deck.dealCard(amount_of_cards_int);

//            Testing testing = new Testing();                           //Used for testing
        }
    }
}
