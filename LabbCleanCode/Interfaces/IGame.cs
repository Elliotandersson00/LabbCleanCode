using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode.Interfaces
{
    public interface IGame
    {
        void GameStart();
        public bool GameOver(int numberOfGuesses, bool continueGame);
    }
}
