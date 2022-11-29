using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabbCleanCode.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode.Game.Tests
{
    [TestClass()]
    public class GameTests
    {
        Game? game;
        [TestInitialize()]
        public void Initialize()
        {
            this.game = new Game();
        }
        [TestMethod()]
        public void GenerateCorrectNumbersTest()
        {
            Assert.AreNotEqual(0, game?.GenerateCorrectNumbers());
        }
    }
}