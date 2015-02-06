using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKata.Test
{
    [TestClass]
    public class KataTest
    {
        FizzBuzz _fizzBuzz;
        [TestInitialize]
        public void CanInitializeFizzBuzz()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void CanPassOne()
        {
            string actual = _fizzBuzz.Run(1);
            string expected = "1";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ReturnsFizzForThree()
        {
            string actual = _fizzBuzz.Run(3);
            string expected = "Fizz";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ReturnsBuzzForFive()
        {
            string actual = _fizzBuzz.Run(5);
            string expected = "Buzz";

            Assert.AreEqual(actual, expected);
        }

    }
}
