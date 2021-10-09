using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;
using System;

namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_and_del()
        {
            //arrange
            int x = 20;
            int y = 10;
            int expected = 10;

            //action
            Checkapp c = new Checkapp();
            int actualy =  c.Schet(x, y)/2;
            actualy *= 2;

            //assert
            Assert.AreEqual(expected, actualy); // expected - что должно быть, actualy - что получилось
        }
    }
}
