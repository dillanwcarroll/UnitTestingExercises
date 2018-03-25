
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

        [SetUp]
        public void SetUp()
        {
            vDriver = new Driver("CopKilla", "McCopKillaFace", "Female", "Fake");
        }

        [Test]
        public void DriverTest()
        {
            Assert.AreSame(vDriver.fname, "CopKilla");
            Assert.AreSame(vDriver.lname, "McCopKillaFace");
            Assert.AreSame(vDriver.ge, "");
            Assert.AreSame(vDriver., "");
        }

        [Test]
        public void getLicenceTypeTest()
        {
            Assert.Fail();
        }
    }
}