using CMP1903M_A01_2223;


public class Testing
{
	public Testing()
	{
        
        for (int i = 1; i <= 3; i++)
        {    
            Console.WriteLine("-----start new test-----");

            Pack test_deck = new Pack();

            test_deck.shuffleCardPack(i);
            
            Console.WriteLine("currently testing shuffle type:" + i);
            
            test_deck.dealCard(3);
            
            Console.WriteLine("------------------------");
        }
        

    }
}