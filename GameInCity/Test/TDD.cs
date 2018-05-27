using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameInCity;

namespace Test
{
    [TestClass]
    public class TDD
    {
        [TestMethod]
        public void TestMethod_Load()
        {
            Game game = new Game();
            bool rezult = game.Load();
            Assert.AreEqual(true, rezult);
        }
        [TestMethod]
        public void TestMethod_NameGamer1()
        {
            Game game = new Game();
            game.SetNameGamer1("123");
            string rezult = game.GetNameGamer1();
            Assert.AreEqual("123", rezult);
        }
        [TestMethod]
        public void TestMethod_Pause()
        {
            Game game = new Game();
            game.SetPause(10);
            int rezult = game.GetPause();
            Assert.AreEqual(20, rezult);
        }
        [TestMethod]
        public void TestMethod_NameGamer2()
        {
            Game game = new Game();
            game.SetNameGamer2("345");
            string rezult = game.GetNameGamer2();
            Assert.AreEqual("345", rezult);
        }
        [TestMethod]
        public void TestMethod_CurrentGamer_1()
        {
            Game game = new Game();
            int rezult = game.GetCurrentGamer();
            Assert.AreEqual(1, rezult);
        }
    }
}
