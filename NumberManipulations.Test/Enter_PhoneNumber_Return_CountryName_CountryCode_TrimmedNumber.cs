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

            [Test]
            public void EnterNumber_InputIs0037529_Return29()
            {
                var result = _numberManipulations.EnterNumber("jsdhf320037529");
                Assert.Equals("29", result);
            }
        }
    }
}