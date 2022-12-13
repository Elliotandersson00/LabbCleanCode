using System;
using System.IO;
using System.Collections.Generic;
using LabbCleanCode;
using LabbCleanCode.Interfaces;
using LabbCleanCode.ConsolIO;

namespace MooGame
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            IUI ui = new ConsolIO();
            Game game = new Game(ui);

            Console.WriteLine("Enter your user name:\n");
            string playerName = Console.ReadLine();

            int numberOfGuesses = game.GameStart();
            

            PlayerData userData = new PlayerData(playerName, numberOfGuesses, ui);
            userData.SaveUserNameAndGuesses(playerName, numberOfGuesses);

            userData.ShowTopList();
        }
    }   
}

// provar pusha min egen branch