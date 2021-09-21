using NUnit.Framework;
using NumberManipulations;

namespace NumberManipulations.Test
{
    public class Tests
    {
        [TestFixture]
        public class NumberManipulationsTest
        {
            private NumberSorting _numberManipulations;

            [SetUp]
            public void Setup()
            {
                _numberManipulations = new NumberSorting();
            }

            [TestCase("dfjkg003752945", "2945")]
            [TestCase("+(375)2945", "2945")]
            [TestCase("00ghh3742945", "2945")]
            [TestCase("00ghh3752945", "2945")]
            [TestCase("jkhadf", "")]
            public void InputIsNumber_Return(string number, string clearNumber)
            {
                var result = _numberManipulations.EnterNumber(number);
                Assert.AreEqual(clearNumber, result);
            }
        }
    }
}