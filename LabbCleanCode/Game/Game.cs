﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabbCleanCode.Interfaces;

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
        public void GameStart()
        {
          
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
