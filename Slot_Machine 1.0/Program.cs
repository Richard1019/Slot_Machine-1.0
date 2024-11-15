namespace Slot_Machine_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GRID_ROWS = 3;
            const int GRID_COLUMNS = 3;
            const int MIN_BET = 1;
            const int MAX_BET = 10;


            int Playerbet = 0;
            int Purse = 20;

            Console.WriteLine("\nWanna play some Slot machine..? Of course you do..");
            Console.WriteLine("\nSo, every horizontal and vertical line doubles your bet, every line across triples it, and the middle line is jackpot.");
            Console.WriteLine("Got 20 dollars in your purse to get you going!");

            Console.WriteLine("\nNow decide which grids you wanna play!");
            Console.WriteLine("v for vertical, h for horizontal, d is for diagonal and x is for the middle.");

            string playerLine = Console.ReadLine().ToLower();

            List<string> playersGridchoice = ["v", "h", "d", "x"];


            while (!playersGridchoice.Contains(playerLine))
            {
                Console.WriteLine("Invalid Input. Please use the assigned letters.");
                playerLine = Console.ReadLine();
            }


            Console.WriteLine("Alright, go on, place your bet now! From " + MIN_BET + " dollar to " + MAX_BET);


           
            bool success = int.TryParse(Console.ReadLine(), out Playerbet);

            while (!success)

            {
                //while (Playerbet > MAX_BET)
                //{
                Console.WriteLine("False bet, try again");
                //int playerBet = Convert.ToInt32(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out Playerbet);
                

                //}


            }
            while (Playerbet <= MAX_BET)
            {
                Console.WriteLine("Good. Now let`s spin that thing.");
                int[,] grid = new int[GRID_ROWS, GRID_COLUMNS];
                Random randomNumber = new Random();

                for (int rowindex = 0; rowindex < GRID_ROWS; rowindex++)
                {
                    for (int columnindex = 0; columnindex < GRID_COLUMNS; columnindex++)
                    {
                        grid[rowindex, columnindex] = randomNumber.Next(1, 3);
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
            }

        }
    }
}

