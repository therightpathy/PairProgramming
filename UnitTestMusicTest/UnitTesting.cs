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
                _music.Title = null;
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Title skal være længere end 0 tegn og være Gyldig", e.Message);
            }
        }

        [TestMethod]
        public void TestArtist()
        {
            Assert.AreEqual("Rusky", _music.Artist);
            _music.Artist = "Riskian";
            Assert.AreEqual("Riskian", _music.Artist);
            try
            {
                _music.Artist = null;
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Artist skal være længere end 2 tegn og være Gyldig", e.Message);
            }
        }

        [TestMethod]
        public void TestDuration()
        {
            Assert.AreEqual(2.14, _music.Duration);
            _music.Duration = 3.65;
            Assert.AreEqual(3.65, _music.Duration);
            try
            {
                _music.Duration = 1001;
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Duration skal være mellem 0 og 1000", e.Message);
            }
        }

        [TestMethod]
        public void TestYearOfPub()
        {
            Assert.AreEqual(1991, _music.YearOfPub);
            _music.YearOfPub = 1995;
            Assert.AreEqual(1995, _music.YearOfPub);
            try
            {
                _music.Duration = 1849;
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Music kan kun tilføjes efter det er udgivet", e.Message);
            }
        }
    }
}
