using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabbCleanCode.Interfaces;

namespace LabbCleanCode
{
     public class Game :  IGame 
    {
        private IUI ui;

        public Game(IUI ui)
        {
            this.ui = ui;
        }

        public string CheckPlayerGuess(string correctNumber, string playerGuess)
        {
            int cows = 0, bulls = 0;
           // if sats på input ifall spelare inte gissar på 4 siffror
           playerGuess += "    "; // if player entered less than 4 chars
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
            //string newGame = "New game:\n";
            while (continueGame)
            {
                string generatedNumber = GenerateCorrectNumbers();

                ui.PutString("New game:\n");
                //comment out or remove next line to play real games!
                ui.PutString("For practice, number is: " + generatedNumber + "\n");
                string? playerGuess = ui.GetString();

                numberOfGuesses++;
                string resultSequenceOfPlayerGuess = CheckPlayerGuess(generatedNumber, playerGuess!);
                ui.PutString(resultSequenceOfPlayerGuess + "\n");
                while (resultSequenceOfPlayerGuess != "BBBB,")
                {
                    numberOfGuesses++;
                    playerGuess = ui.GetString();
                    ui.PutString(playerGuess + "\n");
                    resultSequenceOfPlayerGuess = CheckPlayerGuess(generatedNumber, playerGuess!);
                    ui.PutString(resultSequenceOfPlayerGuess + "\n");
                }
                continueGame = GameOver(numberOfGuesses, continueGame);

            }
            return numberOfGuesses;

        }

        

        public bool GameOver(int numberOfGuesses, bool continueGame)
        {
            ui.PutString("Correct, it took " + numberOfGuesses + " guesses\nContinue?");
            string answer = ui.GetString();
            if (answer != null && answer != "" && answer.Substring(0, 1) == "n")
            {
                continueGame = false;
            }
            return continueGame;
        }
    }
 
}
