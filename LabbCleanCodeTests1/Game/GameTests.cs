using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabbCleanCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabbCleanCode.Interfaces;

namespace LabbCleanCode.Tests
{
    [TestClass()]
    public class GameTests
    {
        Game? game;
        IUI ui;

        [TestInitialize()]
        public void Initialize()
        {
            this.game = new Game(ui);
        }
        [TestMethod()]
        public void GenerateCorrectNumbersTest()
        {
            Assert.AreNotEqual(0, game?.GenerateCorrectNumbers());
        }

        [TestMethod()]
        public void CheckPlayerGuessTest()
        {
            string correctNumber = "1234";
            string playerGuess = "12";


            Assert.AreNotEqual(4, game?.CheckPlayerGuess(correctNumber, playerGuess));
        }

        [TestMethod()]
        public void GameStartTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GameOverTest()
        {
            Assert.Fail();
        }
    }
}