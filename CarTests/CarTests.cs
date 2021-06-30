using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            Car testCar = new Car("Toyota", "Corolla", 10, 40);
            Assert.AreEqual(10, testCar.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            Car testCar = new Car("Toyota", "Prius", 10, 50);
            testCar.Drive(50);
            Assert.AreEqual(9, testCar.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            Car testCar = new Car("Toyota", "Prius", 10, 50);
            testCar.Drive(600);
            Assert.AreEqual(0, testCar.GasTankLevel, .001);
        }

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            Car testCar = new Car("Toyota", "Prius", 10, 50);
            testCar.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank.");
        }

    }
}
