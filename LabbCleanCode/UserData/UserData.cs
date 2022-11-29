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

        public void SaveUserNameAndGuesses(string name, int numberOfGuesses)
        {
            StreamWriter output = new StreamWriter("result.txt", append: true);
            output.WriteLine(name + "#&#" + numberOfGuesses);
            output.Close();
        }
        public void showTopList()
        {
            StreamReader input = new StreamReader("result.txt");
            List<UserData> results = new List<UserData>();
            string line;
            while ((line = input.ReadLine()) != null)
            {
                string[] nameAndScore = line.Split(new string[] { "#&#" }, StringSplitOptions.None);
                string name = nameAndScore[0];
                int guesses = Convert.ToInt32(nameAndScore[1]);
                UserData pd = new UserData(name, guesses);
                int pos = results.IndexOf(pd);
                if (pos < 0)
                {
                    results.Add(pd);
                }
                else
                {
                    results[pos].Update(guesses);
                }


            }
            results.Sort((p1, p2) => p1.Average().CompareTo(p2.Average()));
            Console.WriteLine("Player   games average");
            foreach (UserData p in results)
            {
                Console.WriteLine(string.Format("{0,-9}{1,5:D}{2,9:F2}", p.Name, p.NGames, p.Average()));
            }
            input.Close();
        }
    }
}
