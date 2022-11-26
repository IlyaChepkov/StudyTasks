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
                        Console.WriteLine("For5");
                        double a = Convert.ToDouble(Console.ReadLine()) / 10;
                        for (double i = a; i <= a * 10; i += a)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("For6");
                        double a = Convert.ToDouble(Console.ReadLine()) / 5;
                        for (double i = a * 6; i <= a * 10; i += a)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 17:
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
                case 18:
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
                case 19:
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
                case 20:
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
            }
        }
    }
}
