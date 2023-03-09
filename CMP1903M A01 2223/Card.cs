using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_A01_2223
{
    
    //creates a card
    public class Card
    {
        
        // assigns the numerical values given when creating pack their respective suits and values.
        enum suits
        {
            diamonds = 1, hearts, clubs, spades
        }
        enum values
        {
            ace = 1, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king
        }

        //returns the card made
        public override string ToString()
        {
            return (values)Value + " of " + (suits)Suit;
        }


        public int Value { get; set; }
        public int Suit { get; set; }  
    
    }
}
