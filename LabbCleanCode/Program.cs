using System;
using System.IO;
using System.Collections.Generic;
using LabbCleanCode.PlayerData;
using LabbCleanCode.Game;
using LabbCleanCode.Interfaces;

namespace MooGame
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Game game = new Game();

            Console.WriteLine("Enter your user name:\n");
            string playerName = Console.ReadLine();

            int numberOfGuesses = game.GameStart();

            PlayerData userData = new PlayerData(playerName, numberOfGuesses);
            userData.SaveUserNameAndGuesses(playerName, numberOfGuesses);

            userData.ShowTopList();
        }
    }   
}

// provar pusha min egen branch