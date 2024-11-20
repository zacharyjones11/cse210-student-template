using System;

class Program
{
    static void Main(string[] args)
    {

        Random number_generate = new Random();
        int number_random = number_generate.Next(1, 11);
        
        int guess = 0;

        while (guess != number_random)
        {
            Console.WriteLine("Guess a MAGIC number?");
            guess = int.Parse(Console.ReadLine());

            if (guess < number_random)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number_random)
            {
                Console.WriteLine("Lower");
            }
            else if (guess == number_random)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}