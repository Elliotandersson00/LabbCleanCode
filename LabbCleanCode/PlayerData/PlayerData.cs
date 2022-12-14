using LabbCleanCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode
{
    public class PlayerData : Game, IPlayerData 
    {
            public string PlayerName { get; private set; }
            public int NumberOfGames { get; private set; }

            int totalGuesses;

            private IUI ui;
            public Game game;

            public PlayerData(string playerName, int guesses, IUI ui) : base(playerName, guesses, ui)
            {
                this.PlayerName = playerName;
                NumberOfGames = 1;
                totalGuesses = guesses;
                this.ui = ui;
            }


        public void UpdatePlayerData(int guesses)
            {
                totalGuesses += guesses;
                NumberOfGames++;
            }

            public double AverageAmountOfGuessesPerGame()
            {
                return (double)totalGuesses / NumberOfGames;
            }

       
        public override bool Equals(Object player)
        {
            return PlayerName.Equals(((PlayerData)player).PlayerName);
        }


        public override int GetHashCode()
        {
            return PlayerName.GetHashCode();
        }

        public void SaveUserNameAndGuesses(string name, int numberOfGuesses)
        {
            StreamWriter output = new StreamWriter("result.txt", append: true);
            output.WriteLine(name + "#&#" + numberOfGuesses);
            output.Close();
        }
        public void ShowTopList()
        {
            StreamReader input = new StreamReader("result.txt");
            List<PlayerData> results = new List<PlayerData>();
            //separets the name and score inside the .txt document.
            string playerNameAndScoreSplitter;
            while ((playerNameAndScoreSplitter = input.ReadLine()) != null)
            {
                
                string[] nameAndScore = playerNameAndScoreSplitter.Split(new string[] { "#&#" }, StringSplitOptions.None);
                string playerName = nameAndScore[0];
                int totalGuesses = Convert.ToInt32(nameAndScore[1]);
                PlayerData playerData = new PlayerData(playerName, totalGuesses, ui);
                int pos = results.IndexOf(playerData);
                if (pos < 0)
                {
                    results.Add(playerData);
                }
                else
                {
                    results[pos].UpdatePlayerData(totalGuesses);
                }


            }
            results.Sort((p1, p2) => p1.AverageAmountOfGuessesPerGame().CompareTo(p2.AverageAmountOfGuessesPerGame()));
            ui.PutString("Player   games average");
            foreach (PlayerData p in results)
            {
                ui.PutString(string.Format("{0,-9}{1,5:D}{2,9:F2}", p.PlayerName, p.NumberOfGames, p.AverageAmountOfGuessesPerGame()));
            }
            input.Close();
        }
      
    }
}
