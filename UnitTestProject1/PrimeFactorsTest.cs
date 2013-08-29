using System;
using NUnit.Framework;
using System.Collections.Generic;
using PrimeFactorsProject;

namespace UnitTestProject1
{
    [TestFixture]
    public class PrimeFactorsTest
    {
        [Test]
        public void TestGenerateYieldsEmptyList()
        {
            List<int> expected = new List<int>();
            Assert.AreEqual(expected, PrimeFactors.Generate(1));
        }

        [Test]
        public void TestGenerateWithTwoYieldsTwo() {
            List<int> expected = new List<int>();
            expected.Add(2);
            Assert.AreEqual(expected, PrimeFactors.Generate(2));
        }

        [Test]
        public void TestGenerateWithFourYieldsTwoAndTwo()
        {
            List<int> expected = new List<int>();
            expected.Add(2);
            expected.Add(2);
            Assert.AreEqual(expected, PrimeFactors.Generate(4));
        }

        [Test]
        public void TestGenerateWithSixYieldsTwoAndThree()
        {
            List<int> expected = new List<int>();
            expected.Add(2);
            expected.Add(3);
            Assert.AreEqual(expected, PrimeFactors.Generate(6));
        }

        [Test]
        public void TestGenerateWithEightYieldsTwoAndTwoAndTwo()
        {
            List<int> expected = new List<int>();
            expected.Add(2);
            expected.Add(2);
            expected.Add(2);
            Assert.AreEqual(expected, PrimeFactors.Generate(8));
        }

        [Test]
        public void TestGenerateWithNineYieldsThreeAndThree()
        {
            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(3);
            Assert.AreEqual(expected, PrimeFactors.Generate(9));
        }
        
        [Test]
        public void TestGenerateWithTenYieldsFiveAndTwo()
        {
            List<int> expected = new List<int>();
            expected.Add(2);
            expected.Add(5);
            Assert.AreEqual(expected, PrimeFactors.Generate(10));
        }
    }
}
