using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
