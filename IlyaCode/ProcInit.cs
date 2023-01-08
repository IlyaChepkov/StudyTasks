namespace IlyaCode
{
    internal static partial class Proc
    {

        public static void PowerA3(double a, out double b)
        {
            b = a * a * a;
        }

        public static void PowerA234(double a, out double b, out double c, out double d)
        {
            b = a * a;
            c = a * a * a;
            d = a * a * a * a;
        }

        public static void Mean(double x, double y, out double aMean, out double gMean)
        {
            aMean = (x + y) / 2;
            gMean = Math.Sqrt(x * y);
        }

        public static void TrianglePS(double a, out double p, out double s)
        {
            p = a * 3;
            s = (a * a) * Math.Sqrt(3) / 4;
        }

        public static void RectPS(double x1, double y1, double x2, double y2, out double p, out double s)
        {
            x1 = Math.Abs(x1 - x2);
            y1 = Math.Abs(y1 - y2);
            p = (x1 + y1) * 2;
            s = x1 * y2;
        }

        public static void DigitCountSum(int k, out int c, out int s)
        {
            c = 0;
            s = 0;
            while (k > 0)
            {
                s += k % 10;
                c++;
                k /= 10;
            }
        }

        public static void InvertDigits(ref int k)
        {
            int digits = 0;
            while (k > 0)
            {
                digits *= 10;
                digits += k % 10;
                k /= 10;
            }
            k = digits;
        }

        public static void AddRightDigit(int d, ref int k)
        {
            k = k * 10 + d;
        }

        public static void AddLeftDigit(int d, ref int k)
        {
            int digits = k;
            while (digits > 0)
            {
                digits /= 10;
                d *= 10;
            }
            k += d;
        }

        public static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }

        public static void MinMax(ref double x, ref double y)
        {
            if (x > y)
            {
                Swap(ref x, ref y);
            }
        }

        public static void SortInc3(ref double a, ref double b, ref double c)
        {
            MinMax(ref a, ref b);
            MinMax(ref b, ref c);
            MinMax(ref a, ref b);
        }

        public static void SortDec3(ref double a, ref double b, ref double c)
        {
            MinMax(ref c, ref b);
            MinMax(ref b, ref a);
            MinMax(ref c, ref b);
        }

        public static void ShiftRight3(ref double a, ref double b, ref double c)
        {
            Swap(ref a, ref b);
            Swap(ref a, ref c);
        }

        public static void ShiftLeft3(ref double a, ref double b, ref double c)
        {
            Swap(ref a, ref c);
            Swap(ref a, ref b);
        }

        public static int Sign(double x)
        {
            if (x < 0)
            {
                return -1;
            }
            else
            {
                if (x == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
        public static int RootsCount(double a, double b, double c)
        {
            double d = (b * b) - 4 * a * c;
            if (d < 0)
            {
                return 0;
            }
            else
            {
                if (d == 0)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
        public static double CircleS(double r) => 3.14 * (r * r);

        public static double RingS(double r1, double r2) => CircleS(r1) - CircleS(r2);

        public static double TriangleP(double a, double h) => Math.Sqrt((a * a / 4) + h * h) * 2 + a;

        public static int SumRange(int a, int b)
        {
            int sum = 0;
            while (a <= b)
            {
                sum += a;
                a++;
            }
            return sum;
        }

        public static double Calc(double a, double b, int op)
        {
            switch (op)
            {
                case 1:
                    {
                        return a - b;
                    }
                case 2:
                    {
                        return a * b;
                    }
                case 3:
                    {
                        return a / b;
                    }
            }
            return a + b;
        }

        public static int Quarter(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    return 2;
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        public static bool Even(int k) => k % 2 == 0;

        public static bool IsSquare(int k) => Math.Sqrt(k) == (int)Math.Sqrt(k);

        public static bool IsPower5(int k)
        {
            while (k % 5 == 0)
            {
                k /= 5;
            }
            return k == 1;
        }


        public static bool IsPowerN(int k, int n)
        {
            while (k % n == 0)
            {
                k /= n;
            }
            return k == 1;
        }

        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int DigitCount(int k)
        {
            int count = 0;
            while (k > 0)
            {
                k /= 10;
                count++;
            }
            return count;
        }

        public static int DigitN(int k, int n)
        {
            int count = 0;
            int digit = 0;
            while (count != n && k > 0)
            {
                digit = k % 10;
                k /= 10;
                count++;
            }
            if (count == n)
            {
                return digit;
            }
            else
            {
                return -1;
            }
        }

        public static bool IsPalindrom(int k)
        {
            int count = DigitCount(k);
            for (int i = 0; i < count / 2; i++)
            {
                if (DigitN(k, i + 1) != DigitN(k, count - i))
                {
                    return false;
                }
            }
            return true;
        }

        public static double DegToRad(double d) => d * 3.14 / 180;

        public static double RadToDeg(double r) => r * 180 / 3.14;

        public static double Fact(int n)
        {
            double fact = 1;
            for (int i = n; i >= 2; i--)
            {
                fact *= i;
            }
            return fact;
        }

        public static double Fact2(int n)
        {
            double fact = 1;
            for (int i = n; i >= 2; i -= 2)
            {
                fact *= i;
            }
            return fact;
        }
        public static int Fib(int n)
        {
            int f1 = 1;
            int f2 = 1;
            for (int i = 3; i <= n; i++)
            {
                int f = f1 + f2;
                f2 = f1;
                f1 = f;
            }
            return f1;
        }

        public static double Power1(double a, double b)
        {
            if (a <= 0)
            {
                return 0;
            }
            else
            {
                return Math.Exp(b * Math.Log(a));
            }
        }

        public static double Power2(double a, double n)
        {
            double pow = 1;
            for (int i = 0; i < n; i++)
            {
                pow *= a;
            }
            if (n < 0)
            {
                pow = 1 / pow;
            }
            return pow;
        }

        public static double Power3(double a, double b)
        {
            if (b == (int)b)
            {
                return Power2(a, b);
            }
            else
            {
                return Power1(a, b);
            }
        }

        public static double Exp1(double x, double e)
        {
            double sum = 0;
            double pow = 1;
            double element = 1;
            double fact = 1;
            for (int i = 1; element > e; i++)
            {
                sum += element;
                pow *= x;
                fact *= i;
                element = pow / fact;
            }
            return sum;
        }

        public static double Sin1(double x, double e)
        {
            double sum = 0;
            double fact = 1;
            double pow = x;
            double sign = 1;
            double element = pow / fact;
            for (int i = 2; Math.Abs(element) > e; i += 2)
            {
                sum += element;
                sign *= -1;
                pow *= x * x;
                fact *= i * (i + 1);
                element = pow / fact * sign;
            }
            return sum;
        }

        public static double Cos1(double x, double e)
        {
            double sum = 0;
            double fact = 1;
            double pow = 1;
            double sign = 1;
            double element = 1;
            for (int i = 1; Math.Abs(element) > e; i += 2)
            {
                sum += element;
                sign *= -1;
                pow *= x * x;
                fact *= i * (i + 1);
                element = pow / fact * sign;
            }
            return sum;
        }

        public static double Ln1(double x, double e)
        {
            sbyte sign = 1;
            double sum = 0;
            double pow = x;
            double element = pow;
            for (int i = 2; Math.Abs(element) > e; i++)
            {
                sum += element;
                sign *= -1;
                pow *= x;
                element = pow / i * sign;
            }
            return sum;
        }

        public static double Arctg1(double x, double e)
        {
            double sum = 0;
            double pow = x;
            double sign = 1;
            double element = pow;
            for (int i = 3; Math.Abs(element) > e; i += 2)
            {
                sum += element;
                sign *= -1;
                pow *= x * x;
                element = pow / i * sign;
            }
            return sum;
        }
        public static double Power4(double x, double a, double e)
        {
            double sum = 0;
            double powX = 1;
            double powA = 1;
            double element = 1;
            double fact = 1;
            for (int i = 1; Math.Abs(element) > e; i++)
            {
                sum += element;
                powA *= a - i + 1;
                powX *= x;
                fact *= i;
                element = powA * powX / fact;
            }
            return sum;
        }

        public static int NOD2(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static void Frac1(int a, int b, out int p, out int q)
        {
            int nod = NOD2(a, b);
            p = a / nod;
            q = b / nod;
        }

        public static int NOK2(int a, int b) => a * (b / NOD2(a, b));

        public static int NOD3(int a, int b, int c) => NOD2(NOD2(a, b), c);

        public static void TimeToHMS(int t, out int h, out int m, out int s)
        {
            h = t / 3600;
            m = t / 60;
            s = t;
            /*
             * Задача неодназначна. Возможен второй вариант решения:
             *  s = t % 60;
                m = t / 60 % 60;
                h = t / 3600;
             */
        }

        public static void IncTime(int t, ref int h, ref int m, ref int s)
        {
            s += t % 60;
            if (s >= 60)
            {
                m++;
                s -= 60;
            }
            m += t / 60 % 60;
            if (m >= 60)
            {
                h++;
                m -= 60;
            }
            h += t / 3600;
        }

        public static bool IsLeapYear(int y) 
            => y % 4 == 0 && (y % 100 != 0 || y % 400 == 0);

        public static int MonthDays(int m, int y)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    {
                        return IsLeapYear(y) == true ? 29 : 28;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
            }
            return 0;
        }

        public static void PrevDate(ref int d, ref int m,  ref int y)
        {
            if (d != 1)
            {
                d--;
            }
            else
            {
                if(m != 1)
                {
                    m--;
                }
                else
                {
                    m = 12;
                    y--;
                }
                d = MonthDays(m, y);
            }

        }

        public static void NextDate(ref int d, ref int m, ref int y)
        {
            if (d != MonthDays(m, y))
            {
                d++;
            }
            else
            {
                if (m != 12)
                {
                    m++;
                }
                else
                {
                    m = 1;
                    y++;
                }
                d = 1;
            }

        }

        public static double Leng(double xA, double yA, double xB, double yB)
            => Math.Sqrt(Power3(xA - xB, 2) + Power3(yA - yB, 2));

        public static double Perim(double xA, double yA, double xB, double yB, double xC, double yC)
            => Leng(xA, yA, xB, yB) + Leng(xB, yB, xC, yC) + Leng(xC, yC, xA, yA);

        public static double Area(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            double p = Perim(xA, yA, xB, yB, xC, yC) / 2;
            return Math.Sqrt(p
                                * (p - Leng(xA, yA, xB, yB))
                                * (p - Leng(xC, yC, xA, yA))
                                * (p - Leng(xB, yB, xC, yC)));
        }

        public static double Dist(double xP, double yP, double xA, double yA, double xB, double yB)
            => 2 * Area(xP, yP, xA, yA, xB, yB) / Leng(xA, yA, xB, yB);

        public static void Heights(double xA, double yA, double xB, double yB, double xC, double yC,
                                    out double hA, out double hB, out double hC)
        {
            hA = Dist(xA, yA, xB, yB, xC, yC);
            hB = Dist(xB, yB, xA, yA, xC, yC);
            hC = Dist(xC, yC, xA, yA, xB, yB);
        }
    }
}

