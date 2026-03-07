using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Random randomGenerator = new Random();
        int number_magic = randomGenerator.Next(1, 101);

        do
        {
            Console.WriteLine("Informe seu palpite: ");
            string current_guess = Console.ReadLine();
            guess = int.Parse(current_guess);
            if (guess < number_magic)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > number_magic)
            {
                Console.WriteLine("Lower");
            }
        } while (guess != number_magic);

        Console.WriteLine("You guessed it!");
    }
}