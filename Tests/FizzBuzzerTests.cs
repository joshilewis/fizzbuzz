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

        private List<string> expectedOutput;

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
            List<string> actual = fizzBuzzer.FizzBuzzIt(count);

            Assert.That(actual, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void Test_Text()
        {
            count = 3;

            expectedOutput = new List<string>()
            {"0", "1", "2"};

            ActAndAssert();
        }

        [Test]
        public void Test_Fizz()
        {
            count = 4;

            expectedOutput = new List<string>() { "0", "1", "2", "fizz" };

            ActAndAssert();

        }

        [Test]
        public void Test_Buzz()
        {
            count = 6;

            expectedOutput = new List<string>() { "0", "1", "2", "fizz", "4", "buzz" };

            ActAndAssert();

        }

    }

    public class FizzBuzzer
    {
        public virtual List<string> FizzBuzzIt(int count)
        {
            var toReturn = new List<string>();

            var numbers = Enumerable.Range(0, count);

            toReturn = numbers
                .Select(x => x.ToString())
                .ToList()
                ;

            for (var i = 3; i < toReturn.Count; i = i + 3)
            {
                toReturn[i] = "fizz";
            }

            return toReturn;
        }
    }
}
