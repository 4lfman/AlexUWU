using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int answer = random.Next(1, 101);
            string guess;
            int intGuess;
            int i = 0;
            bool correct = false;

            while (correct == false)
            {
                i++;
                Console.WriteLine("Guess a number between 1 and 100");
                guess = (Console.ReadLine());
                intGuess = int.Parse(guess);

                if (intGuess < answer)
                {
                    Console.WriteLine("Your guess was to small");
                }
                else if (intGuess > answer)
                {
                    Console.WriteLine("Your guess was to big");
                }
                else if (intGuess == answer)
                {
                    correct = true;
                }
                else
                {
                    Console.WriteLine("You wrote an invalid number");
                }
            }
            Console.WriteLine("You guess was correct! \nThe number was " + answer + "\nYou made " + i + " guesses");
        }
    }
}
