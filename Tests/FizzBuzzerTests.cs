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
        private int count;

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
            List<int> actual = fizzBuzzer.FizzBuzzIt(count);

            Assert.That(actual, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void Test_Range()
        {
            count = 3;

            expectedOutput = new List<int>()
            {0, 1, 2};

            ActAndAssert();
        }

    }

    public class FizzBuzzer
    {
        public virtual List<int> FizzBuzzIt(int count)
        {
            var toReturn = new List<int>();

            toReturn = Enumerable.Range(0, count).ToList();

            return toReturn;
        }
    }
}
