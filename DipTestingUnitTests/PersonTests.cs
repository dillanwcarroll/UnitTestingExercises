
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
    public class PersonTests
    {
        private Person vPerson;

        [SetUp]
        public void SetUp()
        {
            vPerson = new FakePerson("Dave", "McDaveFace", "M");
        }

        [Test]
        public void PersonTest()
        {
            Assert.AreSame("Dave", vPerson.fname);
            Assert.AreSame("McDaveFace", vPerson.lname);
            Assert.AreSame("M", vPerson.getGender());
        }

        [Test]
        public void getNameTest()
        {
            vPerson.getName();

            Assert.AreSame("Dave", vPerson.fname);
            Assert.AreSame("McDaveFace", vPerson.lname);
        }

        [Test]
        public void getGenderTest()
        {
            vPerson.getGender();

            Assert.AreSame("M", vPerson.getGender());
        }
    }
}