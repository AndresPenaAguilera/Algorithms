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
            return N==0?0:1;
        }

        
    }
}