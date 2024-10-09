using System.Runtime.Intrinsics;

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
            int GridRows = 3;
            int GRidColumns = 3;

            Console.WriteLine("\nWanna play some Slot machine..? Of course you do..");
            Console.WriteLine("\nSo, every horizontal and vertical line doubles your bet, and every line across triples it");
            Console.WriteLine("Got 20 dollars in your purse to get you going!");

            Console.WriteLine("\nNow decide which grids you wanna play!");
            Console.WriteLine("V1, V2, V3 is for vertical, H1, H2, H3 is for horizontal, D is for diagonal");

            int[,] V1 = new int[GridRows, GRidColumns];
            int[,] V2 = new int[GridRows, GRidColumns];
            int[,] V3 = new int[GridRows, GRidColumns];
            int[,] H1 = new int[GridRows, GRidColumns];
            int[,] H2 = new int[GridRows, GRidColumns];
            int[,] H3 = new int[GridRows, GRidColumns];
            int[,] D = new int[GridRows, GRidColumns];

            string playerLine = Console.ReadLine();
            if (playerLine != )

            Console.WriteLine("Alright, go on, place your bet now! From one dollar to ten!");

            int playerBet = int.Parse(Console.ReadLine());
           

            if (playerBet > 10 && playerBet == 0 )
            {
                Console.WriteLine("False bet, try again");
            }
        }
    }
}
