using System.Diagnostics.CodeAnalysis;

namespace IlyaCode
{
    public static class While
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("While1");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        while (a > b)
                        {
                            a -= b;
                        }
                        Console.WriteLine(a);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("While2");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        while (a > b)
                        {
                            a -= b;
                            count++;
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("While3");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int k = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        while (n > k)
                        {
                            n -= k;
                            count++;
                        }
                        Console.WriteLine(count);
                        Console.WriteLine(n);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("While4");
                        int n = Convert.ToInt32(Console.ReadLine());
                        while (n > 1 && n % 3 == 0)
                        {
                            n /= 3;
                        }
                        Console.WriteLine(n == 1);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("While5");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        while (n > 1)
                        {
                            n /= 2;
                            count++;
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("While6");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double count = 1;
                        while (n > 0)
                        {
                            count *= n;
                            n -= 2;
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("While7");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int k = 2;
                        while (n >= k * k)
                        {
                            k++;
                        }
                        Console.WriteLine(k);
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("While8");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int k = 2;
                        while (n >= k * k)
                        {
                            k++;
                        }
                        Console.WriteLine(k - 1);
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("While9");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int k = 1;
                        int pow = 3;
                        while (n >= pow)
                        {
                            k++;
                            pow *= 3;
                        }
                        Console.WriteLine(k);
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("While10");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int k = 1;
                        int pow = 3;
                        while (n >= pow)
                        {
                            k++;
                            pow *= 3;
                        }
                        Console.WriteLine(k - 1);
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("While11");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int k = 0;
                        int sum = 0;
                        while (n >= sum)
                        {
                            k++;
                            sum += k;
                        }
                        Console.WriteLine(k);
                        Console.WriteLine(sum);
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("While12");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int k = 0;
                        int sum = 0;
                        while (n >= sum)
                        {
                            k++;
                            sum += k;
                        }
                        Console.WriteLine(k - 1);
                        Console.WriteLine(sum - k);
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("While13");
                        double a = Convert.ToDouble(Console.ReadLine());
                        int k = 0;
                        double sum = 0;
                        while (a >= sum)
                        {
                            k++;
                            sum += 1.0 / k;
                        }
                        Console.WriteLine(k);
                        Console.WriteLine(sum);
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("While14");
                        double a = Convert.ToDouble(Console.ReadLine());
                        int k = 0;
                        double sum = 0;
                        while (a >= sum)
                        {
                            k++;
                            sum += 1.0 / k;
                        }
                        Console.WriteLine(k - 1);
                        Console.WriteLine(sum - 1.0 / k);
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("While15");
                        double p = Convert.ToDouble(Console.ReadLine()) / 100;
                        int k = 0;
                        double s = 1000;
                        while (s <= 1100)
                        {
                            s += s * p;
                            k++;
                        }
                        Console.WriteLine(k);
                        Console.WriteLine(s);
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("While16");
                        double p = Convert.ToDouble(Console.ReadLine()) / 100;
                        int k = 0;
                        double s = 10;
                        double sum = 0;
                        while (sum <= 200)
                        {
                            sum += s;
                            s += s * p;
                            k++;
                        }
                        Console.WriteLine(k);
                        Console.WriteLine(s);
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("While17");
                        int n = Convert.ToInt32(Console.ReadLine());
                        while (n > 0)
                        {
                            Console.Write(n % 10);
                            n /= 10;
                        }
                        Console.WriteLine();
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("While18");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        int sum = 0;
                        while (n > 0)
                        {
                            count++;
                            sum += n % 10;
                            n /= 10;
                        }
                        Console.WriteLine(count);
                        Console.WriteLine(sum);
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("While19");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int sum = 0;
                        while (n > 0)
                        {
                            sum *= 10;
                            sum += n % 10;
                            n /= 10;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("While20");
                        int n = Convert.ToInt32(Console.ReadLine());
                        bool b = false;
                        while (n > 0)
                        {
                            if (n % 10 == 2)
                            {
                                b = true;
                                break;
                            }
                            n /= 10;
                        }
                        Console.WriteLine(b);
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("While21");
                        int n = Convert.ToInt32(Console.ReadLine());
                        bool b = false;
                        while (n > 0)
                        {
                            if (n % 10 % 2 == 1)
                            {
                                b = true;
                                break;
                            }
                            n /= 10;
                        }
                        Console.WriteLine(b);
                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("While22");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int sqrt = (int)Math.Sqrt(n);
                        bool b = false;
                        while (sqrt >= 2)
                        { 
                            if(n % sqrt == 0)
                            {
                                b = true;
                                break;
                            }
                            sqrt--;
                        }
                        Console.WriteLine(!b);
                    }
                    break;
                case 23:
                    {
                        Console.WriteLine("While23");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        while (b != 0)
                        {
                            int r = a % b;
                            a = b;
                            b = r;
                        }
                        Console.WriteLine(a);
                    }
                    break;
                case 24:
                    {
                        Console.WriteLine("While24");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int f1 = 1;
                        int f2 = 1;
                        while (f1 <  n)
                        {
                            int f = f1 + f2;
                            f2 = f1;
                            f1 = f;
                        }
                        Console.WriteLine(n == f1);
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("While25");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int f1 = 1;
                        int f2 = 1;
                        while (f1 <= n)
                        {
                            int f = f1 + f2;
                            f2 = f1;
                            f1 = f;
                        }
                        Console.WriteLine(f1);
                    }
                    break;
                case 26:
                    {
                        Console.WriteLine("While26");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int f1 = 1;
                        int f2 = 1;
                        while (f1 != n)
                        {
                            int f = f1 + f2;
                            f2 = f1;
                            f1 = f;
                        }
                        Console.WriteLine(f2);
                        Console.WriteLine(f2 + f1);
                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("While27");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int f1 = 1;
                        int f2 = 1;
                        int k = 2;
                        while (f1 != n)
                        {
                            k++;
                            int f = f1 + f2;
                            f2 = f1;
                            f1 = f;
                        }
                        Console.WriteLine(k);
                    }
                    break;
                case 28:
                    {
                        Console.WriteLine("While28");
                        double e = Convert.ToDouble(Console.ReadLine());
                        double ak = 2;
                        double ak1 = 0;
                        int k = 1;
                        do
                        {
                            k++;
                            ak1 = ak;
                            ak = 2 + 1 / ak1;
                        }
                        while (Math.Abs(ak - ak1) >= e);
                        
                        Console.WriteLine(k);
                        Console.WriteLine(ak1);
                        Console.WriteLine(ak);
                    }
                    break;
                case 29:
                    {
                        Console.WriteLine("While29");
                        double e = Convert.ToDouble(Console.ReadLine());
                        double ak = 2;
                        double ak1 = 1;
                        double ak2 = 0;
                        int k = 2;
                        while (Math.Abs(ak - ak1) >= e)
                        {
                            k++;
                            ak2 = ak1;
                            ak1 = ak;
                            ak = (ak2 + 2 * ak1) / 3;
                        }
                        Console.WriteLine(k);
                        Console.WriteLine(ak1);
                        Console.WriteLine(ak);
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("While30");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double c = Convert.ToDouble(Console.ReadLine());
                        int d = 0;
                        while (a > c)
                        {
                            d++;
                            a -= c;
                        }
                        int res = 0;
                        while (b > c)
                        {
                            b -= c;
                            res += d;
                        }
                        Console.WriteLine(res);
                    }
                    break;
            }
        }

    }
}
