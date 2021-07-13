using CodeAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAlgorithms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Should_Fibonacci_Return_0_When_n_Is_0()
        {
            var n = 0;
            Fibonacci fibonacci = new Fibonacci(n);
            Assert.AreEqual(0, fibonacci.Calculate());
        }

        [TestMethod]
        public void Should_Fibonacci_Return_1_When_n_Is_1()
        {
            var n = 1;
            Fibonacci fibonacci = new Fibonacci(n);
            Assert.AreEqual(1, fibonacci.Calculate());
        }
    }
}
