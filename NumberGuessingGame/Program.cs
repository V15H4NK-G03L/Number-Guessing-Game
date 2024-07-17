﻿using System;

namespace NumberGuessingGame
{

    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the Number Guessing Game! :)");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");

            while(!isCorrectGuess)
            {
                Console.WriteLine("Please enter the number you guessed :");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if(guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("Correct Guess!!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Congratulations, You have won the game!");
            Console.ReadKey();
        }
    }
}