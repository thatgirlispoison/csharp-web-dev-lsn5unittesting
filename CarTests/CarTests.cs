using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        // ... other TODOs omitted here
        Car test_car;

        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }
        [TestMethod]
        public void TestInitialGasTank()
        {
            
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }

    }
}
//TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
//TODO: constructor sets gasTankLevel properly
//TODO: gasTankLevel is accurate after driving within tank range
//TODO: gasTankLevel is accurate after attempting to drive past tank range
//TODO: can't have more gas than tank size, expect an exception