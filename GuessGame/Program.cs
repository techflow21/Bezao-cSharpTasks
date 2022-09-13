namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int guess;
            int guesses;
            int number;
            int min = 1;
            int max = 100;
            string response;
            int [] guessesInputs = new int[] {};

            while (playAgain)
            {
                guess = 0;
                guesses = 0;

                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guessesInputs = guessesInputs.Append(guess).ToArray();
                    int[] formatedInputs = guessesInputs.Distinct().ToArray();
                    guesses = formatedInputs.Length;
                }
                Console.WriteLine("You win!");
                Console.WriteLine("Number: " + number);
                Console.WriteLine("Number of tries: " + guesses);

                Console.WriteLine("Will you like to play again (Y/N) ? ");
                response = Console.ReadLine().ToUpper();
               

                if (response == "Y")
                {
                    playAgain = true;
                    guessesInputs = new int[] {};
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Press any key to exit!");

            Console.ReadKey();
        }
    }
}
