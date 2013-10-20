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
        public void Test_None()
        {
            count = 3;

            expectedOutput = new List<string>()
            {"0", "1", "2"};

            ActAndAssert();
        }

        [Test]
        public void Test_Fizz_1()
        {
            count = 4;

            expectedOutput = new List<string>() { "0", "1", "fizz" };

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
                .Select(Classifier)
                .ToList()
                ;

            return toReturn;
        }

        public virtual string Classifier(int number)
        {
            return number.ToString();
        }
    }
}
