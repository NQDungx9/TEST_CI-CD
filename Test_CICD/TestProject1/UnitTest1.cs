using NUnit.Framework;
using TESTCICD;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private Program _program;
        [SetUp]
        public void Setup()
        {
            _program = new Program();
        }

        [Test]
        public void Add_SumOf2Number()
        {
            var result = _program.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Minus_MinusOf2Number()
        {
            var result = _program.Minus(2, 3);
            Assert.AreEqual(-1, result);
        }
    }
}