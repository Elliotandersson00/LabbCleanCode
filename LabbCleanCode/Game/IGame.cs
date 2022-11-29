using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode.Game
{
    internal interface IGame
    {
        string CheckPlayerGuess(string goal, string guess);
        string GenerateCorrectNumbers();
        void GameStart();
        bool GameOver(int numberOfGuesses, bool playOn);
    }
}
