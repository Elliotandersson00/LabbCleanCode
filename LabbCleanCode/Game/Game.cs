using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabbCleanCode.Interfaces;

namespace LabbCleanCode
{
     public class Game : IGame 
    {
        private IUI ui;

        public Game(IUI ui)
        {
            this.ui = ui;
        }

       

        public string GetBullsAndCows(string correctNumber, string playerGuess)   //Testad
        {
            int cows = 0, bulls = 0;

            if (playerGuess.Length < 4)
            {
                playerGuess = playerGuess.PadRight(4, ' ');
            }

           
            for (int i = 0; i < 4; i++)
            {
                if (correctNumber[i] == playerGuess[i])
                {
                    bulls++;
                }
                else if (correctNumber.Contains(playerGuess[i]))
                {
                    cows++;
                }
            }

           
            return new string('B', bulls) + "," + new string('C', cows);
        }

        public string GenerateCorrectNumbers() // Testad
        {

            string goal = "";
            try
            {
            Random randomGenerator = new Random();
                for (int i = 0; i < 4; i++)
                {
                    int random;
                    string randomDigit;
                    do
                    {
                        random = randomGenerator.Next(10);
                        randomDigit = "" + random;
                    }
                    while (goal.Contains(randomDigit));
                    goal = goal + randomDigit;
                    
                }

            }
            catch (Exception e)
            {

                ui.ExceptionStringHandler("Could not generate a new number.", e);
                
            }
            return goal;
        }
       
        public void GameStart()
        {
          
            string playerName;
            int numberOfGuesses = 0;
            bool continueGame = true;

            ui.PutString("Enter your user name:\n");
            playerName = ui.GetString();
            while (continueGame)
            {
                string generatedNumber = GenerateCorrectNumbers();

                ui.PutString("New game:\n");
                //comment out or remove next line to play real games!
                ui.PutString("For practice, number is: " + generatedNumber + "\n");
                string? playerGuess = ui.GetString();

                numberOfGuesses = CheckPlayerGuess(generatedNumber,playerGuess,numberOfGuesses);
                continueGame = GameOver(numberOfGuesses, continueGame);
            }
            SaveAndShowPlayerData(playerName, numberOfGuesses);
        }

        public void SaveAndShowPlayerData(string playerName, int numberOfGuesses)
        {
            try
            {
                PlayerData playerData = new PlayerData(playerName, numberOfGuesses, ui);
                playerData.SaveUserNameAndGuesses(playerName, numberOfGuesses);
                playerData.ShowTopList();


            }
            catch (Exception e)
            {

                ui.ExceptionStringHandler("Could not create a new user", e);


            }
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

        public int CheckPlayerGuess(string generatedNumber, string playerGuess, int numberOfGuesses)
        {
            string resultSequenceOfPlayerGuess = GetBullsAndCows(generatedNumber, playerGuess!);
            ui.PutString(resultSequenceOfPlayerGuess + "\n");
            numberOfGuesses++;
            while (resultSequenceOfPlayerGuess != "BBBB,")
            {
                numberOfGuesses++;
                playerGuess = ui.GetString();
                ui.PutString(playerGuess + "\n");
                resultSequenceOfPlayerGuess = GetBullsAndCows(generatedNumber, playerGuess!);
                ui.PutString(resultSequenceOfPlayerGuess + "\n");
                
            }
            return numberOfGuesses;
        }
    }
}
