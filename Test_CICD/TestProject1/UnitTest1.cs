using NUnit.Framework;
using TESTCICD;

namespace TestProject1
{
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
            Assert.Equals(5, result);
        }
    }
}