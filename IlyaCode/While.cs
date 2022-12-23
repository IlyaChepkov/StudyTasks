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
            }
        }

    }
}
