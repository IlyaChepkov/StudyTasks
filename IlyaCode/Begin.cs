using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal static class Begin
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Begin1");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int p = a * 4;
                        Console.WriteLine(p);
                    }
                    break;
                case 2:
                    {

                        Console.WriteLine("Begin2");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int s = a * a;
                        Console.WriteLine(s);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Begin3");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int s = a * b;
                        int p = 2 * (a + b);
                        Console.WriteLine(s);
                        Console.WriteLine(p);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Begin4");
                        int d = Convert.ToInt32(Console.ReadLine());
                        double l = d * 3.14;
                        Console.WriteLine(l);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Begin5");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int v = a * a * a;
                        Console.WriteLine(v);
                        int s = 6 * (a * a);
                        Console.WriteLine(s);
                    }
                    break;
                case 6:
                    {

                        Console.WriteLine("Begin6");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int v = a * b * c;
                        Console.WriteLine(v);
                        int s = 2 * (a * b + b * c + a * c);
                        Console.WriteLine(s);
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Begin7");
                        int r = Convert.ToInt32(Console.ReadLine());
                        double l = 2 * 3.14 * r;
                        Console.WriteLine(l);
                        double s = 3.14 * r * r;
                        Console.WriteLine(s);
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Begin8");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(((double)(a + b)) / 2);
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Begin9");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(a * b));
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Begin10");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine((a * a) + (b * b));
                        Console.WriteLine((a * a) - (b * b));
                        Console.WriteLine((a * a) * (b * b));
                        Console.WriteLine((a * a) / (b * b));
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Begin11");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Abs(a) + Math.Abs(b));
                        Console.WriteLine(Math.Abs(a) - Math.Abs(b));
                        Console.WriteLine(Math.Abs(a) * Math.Abs(b));
                        Console.WriteLine(Math.Abs(a) / Math.Abs(b));
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Begin12");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        double c = Math.Sqrt(a * a + b * b);
                        Console.WriteLine(c);
                        Console.WriteLine(a + b + c);
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Begin13");
                        int r1 = Convert.ToInt32(Console.ReadLine());
                        int r2 = Convert.ToInt32(Console.ReadLine());
                        double s1 = 3.14 * r1 * r1;
                        Console.WriteLine(s1);
                        double s2 = 3.14 * r2 * r2;
                        Console.WriteLine(s2);
                        double s3 = s1 - s2;
                        Console.WriteLine(s3);
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("Begin14");
                        int l = Convert.ToInt32(Console.ReadLine());
                        double r = l / (2 * 3.14);
                        Console.WriteLine(r);
                        double s = 3.14 * r * r;
                        Console.WriteLine(s);
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Begin15");
                        int s = Convert.ToInt32(Console.ReadLine());
                        double d = Math.Sqrt(s / 3.14) * 2;
                        Console.WriteLine(d);
                        Console.WriteLine(3.14 * d);
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("Begin16");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Abs(x2 - x1));
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("Begin17");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int ac = Math.Abs(a - c);
                        Console.WriteLine(ac);
                        int bc = Math.Abs(b - c);
                        Console.WriteLine(bc);
                        Console.WriteLine(ac + bc);
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("Begin18");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int ac = Math.Abs(a - c);
                        Console.WriteLine(ac);
                        int bc = Math.Abs(b - c);
                        Console.WriteLine(bc); ;
                        Console.WriteLine(ac * bc);
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("Begin19");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        int a = Math.Abs(x1 - x2); //1-я сторона прямоугольника
                        int b = Math.Abs(y1 - y2); //2-я сторона прямоугольника
                        Console.WriteLine((a + b) * 2);
                        Console.WriteLine(a * b);
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Begin20");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("Begin21");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        int x3 = Convert.ToInt32(Console.ReadLine());
                        int y3 = Convert.ToInt32(Console.ReadLine());
                        double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                        double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                        double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
                        double p = (a + b + c) / 2;
                        Console.WriteLine(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("Begin22");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = a;
                        a = b;
                        b = c;
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                    }
                    break;
                case 23:
                    {
                        Console.WriteLine("Begin23");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int d = a;
                        a = c;
                        c = b;
                        b = d;
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    break;
                case 24:
                    {
                        Console.WriteLine("Begin24");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int d = c;
                        c = a;
                        a = b;
                        b = d;
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("Begin25");
                        double x = Convert.ToDouble(Console.ReadLine());
                        double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
                        Console.WriteLine(y);
                    }
                    break;
                case 26:
                    {
                        Console.WriteLine("Begin26");
                        double x = Convert.ToDouble(Console.ReadLine());
                        double y = 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 2;
                        Console.WriteLine(y);
                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("Begin27");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = a * a;
                        Console.WriteLine(b);
                        a = b * b;
                        Console.WriteLine(a);
                        b = a * a;
                        Console.WriteLine(b);
                    }
                    break;
                case 28:
                    {

                        Console.WriteLine("Begin28");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = a * a;
                        Console.WriteLine(b);
                        int c = b * a;
                        Console.WriteLine(c);
                        a = b * c;
                        Console.WriteLine(a);
                        b = a * a;
                        Console.WriteLine(b);
                        c = b * a;
                        Console.WriteLine(c);
                    }
                    break;
                case 29:
                    {
                        Console.WriteLine("Begin29");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(3.14 * a / 180);
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("Begin30");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(r / (3.14 / 180));
                    }
                    break;
                case 31:
                    {
                        Console.WriteLine("Begin31");
                        double f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine((f - 32) * (5.0 / 9.0));
                    }
                    break;
                case 32:
                    {
                        Console.WriteLine("Begin32");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(c / (5.0 / 9.0) + 32);
                    }
                    break;
                case 33:
                    {
                        Console.WriteLine("Begin33");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int a = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int kg = a / x;
                        Console.WriteLine(kg);
                        Console.WriteLine(y * kg);
                    }
                    break;
                case 34:
                    {
                        Console.WriteLine("Begin34");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int a = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int kgX = a / x;
                        int kgY = b / y;
                        Console.WriteLine(kgX);
                        Console.WriteLine(kgY);
                        Console.WriteLine((double)kgX / kgY);
                    }
                    break;
                case 35:
                    {
                        Console.WriteLine("Begin35");
                        int v = Convert.ToInt32(Console.ReadLine());
                        int u = Convert.ToInt32(Console.ReadLine());
                        int t1 = Convert.ToInt32(Console.ReadLine());
                        int t2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine((v * t1) + ((v - u) * t2));
                    }
                    break;
                case 36:
                    {
                        Console.WriteLine("Begin36");
                        int v1 = Convert.ToInt32(Console.ReadLine());
                        int v2 = Convert.ToInt32(Console.ReadLine());
                        int s = Convert.ToInt32(Console.ReadLine());
                        int t = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(s + (t * (v1 + v2)));
                    }
                    break;
                case 37:
                    {
                        Console.WriteLine("Begin37");
                        int v1 = Convert.ToInt32(Console.ReadLine());
                        int v2 = Convert.ToInt32(Console.ReadLine());
                        int s = Convert.ToInt32(Console.ReadLine());
                        int t = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Abs(s - (t * (v1 + v2))));
                    }
                    break;
                case 38:
                    {
                        Console.WriteLine("Begin38");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(-b / a);
                    }
                    break;
                case 39:
                    {
                        Console.WriteLine("Begin39");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double c = Convert.ToDouble(Console.ReadLine());
                        double d = b * b - 4 * a * c;
                        Console.WriteLine((-b - Math.Sqrt(d)) / (2 * a));
                        Console.WriteLine((-b + Math.Sqrt(d)) / (2 * a));
                    }
                    break;
                case 40:
                    {
                        Console.WriteLine("Begin40");
                        double a1 = Convert.ToDouble(Console.ReadLine());
                        double b1 = Convert.ToDouble(Console.ReadLine());
                        double c1 = Convert.ToDouble(Console.ReadLine());
                        double a2 = Convert.ToDouble(Console.ReadLine());
                        double b2 = Convert.ToDouble(Console.ReadLine());
                        double c2 = Convert.ToDouble(Console.ReadLine());
                        double d = a1 * b2 - a2 * b1;
                        Console.WriteLine((c1 * b2 - c2 * b1) / d);
                        Console.WriteLine((a1 * c2 - a2 * c1) / d);
                    }
                    break;
            }
        }
    }
}
