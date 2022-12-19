using System;
using System.IO;
using System.Collections.Generic;
using LabbCleanCode;
using LabbCleanCode.Interfaces;


namespace MooGame
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            IUI ui = new ConsolIO();
            Game game = new Game(ui);
            game.GameStart();
            
        }
    }   
}
