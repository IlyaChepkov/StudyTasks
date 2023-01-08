using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal static partial class Proc
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
                            if (Even(k))
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
                case 29:
                    {
                        Console.WriteLine("Proc29");
                        for (int i = 0; i < 5; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DigitCount(k));
                        }
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("Proc30");
                        for (int i = 1; i <= 5; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DigitN(k, i));
                        }
                    }
                    break;
                case 31:
                    {
                        Console.WriteLine("Proc31");
                        for (int i = 0; i < 10; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(IsPalindrom(k));
                        }
                    }
                    break;
                case 32:
                    {
                        Console.WriteLine("Proc32");
                        for (int i = 0; i < 5; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DegToRad(k));
                        }
                    }
                    break;
                case 33:
                    {
                        Console.WriteLine("Proc33");
                        for (int i = 0; i < 5; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(RadToDeg(k));
                        }
                    }
                    break;
                case 34:
                    {
                        Console.WriteLine("Proc34");
                        for (int i = 0; i < 5; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Fact(k));
                        }
                    }
                    break;
                case 35:
                    {
                        Console.WriteLine("Proc35");
                        for (int i = 0; i < 5; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Fact2(k));
                        }
                    }
                    break;
                case 36:
                    {
                        Console.WriteLine("Proc36");
                        for (int i = 0; i < 5; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Fib(k));
                        }
                    }
                    break;
                case 37:
                    {
                        Console.WriteLine("Proc37");
                        double p = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Power1(k, p));
                        }
                    }
                    break;
                case 38:
                    {
                        Console.WriteLine("Proc38");
                        double a = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Power2(a, k));
                        }
                    }
                    break;
                case 39:
                    {
                        Console.WriteLine("Proc39");
                        double p = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Power3(k, p));
                        }
                    }
                    break;
                case 40:
                    {
                        Console.WriteLine("Proc40");
                        double x = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 6; i++)
                        {
                            double k = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Exp1(x, k));
                        }
                    }
                    break;
                case 41:
                    {
                        Console.WriteLine("Proc41");
                        double x = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 6; i++)
                        {
                            double k = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Sin1(x, k));
                        }
                    }
                    break;
                case 42:
                    {
                        Console.WriteLine("Proc42");
                        double x = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 6; i++)
                        {
                            double k = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Cos1(x, k));
                        }
                    }
                    break;
                case 43:
                    {
                        Console.WriteLine("Proc43");
                        double x = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 6; i++)
                        {
                            double k = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Ln1(x, k));
                        }
                    }
                    break;
                case 44:
                    {
                        Console.WriteLine("Proc44");
                        double x = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 6; i++)
                        {
                            double k = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Arctg1(x, k));
                        }
                    }
                    break;
                case 45:
                    {
                        Console.WriteLine("Proc45");
                        double x = Convert.ToDouble(Console.ReadLine());
                        double a = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 6; i++)
                        {
                            double k = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Power4(x, a, k));
                        }
                    }
                    break;
                case 46:
                    {
                        Console.WriteLine("Proc46");
                        int a = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(NOD2(a, b));
                        }
                    }
                    break;
                case 47:
                    {
                        Console.WriteLine("Proc47");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            int p = Convert.ToInt32(Console.ReadLine());
                            int q = Convert.ToInt32(Console.ReadLine());
                            int res1, res2;
                            Frac1(a * q + p * b, b * q, out res1, out res2);
                            Console.WriteLine(res1 + "/" + res2);
                        }
                    }
                    break;
                case 48:
                    {
                        Console.WriteLine("Proc48");
                        int a = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(NOK2(a, b));
                        }
                    }
                    break;
                case 49:
                    {
                        Console.WriteLine("Proc49");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(NOD3(a, b, c));
                        Console.WriteLine(NOD3(a, c, d));
                        Console.WriteLine(NOD3(b, c, d));
                    }
                    break;
                case 50:
                    {
                        Console.WriteLine("Proc50");
                        for (int i = 0; i < 5; i++)
                        {
                            int t = Convert.ToInt32(Console.ReadLine());
                            int s, m, h;
                            TimeToHMS(t, out h, out m, out s);
                            Console.WriteLine(h);
                            Console.WriteLine(m);
                            Console.WriteLine(s);
                        }
                    }
                    break;
                case 51:
                    {
                        Console.WriteLine("Proc51");
                        int t = Convert.ToInt32(Console.ReadLine());
                        int h = Convert.ToInt32(Console.ReadLine());
                        int m = Convert.ToInt32(Console.ReadLine());
                        int s = Convert.ToInt32(Console.ReadLine());
                        IncTime(t, ref h, ref m, ref s);
                        Console.WriteLine(h);
                        Console.WriteLine(m);
                        Console.WriteLine(s);
                    }
                    break;
                case 52:
                    {
                        Console.WriteLine("Proc52");
                        for (int i = 0; i < 5; i++)
                        {
                            int y = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(IsLeapYear(y));
                        }
                    }
                    break;
                case 53:
                    {
                        Console.WriteLine("Proc53");
                        int y = Convert.ToInt32(Console.ReadLine());
                        for (byte i = 0; i < 3; i++)
                        {
                            int m = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(MonthDays(m, y));
                        }
                    }
                    break;
                case 54:
                    {
                        Console.WriteLine("Proc54");
                        for (int i = 0; i < 3; i++)
                        {
                            int d = Convert.ToInt32(Console.ReadLine());
                            int m = Convert.ToInt32(Console.ReadLine());
                            int y = Convert.ToInt32(Console.ReadLine());
                            PrevDate(ref d,ref  m, ref y);
                            Console.WriteLine(d);
                            Console.WriteLine(m);
                            Console.WriteLine(y);
                        }
                    }
                    break;
                case 55:
                    {
                        Console.WriteLine("Proc55");
                        for (int i = 0; i < 3; i++)
                        {
                            int d = Convert.ToInt32(Console.ReadLine());
                            int m = Convert.ToInt32(Console.ReadLine());
                            int y = Convert.ToInt32(Console.ReadLine());
                            NextDate(ref d, ref m, ref y);
                            Console.WriteLine(d);
                            Console.WriteLine(m);
                            Console.WriteLine(y);
                        }
                    }
                    break;
                case 56:
                    {
                        Console.WriteLine("Proc56");
                        double xa = Convert.ToDouble(Console.ReadLine());
                        double ya = Convert.ToDouble(Console.ReadLine());
                        for (byte i = 0; i < 3; i++)
                        {
                            double xb = Convert.ToDouble(Console.ReadLine());
                            double yb = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Leng(xa, ya, xb, yb));
                        }
                    }
                    break;
                case 57:
                    {
                        Console.WriteLine("Proc57");
                        double xa = Convert.ToDouble(Console.ReadLine());
                        double ya = Convert.ToDouble(Console.ReadLine());
                        double xb = Convert.ToDouble(Console.ReadLine());
                        double yb = Convert.ToDouble(Console.ReadLine());
                        double xc = Convert.ToDouble(Console.ReadLine());
                        double yc = Convert.ToDouble(Console.ReadLine());
                        double xd = Convert.ToDouble(Console.ReadLine());
                        double yd = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Perim(xa, ya, xb, yb, xc, yc));
                        Console.WriteLine(Perim(xa, ya, xb, yb, xd, yd));
                        Console.WriteLine(Perim(xa, ya, xc, yc, xd, yd));
                    }
                    break;
                case 58:
                    {
                        Console.WriteLine("Proc58");
                        double xa = Convert.ToDouble(Console.ReadLine());
                        double ya = Convert.ToDouble(Console.ReadLine());
                        double xb = Convert.ToDouble(Console.ReadLine());
                        double yb = Convert.ToDouble(Console.ReadLine());
                        double xc = Convert.ToDouble(Console.ReadLine());
                        double yc = Convert.ToDouble(Console.ReadLine());
                        double xd = Convert.ToDouble(Console.ReadLine());
                        double yd = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Area(xa, ya, xb, yb, xc, yc));
                        Console.WriteLine(Area(xa, ya, xb, yb, xd, yd));
                        Console.WriteLine(Area(xa, ya, xc, yc, xd, yd));
                    }
                    break;
                case 59:
                    {
                        Console.WriteLine("Proc59");
                        double xp = Convert.ToDouble(Console.ReadLine());
                        double yp = Convert.ToDouble(Console.ReadLine());
                        double xa = Convert.ToDouble(Console.ReadLine());
                        double ya = Convert.ToDouble(Console.ReadLine());
                        double xb = Convert.ToDouble(Console.ReadLine());
                        double yb = Convert.ToDouble(Console.ReadLine());
                        double xc = Convert.ToDouble(Console.ReadLine());
                        double yc = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Dist(xp, yp, xa, ya, xb, yb));
                        Console.WriteLine(Dist(xp, yp, xa, ya, xc, yc));
                        Console.WriteLine(Dist(xp, yp, xb, yb, xc, yc));
                    }
                    break;
                case 60:
                    {
                        Console.WriteLine("Proc60");
                        double xa = Convert.ToDouble(Console.ReadLine());
                        double ya = Convert.ToDouble(Console.ReadLine());
                        double xb = Convert.ToDouble(Console.ReadLine());
                        double yb = Convert.ToDouble(Console.ReadLine());
                        double xc = Convert.ToDouble(Console.ReadLine());
                        double yc = Convert.ToDouble(Console.ReadLine());
                        double xd = Convert.ToDouble(Console.ReadLine());
                        double yd = Convert.ToDouble(Console.ReadLine());
                        double h1, h2, h3;
                        Heights(xa, ya, xb, yb, xc, yc, out h1, out h2, out h3);
                        Console.WriteLine(h1);
                        Console.WriteLine(h2);
                        Console.WriteLine(h3);
                        Heights(xa, ya, xb, yb, xd, yd, out h1, out h2, out h3);
                        Console.WriteLine(h1);
                        Console.WriteLine(h2);
                        Console.WriteLine(h3);
                        Heights(xa, ya, xc, yc, xd, yd, out h1, out h2, out h3);
                        Console.WriteLine(h1);
                        Console.WriteLine(h2);
                        Console.WriteLine(h3);
                    }
                    break;
            }
        }
    }
}
