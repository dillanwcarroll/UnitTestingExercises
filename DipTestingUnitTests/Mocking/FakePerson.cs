using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipTestingExercises;

namespace DipTestingUnitTests.Mocking
{
    class FakePerson : Person
    {
        public FakePerson(string pFname, string pLname, string pGender) : base(pFname, pLname, pGender)
        {
        }
    }
}
