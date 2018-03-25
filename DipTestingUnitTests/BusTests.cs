using DipTestingExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using DipTestingUnitTests.Mocking;

namespace DipTestingExercises.Tests
{
    [TestFixture]
    public class BusTests
    {
        private Bus vBus;
        private FakePassenger fp;
        private FakeDriver fd;

        [SetUp]
        public void SetUp()
        {
            vBus = new Bus(new FakeDriver(), 100, 50, 2, 1);
            fp = new FakePassenger("dan", "gheesling", "male", "disabled");
            fd = new FakeDriver();
        }

        [Test]
        [Ignore("yo hold up ignore this")]
        public void Test_To_Ignore()
        {
            //yo hold up ignore this
        }

        [Test]
        public void BusTest()
        {
            //Assert
            Assert.AreEqual(vBus.maxPassengers, 1);
        }

        [Test]
        public void getPassengerCountTest_BusEmpty()
        {
            vBus.getPassengerCount();

            Assert.IsEmpty(vBus.passengers);
        }

        [Test]
        public void getPassengerCountTest_BusHasPassenger()
        {
            vBus.passengers.Add(fp);
            vBus.getPassengerCount();

            Assert.IsNotEmpty(vBus.passengers);
        }

        [Test]
        public void embarkPassengerTest_HasRoom()
        {
            vBus.embarkPassenger(fp);

            Assert.Contains(fp, vBus.passengers);
        }

        [Test]
        public void embarkPassengerTest_Exception_BusFull()
        {
            vBus.embarkPassenger(fp);
            try
            {
                vBus.embarkPassenger(new FakePassenger("ryan", "letournau", "male", "concession"));
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains("Bus is Already Full!"));
            }
            Assert.IsNotEmpty(vBus.passengers);
        }
    }
}
