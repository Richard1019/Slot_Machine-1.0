﻿namespace Slot_Machine_1._0
{
    internal class Program
    {
        private static int columnindex;

        static void Main(string[] args)
        {
            const int GRID_ROWS = 3;
            const int GRID_COLUMNS = 3;
            const int MIN_BET = 1;
            const int MAX_BET = 10;
            const int JACKPOT = 50;
            const string MODE_VERTICAL = "v";
            const string MODE_HORIZONTAL = "h";
            const string MODE_DIAGONAL = "d";
            const string MODE_MIDDLE = "x";


            int playerBet = 0;
            int purse = 20;

            Console.WriteLine("\nWanna play some Slot machine..? Of course you do..");
            Console.WriteLine("\nSo, every horizontal and vertical line doubles your bet, every line across triples it, and the middle line is jackpot, which instantly adds" + JACKPOT);
            Console.WriteLine("Got 20 dollars in your purse to get you going!");

            Console.WriteLine("\nNow decide which grids you wanna play!");
            Console.WriteLine("v for vertical, h for horizontal, d is for diagonal and x is for the middle.");

            string playerLine = Console.ReadLine().ToLower();

            List<string> playersGridchoice = [MODE_VERTICAL, MODE_HORIZONTAL, MODE_DIAGONAL, MODE_MIDDLE];


            while (!playersGridchoice.Contains(playerLine))
            {
                Console.WriteLine("Invalid Input. Please use the assigned letters.");
                playerLine = Console.ReadLine().ToLower();
            }


            Console.WriteLine("Alright, go on, place your bet now! From " + MIN_BET + " dollar to " + MAX_BET);



            bool success = int.TryParse(Console.ReadLine(), out playerBet);

            while (!success || playerBet <= 0 || playerBet > MAX_BET)

            {
                if (!success)
                {
                    Console.WriteLine("Invalid input, try again");
                }
                else if (playerBet <= 0 || playerBet > MAX_BET)
                {
                    Console.WriteLine($"Invalid bet. Your bet must be between {MIN_BET} and {MAX_BET}.");
                }
                success = int.TryParse(Console.ReadLine(), out playerBet);

            }

            Console.WriteLine("Good. Now let`s spin that thing.");
            int[,] grid = new int[GRID_ROWS, GRID_COLUMNS];
            Random randomNumber = new Random();

            for (int rowindex = 0; rowindex < GRID_ROWS; rowindex++)
            {
                for (int columnindex = 0; columnindex < GRID_COLUMNS; columnindex++)
                {
                    grid[rowindex, columnindex] = randomNumber.Next(1, 3);
                    //grid[rowindex, columnindex] = 1;
                }
            }

            for (int rowindex = 0; rowindex < GRID_ROWS; rowindex++)
            {
                for (int columnindex = 0; columnindex < GRID_COLUMNS; columnindex++)
                {
                    Console.Write(grid[rowindex, columnindex]);
                }
                Console.WriteLine();
            }
            int middleLine = GRID_ROWS / 2;
            bool win = true;
            // 2 1 2 N/2 -> 1.5 ->1 5/2->2.5->2 N is the size of the grid
            // 2 2 2
            // 1 2 1

            //1 2 2 1 3
            //1 2 1 2 3
            //1 3 2 2 1 grid[middleLIne,0]-> grid[middleLIne,j] j=0,j=1,j=2
            //2 1 3 2 2 
            //3 2 3 1 3
            if (playerLine == MODE_MIDDLE)
            {

                for (int columnindex = 0; columnindex < GRID_ROWS; columnindex++)
                {
                    if (grid[middleLine, 0] != grid[middleLine, columnindex])
                    {
                        win = false;
                        Console.WriteLine("No luck this time..");
                    }
                }

                if (win)
                {
                    Console.WriteLine("Good job. You have won " + JACKPOT);
                    Console.WriteLine("Your purse now is " + (purse + JACKPOT));
                }
            }

            if (playerLine == MODE_HORIZONTAL)
            {
                win = true;

                for (int rowindex = 0; rowindex < GRID_ROWS; rowindex++)
                {

                    if (grid[rowindex, columnindex] != grid[rowindex, 0])
                    {
                        win = false;
                        Console.WriteLine("Sorry, no luck this time..");
                    }
                }

                if (win)
                {
                    purse += playerBet * 2;
                    Console.WriteLine("You won horizontally! Your purse is now: " + purse);
                }

            }


            if (playerLine == MODE_VERTICAL)
            {

            }
            if (playerLine == MODE_DIAGONAL)
            {
                // grid[1, 1] == grid[0, 0] && grid[1, 1] == grid[2, 2]
            }

            //check if thw user won or not utilize win variable

        }
    }
}

