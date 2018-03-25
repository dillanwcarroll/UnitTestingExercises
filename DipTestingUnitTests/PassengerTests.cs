
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
    public class PassengerTests
    {
        private Passenger vPassenger;

        [SetUp]
        public void SetUp()
        {
            vPassenger = new FakePassenger("dan", "gheesling", "male", "disabled");
        }

        [Test]
        public void PassengerTest()
        {
            Assert.AreSame("dan", vPassenger.fname);
            Assert.AreSame("gheesling", vPassenger.lname);
            Assert.AreSame("male", vPassenger.getGender()); ;
            Assert.AreSame("disabled", vPassenger.getTicketType());
        }

        [Test]
        public void getTicketTypeTest()
        {
            vPassenger.getTicketType();

            Assert.AreSame("disabled", vPassenger.getTicketType());
        }
    }
}