namespace IlyaCode
{
    internal static class Series
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Series1");
                        double sum = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            sum += Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Series2");
                        double mul = 1;
                        for (int i = 0; i < 10; i++)
                        {
                            mul *= Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine(mul);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Series3");
                        double sum = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            sum += Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine(sum / 10);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Series4");
                        double sum = 0;
                        double mul = 1;
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            mul *= a;
                            sum += a;
                        }
                        Console.WriteLine(sum);
                        Console.WriteLine(mul);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Series5");
                        double sum = 0;
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine((int)a);
                            sum += (int)a;
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Series6");
                        double mul = 1;
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(a - (int)a);
                            mul *= a - (int)a;
                        }
                        Console.WriteLine(mul);
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Series7");
                        double sum = 0;
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Math.Round(a));
                            sum += Math.Round(a);
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Series8");
                        int count = 0;
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a % 2 == 0)
                            {
                                Console.WriteLine(a);
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Series9");
                        int count = 0;
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a % 2 == 1)
                            {
                                Console.WriteLine(i + 1);
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Series10");
                        int n = Convert.ToInt32(Console.ReadLine());
                        bool b = false;
                        for (int i = 0; i < n; i++)
                        {
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a > 0)
                            {
                                b = true;
                                break;
                            }
                        }
                        Console.WriteLine(b);
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Series11");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        bool b = false;
                        for (int i = 0; i < n; i++)
                        {
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a < k)
                            {
                                b = true;
                                break;
                            }
                        }
                        Console.WriteLine(b);
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Series12");
                        int count = 0;
                        var input = Console.ReadLine();
                        while (int.Parse(input) != 0)
                        {
                            count++;
                            input = Console.ReadLine();
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Series13");
                        int sum = 0;
                        var input = Convert.ToInt32(Console.ReadLine());
                        while (input != 0)
                        {
                            if (input % 2 == 0 && input > 0)
                            {
                                sum += input;
                            }
                            input = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("Series14");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int input = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        while (input != 0)
                        {
                            if (input < k)
                            {
                                count++;
                            }
                            input = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Series15");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int input = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        bool b = true;
                        for (int i = 1; input != 0;
                            i++, input = Convert.ToInt32(Console.ReadLine()))
                        {
                            if (b && input > k)
                            {
                                count = i;
                                b = false;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("Series16");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int input = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        for (int i = 1; input != 0;
                            i++, input = Convert.ToInt32(Console.ReadLine()))
                        {
                            if (input > k)
                            {
                                count = i;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("Series17");
                        double b = Convert.ToDouble(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        bool marker = true;
                        for (int i = 0; i < n; i++)
                        {
                            double d = Convert.ToDouble(Console.ReadLine());
                            if (marker && d > b)
                            {
                                Console.WriteLine(b);
                                marker = false;
                            }
                            Console.WriteLine(d);
                        }
                        if (marker)
                        {
                            Console.WriteLine(b);
                        }
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("Series18");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int? b = null;
                        for (int i = 0; i < n; i++)
                        {
                            int input = Convert.ToInt32(Console.ReadLine());
                            if (input != b)
                            {
                                Console.WriteLine(input);
                                b = input;
                            }
                        }
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("Series19");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int k = 0;
                        for (int i = 1; i < n; i++)
                        {
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a < b)
                            {
                                Console.WriteLine(a);
                                k++;
                            }
                            b = a;
                        }
                        Console.WriteLine(k);
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Series20");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int k = 0;
                        for (int i = 1; i < n; i++)
                        {
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (b < a)
                            {
                                Console.WriteLine(b);
                                k++;
                            }
                            b = a;
                        }
                        Console.WriteLine(k);
                    }
                    break;
            }
        }
    }
}
