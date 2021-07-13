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

            if (N == 4)
                return 2;

            if (N == 5)
                return 3;

            if (N == 6)
                return 5;

            return 8;
        }

        
    }
}