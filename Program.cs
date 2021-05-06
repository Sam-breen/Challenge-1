using System;

namespace Challenge
{
    class Program
    {
        static void diceroll()
        {   
            Random rd = new Random();
            int randomNumber = rd.Next(1,7);
            Console.WriteLine(randomNumber);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to roll the dice?");
            string answer = Console.ReadLine();
            int counter = 0;

            if (answer == "yes")
            {
                diceroll();
                counter = counter + 1;

                Console.WriteLine("Do you want to roll the dice?");
                string answer2 = Console.ReadLine();

                if (answer2 == "yes") 
                {
                    diceroll();
                    counter = counter + 1;
                }

            }

            else if (answer == "no") 
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(1);
            }


            int[] diceCount = new int[]{counter};
            Console.WriteLine("dice rolls total = " + counter);

           
        }
    }
}
