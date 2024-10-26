using System.ComponentModel.Design;
using System.Runtime.Intrinsics;

namespace Slot_Machine_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GridRows = 3;
            const int GridColumns = 3;
            const int MinBet = 1;
            const int MaxBet = 10;

            int[] symbols = { 1, 2,};
            int Playerbet = 0;
            int Purse = 20;
            
            Console.WriteLine("\nWanna play some Slot machine..? Of course you do..");
            Console.WriteLine("\nSo, every horizontal and vertical line doubles your bet, every line across triples it, and the middle line is jackpot.");
            Console.WriteLine("Got 20 dollars in your purse to get you going!");

            Console.WriteLine("\nNow decide which grids you wanna play!");
            Console.WriteLine("V for vertical, H for horizontal, D is for diagonal and X is for the middle.");
            //Console.WriteLine("\n");

            string playerLine = Console.ReadLine();
            
            List<string> playersGridchoice = ["v", "h", "d", "x"];
            

            if (!playersGridchoice.Contains(playerLine))
            {
                Console.WriteLine("Invalid Input. Please use the assigned letters.");
            }

            else
            {
                Console.WriteLine("Alright, go on, place your bet now! From one dollar to ten!");

                int[,] grid = new int[GridRows, GridColumns];
                Random randomNumber = new Random();


                for (int rowindex = 0; rowindex < GridRows; rowindex++)
                {
                    for (int columnindex = 0; columnindex < GridColumns; columnindex++)
                    {
                        grid[rowindex, columnindex] = randomNumber.Next(1, 3);
                    }
                }

                for (int rowindex = 0; rowindex < GridRows; rowindex++)
                {
                    for (int columnindex = 0; columnindex < GridColumns; columnindex++)
                    {
                        Console.Write(grid[rowindex, columnindex]);
                    }
                    Console.WriteLine();
                }
            }
            

            



            //int playerBet = int.Parse(Console.ReadLine());


            //if (playerBet > 10 && playerBet == 0 )
            //{
            //    Console.WriteLine("False bet, try again");
            //}
        }
    }
}
