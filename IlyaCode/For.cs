using System.Globalization;

namespace IlyaCode
{
    public static class For
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("For1");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            Console.WriteLine(n);
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("For2");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        for (int i = a; i <= b; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine(b - a + 1);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("For3");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        for (int i = b - 1; i > a; i--)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine(b - a - 1);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("For4");
                        double a = Convert.ToDouble(Console.ReadLine());
                        for (double i = a; i <= a * 10; i += a)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("For5");
                        double a = Convert.ToDouble(Console.ReadLine()) / 10;
                        for (double i = a; i <= a * 10; i += a)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("For6");
                        double a = Convert.ToDouble(Console.ReadLine()) / 5;
                        for (double i = a * 6; i <= a * 10; i += a)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("For7");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int sum = 0;
                        for (int i = b; i >= a; i--)
                        {
                            sum += i;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("For8");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int mul = 1;
                        for (int i = b; i >= a; i--)
                        {
                            mul *= i;
                        }
                        Console.WriteLine(mul);
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("For9");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int sum = 0;
                        for (int i = b; i >= a; i--)
                        {
                            sum += i * i;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("For10");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 0;
                        for (double i = 1; i <= n; i++)
                        {
                            sum += 1 / i;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("For11");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = n * n;
                        for (int i = 1; i <= n; i++)
                        {
                            sum += (n + i) * (n + i);
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("For12");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double mul = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            mul *= i / 10 + 1;
                        }
                        Console.WriteLine(mul);
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("For13");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double res = 0;
                        for (int i = 1; i <= n; i += 2)
                        {
                            res += i / 10 + 1;
                        }
                        for (int i = 2; i <= n; i += 2)
                        {
                            res -= i / 10 + 1;
                        }
                        Console.WriteLine(res);
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("For14");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int sum = 0;
                        for (int i = 1; i <= 2 * n - 1; i += 2)
                        {
                            sum += i;
                            Console.WriteLine(sum);
                        }
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("For15");
                        double a = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double mul = 1;
                        for (int i = 0; i < n; i++)
                        {
                            mul *= a;
                        }
                        Console.WriteLine(mul);
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("For16");
                        double a = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double mul = 1;
                        for (int i = 0; i < n; i++)
                        {
                            mul *= a;
                            Console.WriteLine(mul);
                        }
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("For17");
                        double a = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double mul = 1;
                        double sum = 1;
                        for (int i = 0; i < n; i++)
                        {
                            mul *= a;
                            sum += mul;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("For18");
                        double a = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double mul = 1;
                        double sum = 1;
                        sbyte symbol = 1;
                        for (int i = 0; i < n; i++)
                        {
                            symbol *= -1;
                            mul *= a;
                            sum += mul * symbol;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("For19");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double mul = 1;
                        for (int i = 2; i <= n; i++)
                        {
                            mul *= i;
                        }
                        Console.WriteLine(mul);
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("For20");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double mul = 1;
                        double sum = 1;
                        for (int i = 2; i <= n; i++)
                        {
                            mul *= i;
                            sum += mul;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("For21");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 1;
                        double mul = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            mul *= i;
                            sum += 1 / mul;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("For22");
                        double x = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 1;
                        double f = 1;
                        double mul = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            mul *= x;
                            f *= i;
                            sum += mul / f;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 23:
                    {
                        Console.WriteLine("For23");
                        double x = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 1;
                        double f = 2;
                        double mul = x;
                        sbyte symbol = 1;
                        for (int i = 3; i <= 2 * n + 1; i += 2)
                        {
                            symbol *= -1;
                            mul *= x * x;
                            f *= i;
                            sum += symbol * mul / f;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 24:
                    {
                        Console.WriteLine("For24");
                        double x = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 1;
                        double f = 1;
                        double mul = 1;
                        sbyte symbol = 1;
                        for (int i = 2; i <= 2 * n; i += 2)
                        {
                            symbol *= -1;
                            mul *= x * x;
                            f *= i;
                            sum += symbol * mul / f;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("For25");
                        double x = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 0;
                        double mul = 1;
                        sbyte symbol = -1;
                        for (int i = 1; i <= n; i++)
                        {
                            symbol *= -1;
                            mul *= x;
                            sum += symbol * mul / i;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 26:
                    {
                        Console.WriteLine("For26");
                        double x = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = x;
                        double mul = x;
                        sbyte symbol = -1;
                        for (int i = 3; i <= 2 * n + 1; i += 2)
                        {
                            symbol *= -1;
                            mul *= x * x;
                            sum += symbol * mul / i;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("For27");
                        double x = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = x;
                        double mul = x;
                        double oddMul = 1;
                        double evenMul = 1;
                        for (int i = 3; i <= 2 * n + 1; i += 2)
                        {
                            evenMul *= i - 1;
                            oddMul *= i - 2;
                            mul *= x * x;
                            sum += oddMul * mul / (evenMul * i);
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 28:
                    {
                        Console.WriteLine("For28");
                        double x = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 1;
                        double mul = 1;
                        double oddMul = 1;
                        double evenMul = 1;
                        sbyte symbol = -1;
                        for (int i = 1; i <= n; i++)
                        {
                            symbol *= -1;
                            evenMul *= i * 2;
                            oddMul *= i == 1 ? 1 : 2 * i - 3;
                            mul *= x;
                            sum += symbol * oddMul * mul / (evenMul);
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 29:
                    {
                        Console.WriteLine("For29");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double h = (b - a) / n;
                        Console.WriteLine(h);
                        for (double i = a; i < b; i += h)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine(b);
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("For30");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double h = (b - a) / n;
                        Console.WriteLine(h);
                        for (double i = a; i < b; i += h)
                        {
                            Console.WriteLine(1 - Math.Sin(i));
                        }
                        Console.WriteLine(1 - Math.Sin(b));
                    }
                    break;
                case 31:
                    {
                        Console.WriteLine("For31");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double a = 2;
                        for (int i = 1; i <= n; i++)
                        {
                            a = 2 + 1 / a;
                            Console.WriteLine(a);
                        }
                    }
                    break;
                case 32:
                    {
                        Console.WriteLine("For32");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double a = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            a = (a + 1) / i;
                            Console.WriteLine(a);
                        }
                    }
                    break;
                case 33:
                    {
                        Console.WriteLine("For33");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int fk_1 = 1;
                        int fk_2 = 1;
                        Console.WriteLine(fk_2);
                        Console.WriteLine(fk_1);
                        for (int i = 3; i <= n; i++)
                        {
                            int fk = fk_2 + fk_1;
                            Console.WriteLine(fk);
                            fk_2 = fk_1;
                            fk_1 = fk;
                        }
                    }
                    break;
                case 34:
                    {
                        Console.WriteLine("For34");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int ak_1 = 2;
                        int ak_2 = 1;
                        Console.WriteLine(ak_2);
                        Console.WriteLine(ak_1);
                        for (int i = 3; i <= n; i++)
                        {
                            int ak = (ak_2 + 2 * ak_1) / 3;
                            Console.WriteLine(ak);
                            ak_2 = ak_1;
                            ak_1 = ak;
                        }
                    }
                    break;
                case 35:
                    {
                        Console.WriteLine("For15");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int ak_1 = 3;
                        int ak_2 = 2;
                        int ak_3 = 1;
                        Console.WriteLine(ak_3);
                        Console.WriteLine(ak_2);
                        Console.WriteLine(ak_1);
                        for (int i = 4; i <= n; i++)
                        {
                            int ak = ak_1 + ak_2 - 2 * ak_3;
                            Console.WriteLine(ak);
                            ak_3 = ak_2;
                            ak_2 = ak_1;
                            ak_1 = ak;
                        }
                    }
                    break;
                case 36:
                    {
                        Console.WriteLine("For36");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int k = Convert.ToInt32(Console.ReadLine());
                        double sum = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            double mul = 1;
                            for (int j = 1; j <= k; j++)
                            {
                                mul *= i;
                            }
                            sum += mul;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 37:
                    {
                        Console.WriteLine("For37");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            double mul = 1;
                            for (int j = 1; j <= i; j++)
                            {
                                mul *= i;
                            }
                            sum += mul;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 38:
                    {
                        Console.WriteLine("For18");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            double mul = 1;
                            for (int j = 1; j <= n - i + 1; j++)
                            {
                                mul *= i;
                            }
                            sum += mul;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 39:
                    {
                        Console.WriteLine("For39");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        for (int i = a; i <= b; i++)
                        {
                            for ( int j = 1; j <= i; j++)
                            Console.Write(i + " ");
                            Console.WriteLine();
                        }
                    }
                    break;
                case 40:
                    {
                        Console.WriteLine("For40");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        for (int i = a; i <= b; i++)
                        {
                            for (int j = 1; j <= a - (a - 1); j++)
                                Console.Write(i + " ");
                            Console.WriteLine();
                        }
                    }
                    break;
            }
        }
    }
}
