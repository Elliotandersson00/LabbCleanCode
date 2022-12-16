using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabbCleanCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabbCleanCode.Interfaces;
using LabbCleanCode;


namespace LabbCleanCode.Tests
{

    [TestClass()]
    public class PlayerDataTests
    {
        IUI ui;

        //[TestMethod]
        //public void SaveUserNameAndGuesses_ValidInput_FileContainsExpectedData()
        //{

        //    IUI ui = new ConsolIO();

        //    string playerName = "Alice";
        //    int numberOfGuesses = 3;

        //    // Arrange
        //    PlayerData playerData = new PlayerData(playerName, numberOfGuesses, ui);


        //    // Act
        //    playerData.SaveUserNameAndGuesses(playerName, numberOfGuesses);

        //    // Assert
        //    string expectedFileContent = "Alice#&#3\n";
        //    string actualFileContent = File.ReadAllText("result.txt");
        //    Assert.AreEqual(expectedFileContent, actualFileContent);
        //}

        [TestMethod()]
        public void PlayerDataTest()
        {
            string playerName = null;
            int numberOfGuesses = 3;

            PlayerData playerData = new PlayerData(playerName, numberOfGuesses, ui);

            Assert.IsNotNull(playerData);
        }
    }
}