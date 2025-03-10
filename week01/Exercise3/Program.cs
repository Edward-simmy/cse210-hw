using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
    
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        int numGuesses = 0;


        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("No this is too low, Guess Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Almost there, Try to Guess Lower");
            }
            else
            {
                Console.WriteLine("You guessed it! you took " + numGuesses + "guesses" );
            }
            string Response;
            while (numGuesses > 6 )
            
            {
                Console.Write("You Guessed more then 6 times wrongly. GAME OVER!");
            }   
                
            do  
            {
                Console.Write("Do you wish to start again?  ");
                Response = Console.ReadLine();

            }

            while (Response == "yes");

            {
                Console.Write("What is your guess?"  );
            }  

        }                    
    }
}