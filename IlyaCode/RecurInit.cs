namespace IlyaCode
{
    internal partial class Recur
    {

        static int[] fibMemory = new int[20];
        static int[,] combinMemory = new int[21, 21];

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
                else
                {
                    fibMemory[n - 1] = Fib2(n - 2) + Fib2(n - 1);
                }
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

        public static int Combin2(int n, int k)
        {
            if (combinMemory[n, k] == 0)
            {
                if (k == 0 || k == n)
                {
                    combinMemory[n, k] = 1;
                }
                else
                {
                    combinMemory[n, k] = Combin2(n - 1, k) + Combin2(n - 1, k - 1);
                }
            }
            return combinMemory[n, k];
        }

        public static double RootK(double x, int k, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                double res = RootK(x, k, n - 1);
                return res - (res - x / PowerN(res, k - 1)) / k;
            }
        }

        public static uint NOD(uint a, uint b)
        {
            if (b == 0) return a;
            else return NOD(b, a % b);
        }

        public static int DigitSum(int k)
        {
            if (k < 10) return k;
            return k % 10 + DigitSum(k / 10);
        }

        public static int MaxElem(int[] a, int n)
        {
            if (n == 1)
            {
                return a[0];
            }
            else
            {
                int max = MaxElem(a, n - 1);
                return max > a[n - 1] ? max : a[n - 1];
            }
        }

        public static int DigitCount(string s)
        {
            if (s.Length == 1) return Char.IsDigit(s[0]) ? 1 : 0;
            else
            {
                return DigitCount(s.Substring(1)) + (Char.IsDigit(s[0]) ? 1 : 0);
            }
        }

        public static bool Palindrom(string s)
        {
            if (s.Length == 1)
            {
                return true;
            }
            else if (s.Length == 2)
            {
                return s[0] == s[1];
            }
            else
            {
                return s[0] == s[^1] && Palindrom(s.Substring(1, s.Length - 2));
            }
        }

        public static int Expretion1(string s)
        {
            if (s.Length == 1) return byte.Parse(s);
            else
            {
                if (s[^2] == '+')
                    return Expretion1(s.Remove(s.Length - 2)) + byte.Parse(s[^1].ToString());
                else
                    return Expretion1(s.Remove(s.Length - 2)) - byte.Parse(s[^1].ToString());
            }
        }

        public static int Expretion2(string s)
        {
            int plus = s.LastIndexOf('+');
            int minus = s.LastIndexOf('-');
            if (plus == -1 && minus == -1) return Term2(s);
            else
            {
                if (plus > minus)
                    return Expretion2(s.Remove(plus)) + Term2(s.Substring(plus + 1));
                else
                    return Expretion2(s.Remove(minus)) - Term2(s.Substring(minus + 1));
            }
        }

        public static int Term2(string s)
        {
            if (s.Length == 1)
            {
                return byte.Parse(s);
            }
            else return Term2(s.Remove(s.Length - 2)) * byte.Parse(s[^1].ToString());
        }

        public static int Expretion3(string s)
        {
            int plus = s.LastIndexOf('+');
            int minus = s.LastIndexOf('-');
            if (plus == -1 && minus == -1) return Term3(s);
            else
            {
                if (plus > minus)
                    return Expretion3(s.Remove(plus)) + Term3(s.Substring(plus + 1));
                else
                    return Expretion3(s.Remove(minus)) - Term3(s.Substring(minus + 1));
            }
        }

        public static int Term3(string s)
        {
            int mul = s.LastIndexOf('*');
            if (mul == -1)
            {
                return Elem3(s);
            }
            else return Term3(s.Remove(mul)) * Elem3(s.Substring(mul + 1));
        }

        public static int Elem3(string s)
        {
            if (s.Length == 1) return byte.Parse(s);
            else return Expretion3(s.Substring(1, s.Length - 2));
        }

        public static int Expretion4(string s, ref int index) //Самая_сложная_задача_на_свете100%!!!(string s)
        {
            int first;
            int second;
            char symbol;
            if (s[index] == '(')
            {
                index++;
                first = Expretion4(s, ref index);
                symbol = s[index];
                index++;
                second = Expretion4(s, ref index);
                index++;
                return symbol switch
                {
                    '+' => first + second,
                    '-' => first - second,
                    '*' => first * second
                };
            }
            else
            {
                first = byte.Parse(s[index].ToString());
                index++;
                return first;
            }
        }

        public static bool CheckExpretion4(string s, ref int index) //Самая_сложная_задача_на_свете100%!!!(string s)
        {
            if (s[index] == '(')
            {
                index++;
                if (!CheckExpretion4(s, ref index)) return false;
                if (!(s[index] == '+' || s[index] == '-' || s[index] == '*')) return false;
                index++;
                if (!CheckExpretion4(s, ref index)) return false;
                if (s[index] != ')') return false;
                index++;
                return true;
            }
            else
            {
                if (Char.IsDigit(s[index]))
                {
                    index++;
                    return true;
                }
                return false;
            }
        }
    }
}
