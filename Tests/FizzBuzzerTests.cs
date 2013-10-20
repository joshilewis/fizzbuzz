using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzz;
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
            IEnumerable<string> actual = fizzBuzzer.FizzBuzzIt(count);

            Assert.That(actual, Is.EquivalentTo(expectedOutput));
        }

        [Test]
        public void Test_None()
        {
            count = 2;

            expectedOutput = new List<string>()
            {"1", "2"};

            ActAndAssert();
        }

        [Test]
        public void Test_Fizz_1()
        {
            count = 3;

            expectedOutput = new List<string>() { "1", "2", "Fizz" };

            ActAndAssert();
        }

        [Test]
        public void Test_Buzz_1()
        {
            count = 5;

            expectedOutput = new List<string>() { "1", "2", "Fizz", "4", "Buzz"};

            ActAndAssert();
        }

        [Test]
        public void Test_Fizz_2()
        {
            count = 6;

            expectedOutput = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz" };

            ActAndAssert();
        }

        [Test]
        public void Test_Buzz_2()
        {
            count = 10;

            expectedOutput = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" };

            ActAndAssert();
        }

        [Test]
        public void Test_FizzBuzz_1()
        {
            count = 15;

            expectedOutput = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            ActAndAssert();
        }

    }
}
