using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairProgramming;

namespace UnitTestMusicTest
{
    [TestClass]
    public class UnitTesting
    {
        private Music _music;

        //Initializing test testing all methods listed below 
        [TestInitialize]
        public void BeforeTest()
        {
            _music = new Music("Rave", "Rusky", 2.50, 1992, "Universal", "Rock");
        }

        [TestMethod]
        public void TestTitle()
        {
            Assert.AreEqual("Rave", _music.Title);
            _music.Title = "Reverend";
            Assert.AreEqual("Reverend", _music.Title);
            try
            {
                _music.Title = "J";
            }
            catch (Exception e)
            {
                Assert.AreEqual("Title is shorter than two characters", e.Message);
            }
        }

    }
}
