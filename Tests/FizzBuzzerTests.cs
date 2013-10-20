using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        private int starting;
        private int ending;

        private List<int> expectedOutput;

        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        private void ActAndAssert()
        {
            var fizzBuzzer = new FizzBuzzer();
            List<int> actual = fizzBuzzer.FizzBuzzIt(starting, ending);

            Assert.That(actual, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void Test_Range()
        {
            starting = 0;
            ending = 2;

            expectedOutput = new List<int>()
            {0, 1, 2};

            ActAndAssert();
        }

    }

    public class FizzBuzzer
    {
        public virtual List<int> FizzBuzzIt(int start, int end)
        {
            var toReturn = new List<int>();

            toReturn = Enumerable.Range(start, end - start + 1).ToList();

            return toReturn;
        }
    }
}
