using System;

namespace IlyaCode
{
    internal static class Proc
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Proc1");
                        for (int i = 0; i < 5; i++)
                        {
                            double b;
                            PowerA3(Convert.ToDouble(Console.ReadLine()), out b);
                            Console.WriteLine(b);
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Proc2");
                        for (int i = 0; i < 5; i++)
                        {
                            double b, c, d;
                            PowerA234(Convert.ToDouble(Console.ReadLine()), out b, out c, out d);
                            Console.WriteLine(b);
                        }
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Proc3");
                        double a = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            double aMean, gMean;
                            Mean(Convert.ToDouble(Console.ReadLine()), a, out aMean, out gMean);
                            Console.WriteLine(aMean);
                            Console.WriteLine(gMean);

                        }
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Proc4");
                        for (int i = 0; i < 3; i++)
                        {
                            double p, s;
                            TrianglePS(Convert.ToDouble(Console.ReadLine()), out p, out s);
                            Console.WriteLine(p);
                            Console.WriteLine(s);
                        }
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Proc5");
                        for (int i = 0; i < 3; i++)
                        {
                            double p, s;
                            RectPS(Convert.ToDouble(Console.ReadLine()),
                                Convert.ToDouble(Console.ReadLine()),
                                Convert.ToDouble(Console.ReadLine()),
                                Convert.ToDouble(Console.ReadLine()),
                                out p, out s);
                            Console.WriteLine(p);
                            Console.WriteLine(s);
                        }
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Proc6");
                        for (int i = 0; i < 5; i++)
                        {
                            int c, s;
                            DigitCountSum(Convert.ToInt32(Console.ReadLine()), out c, out s);
                            Console.WriteLine(c);
                            Console.WriteLine(s);
                        }
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Proc7");
                        for (int i = 0; i < 5; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            InvertDigits(ref k);
                            Console.WriteLine(k);
                        }
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Proc8");
                        int k = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < 2; i++)
                        {
                            AddRightDigit(Convert.ToInt32(Console.ReadLine()), ref k);
                            Console.WriteLine(k);
                        }
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Proc9");
                        int k = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < 2; i++)
                        {
                            AddLeftDigit(Convert.ToInt32(Console.ReadLine()), ref k);
                            Console.WriteLine(k);
                        }
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Proc10");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double c = Convert.ToDouble(Console.ReadLine());
                        double d = Convert.ToDouble(Console.ReadLine());
                        Swap(ref a, ref b);
                        Swap(ref c, ref d);
                        Swap(ref b, ref c);
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                        Console.WriteLine(d);
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Proc11");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double c = Convert.ToDouble(Console.ReadLine());
                        double d = Convert.ToDouble(Console.ReadLine());
                        MinMax(ref a, ref b);
                        MinMax(ref c, ref d);
                        MinMax(ref b, ref d);
                        MinMax(ref a, ref c);
                        Console.WriteLine(a);
                        Console.WriteLine(d);
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Proc12");
                        for (int i = 0; i < 2; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            double b = Convert.ToDouble(Console.ReadLine());
                            double c = Convert.ToDouble(Console.ReadLine());
                            SortInc3(ref a, ref b, ref c);
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                        }
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Proc13");
                        for (int i = 0; i < 2; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            double b = Convert.ToDouble(Console.ReadLine());
                            double c = Convert.ToDouble(Console.ReadLine());
                            SortDec3(ref a, ref b, ref c);
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                        }
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("Proc14");
                        for (int i = 0; i < 2; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            double b = Convert.ToDouble(Console.ReadLine());
                            double c = Convert.ToDouble(Console.ReadLine());
                            ShiftRight3(ref a, ref b, ref c);
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                        }
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Proc15");
                        for (int i = 0; i < 2; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            double b = Convert.ToDouble(Console.ReadLine());
                            double c = Convert.ToDouble(Console.ReadLine());
                            ShiftLeft3(ref a, ref b, ref c);
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                        }
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("Proc16");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Sign(a) + Sign(b));
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("Proc17");
                        for (int i = 0; i < 3; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            double b = Convert.ToDouble(Console.ReadLine());
                            double c = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(RootsCount(a, b, c));
                        }
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("Proc18");
                        for (int i = 0; i < 3; i++)
                        {
                            double r = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(CircleS(r));
                        }
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("Proc19");
                        for (int i = 0; i < 3; i++)
                        {
                            double r1 = Convert.ToDouble(Console.ReadLine());
                            double r2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(RingS(r1, r2));
                        }
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Proc20");
                        for (int i = 0; i < 3; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            double h = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(TriangleP(a, h));
                        }
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("Proc21");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(SumRange(a, b));
                        Console.WriteLine(SumRange(b, c));

                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("Proc22");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Calc(a, b, n));
                        }
                    }
                    break;
                case 23:
                    {
                        Console.WriteLine("Proc23");
                        for (int i = 0; i < 3; i++)
                        {
                            double x = Convert.ToDouble(Console.ReadLine());
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Quarter(x, y));
                        }
                    }
                    break;
                case 24:
                    {
                        Console.WriteLine("Proc24");
                        int count = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            if(Even(k))
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("Proc25");
                        int count = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            if (IsSquare(k))
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 26:
                    {
                        Console.WriteLine("Proc26");
                        int count = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            if (IsPower5(k))
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);

                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("Proc27");
                        int count = 0;
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < 10; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            if (IsPowerN(k, n))
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 28:
                    {
                        Console.WriteLine("Proc28");
                        int count = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            int n = Convert.ToInt32(Console.ReadLine());
                            if (IsPrime(n))
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
            }
        }

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
            while(k % 5 == 0)
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
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

