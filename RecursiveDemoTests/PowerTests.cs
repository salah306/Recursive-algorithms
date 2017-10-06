using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RecursiveDemo.Tests
{
    [TestClass()]
    public class PowerTests
    {
        [TestMethod()]
        public void CopmutePower_3_raised_to_power_0()
        {
            Assert.AreEqual( Math.Pow(3 , 0), Power.CopmutePower(3, 0));
       

        }
        [TestMethod()]
        public void CopmutePower_3_raised_to_power_1()
        {
            Assert.AreEqual(Math.Pow(3, 1), Power.CopmutePower(3, 1));
        }

        [TestMethod()]
        public void CopmutePower_5_raised_to_power_2()
        {
            Assert.AreEqual(Math.Pow(5, 2), Power.CopmutePower(5, 2));
        }

        [TestMethod()]
        public void CopmutePower_5_raised_to_power_negative_2()
        {
            Assert.AreEqual(Math.Pow(5, -2), Power.CopmutePower(5, -2));
        }
    }
}