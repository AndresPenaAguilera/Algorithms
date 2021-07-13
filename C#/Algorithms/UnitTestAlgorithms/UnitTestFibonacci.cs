using CodeAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAlgorithms
{
    [TestClass]
    public class UnitTestFibonacci
    {
        
        [TestMethod]
        public void Should_Fibonacci_Return_1_When_n_Is_1()
        {
            var n = 1;
            Fibonacci fibonacci = new Fibonacci(n);
            Assert.AreEqual(0, fibonacci.Calculate());
        }

        [TestMethod]
        public void Should_Fibonacci_Return_2_When_n_Is_2()
        {
            var n = 2;
            Fibonacci fibonacci = new Fibonacci(n);
            Assert.AreEqual(1, fibonacci.Calculate());
        }

        [TestMethod]
        public void Should_Fibonacci_Return_1_When_n_Is_3()
        {
            var n = 3;
            Fibonacci fibonacci = new Fibonacci(n);
            Assert.AreEqual(1, fibonacci.Calculate());
        }

        [TestMethod]
        public void Should_Fibonacci_Return_3_When_n_Is_4()
        {
            var n = 4;
            Fibonacci fibonacci = new Fibonacci(n);
            Assert.AreEqual(2, fibonacci.Calculate());
        }

        [TestMethod]
        public void Should_Fibonacci_Return_3_When_n_Is_5()
        {
            var n = 5;
            Fibonacci fibonacci = new Fibonacci(n);
            Assert.AreEqual(3, fibonacci.Calculate());
        }
    }
}
