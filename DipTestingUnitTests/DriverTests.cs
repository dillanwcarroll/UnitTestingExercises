
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
    public class DriverTests
    {
        private Driver vDriver;
        string result;

        [SetUp]
        public void SetUp()
        {
            vDriver = new Driver("CopKilla", "McCopKillaFace", "Female", "Fake");
        }

        [Test]
        public void DriverTest()
        {
            Assert.AreSame("CopKilla", vDriver.fname);
            Assert.AreSame("McCopKillaFace", vDriver.lname);
            Assert.AreSame("Female", vDriver.getGender());
            Assert.AreSame("Fake", vDriver.getLicenceType());
        }

        [Test]
        public void getLicenceTypeTest()
        {
           result = vDriver.getLicenceType();

            Assert.AreSame("Fake", result);
        }
    }
}