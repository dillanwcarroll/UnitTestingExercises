using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipTestingExercises;

namespace DipTestingUnitTests.Mocking
{
    class FakeDriver : IPerson
    {
        public string getGender()
        {
            throw new NotImplementedException();
        }

        public string getName()
        {
            throw new NotImplementedException();
        }
    }
}
