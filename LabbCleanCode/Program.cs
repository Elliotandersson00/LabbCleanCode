using System;
using System.IO;
using System.Collections.Generic;
using LabbCleanCode.UserData;
using LabbCleanCode.Game;

namespace MooGame
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            
            Game game = new Game();
          

            bool playOn = true;
            Console.WriteLine("Enter your user name:\n");
            string name = Console.ReadLine();

            while (playOn)
            {
                string goal = game.GenerateCorrectNumbers();


                Console.WriteLine("New game:\n");
                //comment out or remove next line to play real games!
                Console.WriteLine("For practice, number is: " + goal + "\n");
                string guess = Console.ReadLine();

                int nGuess = 1;
                string bbcc = game.CheckPlayerGuess(goal, guess);
                Console.WriteLine(bbcc + "\n");
                while (bbcc != "BBBB,")
                {
                    nGuess++;
                    guess = Console.ReadLine();
                    Console.WriteLine(guess + "\n");
                    bbcc = game.CheckPlayerGuess(goal, guess);
                    Console.WriteLine(bbcc + "\n");
                }

                //kan man skapa en tom user utan namn, skicka in name och guess i 
                //functionen under och sedan spara ner den i UserData?
                UserData userData = new UserData(name, nGuess);
                userData.SaveUserNameAndGuesses(name, nGuess);

                userData.showTopList();

                playOn = game.GameOver(nGuess,playOn);

            }
        }
           
    }   
}

// provar pusha min egen branch