namespace Slot_Machine_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GRIDROWS = 3;
            const int GRIDCOLUMNS = 3;
            const int MINBET = 1;
            const int MAXBET = 10;


            int Playerbet = 0;
            int Purse = 20;

            Console.WriteLine("\nWanna play some Slot machine..? Of course you do..");
            Console.WriteLine("\nSo, every horizontal and vertical line doubles your bet, every line across triples it, and the middle line is jackpot.");
            Console.WriteLine("Got 20 dollars in your purse to get you going!");

            Console.WriteLine("\nNow decide which grids you wanna play!");
            Console.WriteLine("V for vertical, H for horizontal, D is for diagonal and X is for the middle.");
            //Console.WriteLine("\n");

            string playerLine = Console.ReadLine(); //k

            List<string> playersGridchoice = ["v", "h", "d", "x"];


            while (!playersGridchoice.Contains(playerLine))
            {
                Console.WriteLine("Invalid Input. Please use the assigned letters.");
                playerLine = Console.ReadLine();
            }


            Console.WriteLine("Alright, go on, place your bet now! From one dollar to ten!");
           

            int playerBet = Convert.ToInt32(Console.ReadLine()); //parse

            while (playerBet > MAXBET)
            {
                Console.WriteLine("False bet, try again");
                playerBet = Convert.ToInt32(Console.ReadLine());

            }

            if (playerBet< MAXBET)
            {

                int[,] grid = new int[GRIDROWS, GRIDCOLUMNS];
                Random randomNumber = new Random();


                for (int rowindex = 0; rowindex < GRIDROWS; rowindex++)
                {
                    for (int columnindex = 0; columnindex < GRIDCOLUMNS; columnindex++)
                    {
                        grid[rowindex, columnindex] = randomNumber.Next(1, 3);
                    }
                }

                for (int rowindex = 0; rowindex < GRIDROWS; rowindex++)
                {
                    for (int columnindex = 0; columnindex < GRIDCOLUMNS; columnindex++)
                    {
                        Console.Write(grid[rowindex, columnindex]);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}

