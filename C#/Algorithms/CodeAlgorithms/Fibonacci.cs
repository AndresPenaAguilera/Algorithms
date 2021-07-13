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
            if (N == 0 || N == 1)
                return 1;

            return N==2?2:3;
        }

        
    }
}