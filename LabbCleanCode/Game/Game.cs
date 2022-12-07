using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabbCleanCode.Interfaces;
using LabbCleanCode.PlayerData;

namespace LabbCleanCode.Game
{
     public class Game : IGame 
    {
        public string CheckPlayerGuess(string correctNumber, string playerGuess)
        {
            int cows = 0, bulls = 0;
           // if sats på input ifall spelare inte gissar på 4 siffror
           playerGuess += "    ";     // if player entered less than 4 chars
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (correctNumber[i] == playerGuess[j])
                    {
                        if (i == j)
                        {
                            bulls++;
                        }
                        else
                        {
                            cows++;
                        }
                    }
                }
            }
            return "BBBB".Substring(0, bulls) + "," + "CCCC".Substring(0, cows);
        }
        public string GenerateCorrectNumbers()
        {
            Random randomGenerator = new Random();
            string goal = "";
            for (int i = 0; i < 4; i++)
            {
                int random = randomGenerator.Next(10);
                string randomDigit = "" + random;
                while (goal.Contains(randomDigit))
                {
                    random = randomGenerator.Next(10);
                    randomDigit = "" + random;
                }
                goal = goal + randomDigit;
            }
            return goal;
        }
        public int GameStart()
        {

            int numberOfGuesses = 0;
            bool continueGame = true;

            while (continueGame)
            {
                string generatedNumber = GenerateCorrectNumbers();

                Console.WriteLine("New game:\n");
                //comment out or remove next line to play real games!
                Console.WriteLine("For practice, number is: " + generatedNumber + "\n");
                string? playerGuess = Console.ReadLine();

                numberOfGuesses++;
                string resultSequenceOfPlayerGuess = CheckPlayerGuess(generatedNumber, playerGuess!);
                Console.WriteLine(resultSequenceOfPlayerGuess + "\n");
                while (resultSequenceOfPlayerGuess != "BBBB,")
                {
                    numberOfGuesses++;
                    playerGuess = Console.ReadLine();
                    Console.WriteLine(playerGuess + "\n");
                    resultSequenceOfPlayerGuess = CheckPlayerGuess(generatedNumber, playerGuess!);
                    Console.WriteLine(resultSequenceOfPlayerGuess + "\n");
                }
                continueGame = GameOver(numberOfGuesses, continueGame);

            }
            return numberOfGuesses;

        }

        

        public bool GameOver(int numberOfGuesses, bool continueGame)
        {
            Console.WriteLine("Correct, it took " + numberOfGuesses + " guesses\nContinue?");
            string answer = Console.ReadLine();
            if (answer != null && answer != "" && answer.Substring(0, 1) == "n")
            {
                continueGame = false;
            }
            return continueGame;
        }
    }
 
}
