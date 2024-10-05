namespace Slot_Machine_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();
            int[] symbols = { 1, 2, 3, 4, 5, 6, };
            int Playerbet = 0;
            int Purse = 20;

            Console.WriteLine("\nWanna play some Slot machine..? Of course you do..");
            Console.WriteLine("\nSo, every horizontal and vertical line doubles your bet, and every line across triples it");
            Console.WriteLine("Got 20 dollars in your purse to get you going!");
            Console.WriteLine("Alright, go on, place your bet now! From one dollar to ten!");

            int playerBet = int.Parse(Console.ReadLine());

            if (playerBet > 10 && playerBet == 0 )
            {
                Console.WriteLine("False bet, try again");
            }
        }
    }
}
