﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode.Interfaces
{
    internal interface IGame
    {
        string CheckPlayerGuess(string correctNumber, string guess);
        string GenerateCorrectNumbers();
        void GameStart();
        bool GameOver(int numberOfGuesses, bool continueGame);
    }
}
