using System;
using System.IO;
using System.Collections.Generic;
using LabbCleanCode.PlayerData;
using LabbCleanCode.Game;

namespace MooGame
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            
            Game game = new Game();
          

            bool continueGame = true;
            Console.WriteLine("Enter your user name:\n");
            string playerName = Console.ReadLine();

            while (continueGame)
            {
                string generatedNumber = game.GenerateCorrectNumbers();


                Console.WriteLine("New game:\n");
                //comment out or remove next line to play real games!
                Console.WriteLine("For practice, number is: " + generatedNumber + "\n");
                string ?playerGuess = Console.ReadLine();

                int numberOfGuesses = 1;
                string resultSequenceOfPlayerGuess = game.CheckPlayerGuess(generatedNumber, playerGuess!);
                Console.WriteLine(resultSequenceOfPlayerGuess + "\n");
                while (resultSequenceOfPlayerGuess != "BBBB,")
                {
                    numberOfGuesses++;
                    playerGuess = Console.ReadLine();
                    Console.WriteLine(playerGuess + "\n");
                    resultSequenceOfPlayerGuess = game.CheckPlayerGuess(generatedNumber, playerGuess!);
                    Console.WriteLine(resultSequenceOfPlayerGuess + "\n");
                }

                //kan man skapa en tom user utan namn, skicka in name och guess i 
                //functionen under och sedan spara ner den i UserData?
                PlayerData userData = new PlayerData(playerName, numberOfGuesses);
                userData.SaveUserNameAndGuesses(playerName, numberOfGuesses);

                userData.showTopList();

                continueGame = game.GameOver(numberOfGuesses,continueGame);

            }
        }   
    }   
}

// provar pusha min egen branch