using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabbCleanCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabbCleanCode.Interfaces;
using System.Text.RegularExpressions;

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

            // Regex string checks for 4 uniqe numbers. 
            string expectedRegex = "^(?!.(.).\\1)\\d{4}$"; // four digits


            string result = game.GenerateCorrectNumbers();


            Assert.IsTrue(Regex.IsMatch(result, expectedRegex));

        }

        [TestMethod()]
        public void GetBullsAndCowsTest()
        {
            string correctNumber = "1234";
            string playerGuess = "1234";
            string expected = "BBBB,";
            string actual = game.GetBullsAndCows(correctNumber, playerGuess);


            Assert.AreEqual(expected, actual);

            correctNumber = "1234";
            playerGuess = "1279";
            expected = "BB,";
            actual = game.GetBullsAndCows(correctNumber, playerGuess);


            Assert.AreEqual(expected, actual);

            correctNumber = "1234";
            playerGuess = "1247";
            expected = "BBC,";
            actual = game.GetBullsAndCows(correctNumber, playerGuess);


            Assert.AreEqual(expected, actual);

        }

        
        }
}

