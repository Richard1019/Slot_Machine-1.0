namespace Slot_Machine_1._0
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
            const int MIN_ROW_NUMBER = 1;
            const int MAX_ROW_NUMBER = 3;
            const string MODE_VERTICAL = "v";
            const string MODE_HORIZONTAL = "h";
            const string MODE_DIAGONAL = "d";
            const string MODE_MIDDLE = "x";

            int playerBet = 0;
            int purse = 20;

            Console.WriteLine("\nWanna play some Slot machine..? Of course you do..");
            Console.WriteLine("\nSo, every horizontal and vertical line doubles your bet, every line across triples it, and the middle line instantly adds " + MAX_BET + " dollar");
            //Console.WriteLine("You get the jackpot if all lines AND rows are the same!");
            Console.WriteLine("Got 20 dollars in your purse to get you going!");

            while (purse > 0)
            {
                Console.WriteLine("\nNow decide which grids you wanna play!");
                Console.WriteLine("v for vertical, h for horizontal, d is for diagonal and x is for the middle.");
                string playerLine = Console.ReadLine().ToLower();

                List<string> playersGridchoice = new List<string> { MODE_VERTICAL, MODE_HORIZONTAL, MODE_DIAGONAL, MODE_MIDDLE };

                while (!playersGridchoice.Contains(playerLine))
                {
                    Console.WriteLine("Invalid Input. Please use the assigned letters.");
                    playerLine = Console.ReadLine().ToLower();
                }

                Console.WriteLine("Alright, go on, place your bet now! From " + MIN_BET + " dollar to " + MAX_BET);
                bool success = int.TryParse(Console.ReadLine(), out playerBet);

                while (!success || playerBet < MIN_BET || playerBet > MAX_BET)
                {
                    if (!success)
                    {
                        Console.WriteLine("Invalid input, try again");
                    }
                    else if (playerBet < MIN_BET || playerBet > MAX_BET)
                    {
                        Console.WriteLine($"Invalid bet. Your bet must be between {MIN_BET} and {MAX_BET}.");
                    }
                    success = int.TryParse(Console.ReadLine(), out playerBet);
                }

                Console.WriteLine("Good. Now let`s spin that thing.");
                int[,] grid = new int[GRID_ROWS, GRID_COLUMNS];
                Random randomNumber = new Random();

                purse -= playerBet;

                for (int rowindex = 0; rowindex < GRID_ROWS; rowindex++)
                {
                    for (int columnindex = 0; columnindex < GRID_COLUMNS; columnindex++)
                    {
                        grid[rowindex, columnindex] = randomNumber.Next(MIN_ROW_NUMBER, MAX_ROW_NUMBER);
                        grid[rowindex, columnindex] = 1;
                    }
                }

                for (int rowindex = 0; rowindex < GRID_ROWS; rowindex++)
                {
                    for (int columnindex = 0; columnindex < GRID_COLUMNS; columnindex++)
                    {
                        Console.Write(grid[rowindex, columnindex] + " ");
                    }
                    Console.WriteLine();
                }

                bool win = false;

                if (playerLine == MODE_MIDDLE)
                {
                    int middleLine = GRID_ROWS / 2;
                    win = true;
                    for (int columnindex = 0; columnindex < GRID_COLUMNS; columnindex++)
                    {
                        if (grid[middleLine, 0] != grid[middleLine, columnindex])
                        {
                            win = false;
                            break;
                        }
                    }

                    if (win)
                    {
                        Console.WriteLine("Good job. You have won " + MAX_BET);
                        purse += MAX_BET;
                        Console.WriteLine("Your purse now is " + purse);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, no luck this time..");
                        Console.WriteLine("Your purse is now " + purse);
                    }
                }

                if (playerLine == MODE_HORIZONTAL)
                {
                    win = true;
                    for (int rowindex = 0; rowindex < GRID_ROWS; rowindex++)
                    {
                        for (int colIndex = 0; colIndex < GRID_COLUMNS; colIndex++)
                        {
                            if (grid[rowindex, colIndex] != grid[rowindex, 0])
                            {
                                win = false;
                                break;
                            }
                        }
                    }

                    if (win)
                    {
                        purse += playerBet * 2;
                        Console.WriteLine("You won horizontally! Your purse is now: " + purse);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, no luck this time..");
                        Console.WriteLine("Your purse is now " + purse);
                    }
                }

                if (playerLine == MODE_VERTICAL)
                {
                    win = true;
                    for (int columnindex = 0; columnindex < GRID_COLUMNS; columnindex++)
                    {
                        for (int rowindex = 0; rowindex < GRID_ROWS; rowindex++)
                        {
                            if (grid[rowindex, columnindex] != grid[0, columnindex])
                            {
                                win = false;
                                break;
                            }
                        }
                    }

                    if (win)
                    {
                        purse += playerBet * 2;
                        Console.WriteLine("You won vertically! Your purse is now: " + purse);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, no luck this time..");
                        Console.WriteLine("Your purse is now " + purse);
                    }
                }

                
                if (playerLine == MODE_DIAGONAL)
                {
                    win = true;
                    if (grid[0, 0] != grid[1, 1] || grid[1, 1] != grid[2, 2] || grid[0, 2] != grid[1, 1] || grid[1, 1] != grid[2, 0])
                    {
                        win = false;
                    }

                    if (win)
                    {
                        purse += playerBet * 3;
                        Console.WriteLine("You won diagonally! Your purse is now: " + purse);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, no luck this time..");
                        Console.WriteLine("Your purse is now " + purse);
                    }
                }
                if (grid[0, 0] == grid[0, 1] && grid[0, 1] == grid[0, 2] && grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2] && grid[2, 0] == grid[2, 1] && grid[2, 1] == grid[2, 2])
                {
                    Console.WriteLine("Congratulations! You've hit the jackpot! You've won " + JACKPOT + " dollars!");
                    purse += JACKPOT;
                    Console.WriteLine("Your purse now is " + purse);
                }

                if (purse <= 0)
                {
                    Console.WriteLine("Sorry, you're out of money! Game over.");
                }
            }
        }
    }
}

