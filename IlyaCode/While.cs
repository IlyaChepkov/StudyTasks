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
            }
        }

    }
}
