using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> pack = new List<Card>();

        public Pack()
        {
        
            //Initialise the card pack here
           
            // uses int suit to represent card suit, loops per suit  
            foreach (int suit in Enumerable.Range(1,4))
            {
                // uses int value to represents cards value, loops per value in suit
                foreach (int value in Enumerable.Range(1,13))
                {
                    //creates a new card
                    Card new_card = new Card();
                    
                    //asigns the cards attributes according to the loops current position
                    new_card.Value = value;
                    new_card.Suit = suit;                    
                    
                    //adds the new card to the pack
                    pack.Add(new_card);
                }

            }
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

            
            if (typeOfShuffle == 1)
            {               
                int shuffle_count = pack.Count;
                Random random = new Random();

                //i simply used to iterate
                for (int i = shuffle_count; i > 0; i--)
                {
                    shuffle_count--;
                    
                    //generates random number from within the boundarys set by shuffle count (the pack length)
                    int random_number = random.Next(shuffle_count+1);

                    //Moves the randomly selected card to the end
                    pack.Add(pack[random_number]);
                    
                    //Removes the randomly selected card from its original postion, stoppping duplicatations.
                    pack.Remove(pack[random_number]);

                }
                return false;
                    

            }
            else if (typeOfShuffle == 2)
            {
                
                //two empty lists used to carry the two half piles
                List<Card> currently_riffling_1 = new List<Card>();
                List<Card> currently_riffling_2 = new List<Card>();
                
                
                int shuffle_count = pack.Count;
                int riffle_count = pack.Count;
                Random random = new Random();

                //i simply used to iterate
                for (int i = 26; i <= shuffle_count -1; i++)
                {
                    //splits the pack into 2, top half in currently riffling list
                    currently_riffling_1.Add(pack[i]);
                }

                for (int i = 0; i <= (shuffle_count/2) -1; i++)
                {
                    //splits the pack into 2, top half in currently riffling list
                    currently_riffling_2.Add(pack[i]);
                }

                //remove cards from pack, as they have been added to the currently_riffling piles
                pack.RemoveRange(0, 52);

                while(riffle_count>=1)
                {

                    //ensures the shuffle is randomized
                    int random_number = random.Next(1);
                    
                    //adds selected card from riffle pile into pack pile
                    pack.Add(currently_riffling_1[random_number]);
                    
                    //removes that card from the riffle pile
                    currently_riffling_1.Remove(currently_riffling_1[random_number]);
                    
                    random_number = random.Next(1);
                    pack.Add(currently_riffling_2[random_number]);
                    currently_riffling_2.Remove(currently_riffling_2[random_number]);

                    //re-counts riffle size
                    riffle_count = currently_riffling_2.Count();

                }
                return false;
            }
            else if (typeOfShuffle == 3)
            {
                //typeOfshuffle 3 is no shuffle, so do nothing
                return false;
            }

            //incase the user enters an incorrect input
            else
            {
                Console.WriteLine("Incorrect type of shuffle, please pick either 1,2 or 3");
                return false;
            }       

        }
        public bool deal()
        {
            //Deals one card
            Console.WriteLine("you have been dealt a: "+ pack[0] );
            pack.Remove(pack[0]);
            return false;
        }
        public bool dealCard(int amount)
        {
            //again i simply used to iterate
            for (int i = 0; i < amount; i++)
            {
                deal();
            }
            
            //Deals the number of cards specified by 'amount'
            return false;
        }
    }
}
