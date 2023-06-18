namespace IlyaCode
{
    internal partial class Recur
    {

        static int[] fibMemory = new int[20];

        public static double FactN(int n)
        {
            if (n == 1)
            {
                return n;
            }
            return n * FactN(n - 1);
        }

        public static double Fact2(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            return n * Fact2(n - 2);
        }

        public static double PowerN(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n > 0)
            {
                if (n % 2 == 0)
                {
                    double pow = PowerN(x, n / 2);
                    return pow * pow;
                }
                else
                {
                    return x * PowerN(x, n - 1); 
                }
            }
            else
            {
                return 1 / PowerN(x, -n);
            }
            return n * Fact2(n - 2);
        }

        public static int Fib1(int n, ref int count)
        {
            count++;
            if (n <= 2)
            {
                return 1;
            }
            return Fib1(n - 2, ref count) + Fib1(n - 1, ref count);
        }

        public static int Fib2(int n)
        {
            if (fibMemory[n - 1] == 0)
            {
                if (n <= 2)
                {
                    fibMemory[n - 1] = 1;
                }
                fibMemory[n - 1] = Fib2(n - 2) + Fib2(n - 1);
            }
            return fibMemory[n - 1];
        }

        public static int Combin1(int n, int k, ref int count)
        {
            count++;
            if (k == 0 || k == n)
            {
                return 1;
            }
            return Combin1(n - 1, k, ref count) + Combin1(n - 1, k - 1, ref count);
        }
    }
}
