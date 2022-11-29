using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode.UserData
{
    internal class UserData
    {
            public string Name { get; private set; }
            public int NGames { get; private set; }
            int totalGuess;


            public UserData(string name, int guesses)
            {
                this.Name = name;
                NGames = 1;
                totalGuess = guesses;
            }

            public void Update(int guesses)
            {
                totalGuess += guesses;
                NGames++;
            }

            public double Average()
            {
                return (double)totalGuess / NGames;
            }


            public override bool Equals(Object p)
            {
                return Name.Equals(((UserData)p).Name);
            }


        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public void SaveUserStats(string name, int numberOfGuesses)
        {
            StreamWriter output = new StreamWriter("result.txt", append: true);
            output.WriteLine(name + "#&#" + numberOfGuesses);
            output.Close();
        }
    }
}
