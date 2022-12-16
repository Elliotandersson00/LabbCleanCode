﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            IUI ui = new ConsolIO();

            string playerName = null;
            int numberOfGuesses = 3;

            PlayerData playerData = new PlayerData(playerName, numberOfGuesses, ui);
            
            Assert.IsNotNull(playerData);

        }

        [TestMethod()]
        public void ShowTopListTest()
        {
            IUI ui = new ConsolIO();

            string playerName = "kalle";
            int numberOfGuesses = 3;

            PlayerData playerData = new PlayerData(playerName, numberOfGuesses, ui);

            
            try
            {
                playerData.ShowTopList();
                Assert.IsTrue(true);
            }
            catch (Exception)
            {

                Assert.IsTrue(false);
            }
        
     
        }

        //[TestMethod]
        //public void ReadFiles()
        //{
        //    try
        //    {
        //        Read();
        //        return; // indicates success
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.Fail(ex.Message);
        //    }
        //}
    }
}