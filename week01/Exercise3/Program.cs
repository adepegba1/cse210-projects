using System;

class Program
{
    static void Main(string[] args)
    {
        string replay;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int count = 1;

            Console.Write("What your guess: ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            while (guessNumber != magicNumber)
            {
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
                Console.Write("What your guess: ");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                count++;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"The number of time you play is {count}");
            Console.WriteLine("Do you want to play again: ");
            replay = Console.ReadLine();

        } while (replay == "yes");
    }
}