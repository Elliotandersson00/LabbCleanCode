using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode.Interfaces
{
    public interface IUserData
    {
       public void Update(int guesses);

       public double Average();

       public bool Equals(Object p);

       public int GetHashCode();

        public void SaveUserNameAndGuesses(string name, int numberOfGuesses);

        public void showTopList();


    }
}
