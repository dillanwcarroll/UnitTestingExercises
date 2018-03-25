using DipTestingExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DipTestingUnitTests.Mocking;

namespace DipTestingExercises.Tests
{
    [TestFixture]
    public class MotorVehicleTests
    {
        private MotorVehicle mv;

        [SetUp]
        public void SetUp()
        {
            mv = new FakeMotorVehicle(new FakeDriver(), 100, 50, 2);
        }

        [Test]
        public void MotorVehicleTest()
        {
            //Assert
            Assert.AreEqual(100, mv.maxFuel | 50, mv.currentFuel);
            Assert.AreEqual(2, mv.litresPerKM);
        }

        [Test]
        public void refuelTest__Whencalled_EnoughCurrentFuel()
        {
            //Act
            mv.refuel(50);

            //Assert
            Assert.AreEqual(100, mv.currentFuel);
        }

        [Test]
        public void refuelTest__Whencalled_Exception_TooMuchFuel()
        {
            try
            {
                mv.refuel(51);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains("Vehicle cannot hold that much fuel!"));
            }
        }

        [Test]
        public void refuelTest__WhenCalled_Exception_NotEnoughFuel()
        {
            try
            {
                mv.refuel(-1);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains("Someone is stealing fuel!!"));
            }
        }

        [Test]
        public void getFuelRemainingTest()
        {
            //Act
            mv.getFuelRemaining();
            //Assert
            Assert.AreEqual(50, mv.getFuelRemaining());
        }

        [Test]
        public void travelTest_WhenCalled_FuelRemaining()
        {
            //Act
            mv.travel(10);
            mv.getFuelRemaining();
            //Assert
            Assert.AreEqual(30, mv.currentFuel);
        }

        [Test]
        public void travelTest_WhenCalled_Exception_OutOfFuel()
        {
            //Act
            try
            {
                mv.travel(20);
                mv.getFuelRemaining();
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains("Out of Fuel!"));
            }
            //Assert

        }
    }
}