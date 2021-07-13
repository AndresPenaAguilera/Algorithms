using System.Linq;

namespace CodeAlgorithms
{
    public class Fibonacci
    {
        private int N { get; init; }

        public Fibonacci(int n)
        {
            N = n;
        }

        public int Calculate() 
        {
            if (N == 1)
                return 0;

            if (N == 2 || N==3)
                return 1;

            int number1 = 0;
            int number2 = 1;
            int result = 1;

            for (int i=4;i<=N;i++) 
            {
                number1 = result;
                result = result + number2;
                number2 = number1;
            }

            return result;
        }
    }
}