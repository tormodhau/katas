using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzTests
{
    [TestClass]
    public class AnswerTests
    {
        private FizzBuzz.FizzBuzz _fizzBuzzKata;

        [TestInitialize]
        public void Setup()
        {
            _fizzBuzzKata = new FizzBuzz.FizzBuzz();
        }

        [TestMethod]
        public void OneGivesOne()
        {
            Assert.AreEqual(_fizzBuzzKata.Answer(1), "1");
        }

        [TestMethod]
        public void TwoGivesTwo()
        {
            Assert.AreEqual(_fizzBuzzKata.Answer(2), "2");
        }

        [TestMethod]
        public void ThreeGivesFizz()
        {
            Assert.AreEqual(_fizzBuzzKata.Answer(3), "Fizz");
        }

        [TestMethod]
        public void FourGivesFour()
        {
            Assert.AreEqual(_fizzBuzzKata.Answer(4), "4");
        }

        [TestMethod]
        public void FiveGivesBuzz()
        {
            Assert.AreEqual(_fizzBuzzKata.Answer(5), "Buzz");
        }

        [TestMethod]
        public void SixGivesFizz()
        {
            Assert.AreEqual(_fizzBuzzKata.Answer(6), "Fizz");
        }

        [TestMethod]
        public void TenGivesBuzz()
        {
            Assert.AreEqual(_fizzBuzzKata.Answer(10), "Buzz");
        }

        [TestMethod]
        public void FifteenGivesFizzBuzz()
        {
            Assert.AreEqual(_fizzBuzzKata.Answer(15), "FizzBuzz");
        }

        [TestMethod]
        public void ThirtyGivesFizzBuzz()
        {
            Assert.AreEqual(_fizzBuzzKata.Answer(30), "FizzBuzz");
        }

        [TestMethod]
        public void All_Numbers_Divisble_By_5_And_By_3_Gives_FizzBuzz()
        {
            for (int i = 0; i < 10000; i++)
            {
                if(i % 5 == 0 && i % 3 == 0)
                    Assert.AreEqual("FizzBuzz", _fizzBuzzKata.Answer(i));
            }
        }

        [TestMethod]
        public void All_Numbers_Divisble_By_3_And_Not_By_5_Gives_Fizz()
        {
            for (int i = 1; i < 10000; i++)
            {
                if (i % 5 != 0 && i % 3 == 0)
                    Assert.AreEqual("Fizz", _fizzBuzzKata.Answer(i), "");
            }
        }

        [TestMethod]
        public void All_Numbers_Divisble_By_5_And_Not_By_3_Gives_Buzz()
        {
            for (int i = 1; i < 10000; i++)
            {
                if (i % 3 != 0 && i % 5 == 0)
                    Assert.AreEqual("Buzz", _fizzBuzzKata.Answer(i), "");
            }
        }
    }
}
