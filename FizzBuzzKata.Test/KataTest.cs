using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKata.Test
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void CanInitializeFizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void CanPassZero()
        {
            var fizzBuzz = new FizzBuzz();
            string actual = fizzBuzz.Run(0);
            string expected = "0";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ReturnsFizzForThree()
        {
            var fizzBuzz = new FizzBuzz();
            string actual = fizzBuzz.Run(3);
            string expected = "Fizz";

            Assert.AreEqual(actual, expected);
        }

    }
}
