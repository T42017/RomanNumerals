using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanConvert1()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("I", roman.Convert(1));
        }

        [TestMethod]
        public void CanConvert2()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("II", roman.Convert(2));
        }

        [TestMethod]
        public void CanConvert3()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("III", roman.Convert(3));
        }

        [TestMethod]
        public void CanConvert4()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("IV", roman.Convert(4));
        }

        [TestMethod]
        public void CanConvert5()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("V", roman.Convert(5));
        }

        [TestMethod]
        public void CanConvert10()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("X", roman.Convert(10));
        }

        [TestMethod]
        public void CanConvert50()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("L", roman.Convert(50));
        }

        [TestMethod]
        public void CanConvert100()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("C", roman.Convert(100));
        }

        [TestMethod]
        public void CanConvert500()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("D", roman.Convert(500));
        }

        [TestMethod]
        public void CanConvert1000()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("M", roman.Convert(1000));
        }

        [TestMethod]
        public void CanConvert1999()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("MCMXCIX", roman.Convert(1999));
        }

        [TestMethod]
        public void CanConvert3999()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("MMMCMXCIX", roman.Convert(3999));
        }
    }
}
