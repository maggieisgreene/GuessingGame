using System;

namespace GuessingGame {
    class Program {
        static void Main (string[] args) {
            Random random = new Random ();
            int secretNumber = random.Next (1, 11);

            for (int i = 0; i < 3; i++) {
                Console.WriteLine ("Guess a number between one and ten!");
                string userGuess = Console.ReadLine ();
                int userGuessInt = int.Parse (userGuess);

                if (userGuessInt == secretNumber) {
                    Console.WriteLine ($"You got it, dude! It was {secretNumber}!");
                    return;
                } else if (userGuessInt != secretNumber && i == 2) {
                    Console.WriteLine ("Game over!");
                    return;
                } else {
                    if (secretNumber > userGuessInt) {
                        Console.WriteLine ("Guess higher!");
                    } else {
                        Console.WriteLine ("Guess lower!");
                    }
                }
            }
        }
    }
}