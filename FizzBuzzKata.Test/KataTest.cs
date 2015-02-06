﻿using System;
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
        public void CanPassOne()
        {
            var fizzBuzz = new FizzBuzz();
            // CHANGESET NOTE: I messed it up and sent 0 at the beggining should've been one!
            string actual = fizzBuzz.Run(1);
            string expected = "1";

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
