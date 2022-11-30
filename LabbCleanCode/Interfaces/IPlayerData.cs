using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode.Interfaces
{
    public interface IPlayerData
    {
       public void UpdatePlayerData(int guesses);

       public double AverageAmountOfGuessesPerGame();

        public bool Equals(Object player);

        public int GetHashCode();

        public void SaveUserNameAndGuesses(string name, int numberOfGuesses);

        public void ShowTopList();


    }
}
