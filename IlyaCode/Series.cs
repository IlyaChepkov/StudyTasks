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
                case 21:
                    {
                        Console.WriteLine("Series21");
                        int n = Convert.ToInt32(Console.ReadLine());
                        bool b = true;
                        double p = Convert.ToDouble(Console.ReadLine());
                        for (int i = 1; i < n; i++)
                        {
                            double d = Convert.ToDouble(Console.ReadLine());
                            if (p >= d)
                            {
                                b = false;
                            }
                            p = d;
                        }
                        Console.WriteLine(b);
                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("Series22");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double p = Convert.ToDouble(Console.ReadLine());
                        int num = 0;
                        for (int i = 1; i < n; i++)
                        {
                            double d = Convert.ToDouble(Console.ReadLine());
                            if (num == 0 && p <= d)
                            {
                                num = i + 1;
                            }
                            p = d;
                        }
                        Console.WriteLine(num);
                    }
                    break;
                case 23:
                    {
                        Console.WriteLine("Series23");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double p = Convert.ToDouble(Console.ReadLine());
                        double now = Convert.ToDouble(Console.ReadLine());
                        int num = 0;
                        for (int i = 2; i < n; i++)
                        {
                            double next = Convert.ToDouble(Console.ReadLine());
                            if (num == 0 && !((p < now && next < now) || (p > now && next > now)))
                            {
                                num = i + 1;
                            }
                            p = now;
                            now = next;
                        }
                        Console.WriteLine(num);
                    }
                    break;
                case 24:
                    {
                        Console.WriteLine("Series24");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int sum = 0;
                        int nextsum = 0;
                        for (int i = 0; i < n; i++)
                        {
                            int a = Convert.ToInt32(Console.ReadLine());
                            nextsum += a;
                            if (a == 0)
                            {
                                sum = nextsum;
                                nextsum = 0;
                            }
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("Series25");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int sum = 0;
                        int nextsum = 0;
                        bool marker = false;
                        for (int i = 0; i < n; i++)
                        {
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a == 0)
                            {
                                sum += nextsum;
                                nextsum = 0;
                                marker = true;
                            }
                            if (marker)
                            {
                                nextsum += a;
                            }
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 26:
                    {
                        Console.WriteLine("Series26");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            double mul = 1;
                            double a = Convert.ToDouble(Console.ReadLine());
                            for (int j = 0; j < k; j++)
                            {
                                mul *= a;
                            }
                            Console.WriteLine(mul);
                        }
                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("Series27");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            double mul = 1;
                            double a = Convert.ToDouble(Console.ReadLine());
                            for (int j = 0; j < i; j++)
                            {
                                mul *= a;
                            }
                            Console.WriteLine(mul);
                        }
                    }
                    break;
                case 28:
                    {
                        Console.WriteLine("Series28");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            double mul = 1;
                            double a = Convert.ToDouble(Console.ReadLine());
                            for (int j = 0; j < n - i; j++)
                            {
                                mul *= a;
                            }
                            Console.WriteLine(mul);
                        }
                    }
                    break;
                case 29:
                    {
                        Console.WriteLine("Series29");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        int sum = 0;
                        for (int i = 0; i < k; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                sum += Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        Console.WriteLine(sum);
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("Series30");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < n; j++)
                            {
                                sum += Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine(sum);
                        }
                    }
                    break;
                case 31:
                    {
                        Console.WriteLine("Series31");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        for (int i = 0; i < k; i++)
                        {
                            bool b = false;
                            for (int j = 0; j < n; j++)
                            {
                                if (Convert.ToInt32(Console.ReadLine()) == 2)
                                {
                                    b = true;
                                }
                            }
                            if (b)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 32:
                    {
                        Console.WriteLine("Series32");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            int count = 0;
                            for (int j = 1; j <= n; j++)
                            {
                                if (count == 0 && Convert.ToInt32(Console.ReadLine()) == 2)
                                {
                                    count = j;
                                }
                            }
                            Console.WriteLine(count);
                        }
                    }
                    break;
                case 33:
                    {
                        Console.WriteLine("Series33");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            int count = 0;
                            for (int j = 1; j <= n; j++)
                            {
                                if (Convert.ToInt32(Console.ReadLine()) == 2)
                                {
                                    count = j;
                                }
                            }
                            Console.WriteLine(count);
                        }
                    }
                    break;
                case 34:
                    {
                        Console.WriteLine("Series34");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            int sum = 0;
                            bool b = false;
                            for (int j = 1; j <= n; j++)
                            {
                                int a = Convert.ToInt32(Console.ReadLine());
                                sum += a;
                                if (a == 2)
                                {
                                    b = true;
                                }
                            }
                            Console.WriteLine(b ? sum : 0);
                        }
                    }
                    break;
                case 35:
                    {
                        Console.WriteLine("Series35");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int allCount = 0;
                        for (int i = 0; i < k; i++)
                        {
                            int count = 0;
                            for (int j = Convert.ToInt32(Console.ReadLine());
                                j != 0;
                                j = Convert.ToInt32(Console.ReadLine()))
                            {
                                count++;
                            }
                            Console.WriteLine(count);
                            allCount += count;
                        }
                        Console.WriteLine(allCount);
                    }
                    break;
                case 36:
                    {
                        Console.WriteLine("Series36");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        for (int i = 0; i < k; i++)
                        {
                            bool marker = true;
                            int p = Convert.ToInt32(Console.ReadLine());
                            for (int j = Convert.ToInt32(Console.ReadLine());
                                j != 0;
                                j = Convert.ToInt32(Console.ReadLine()))
                            {
                                if (j <= p)
                                {
                                    marker = false;
                                }
                                p = j;
                            }
                            if (marker)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 37:
                    {
                        Console.WriteLine("Series37");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        for (int i = 0; i < k; i++)
                        {
                            bool marker = true;
                            bool sign = true;
                            int first = Convert.ToInt32(Console.ReadLine());
                            int p = Convert.ToInt32(Console.ReadLine());
                            if (first == p)
                            {
                                marker = false;
                            }
                            else
                            {
                                sign = first < p;
                            }
                            for (int j = Convert.ToInt32(Console.ReadLine());
                                j != 0;
                                j = Convert.ToInt32(Console.ReadLine()))
                            {
                                if ((sign && j <= p) || (!sign && p <= j))
                                {
                                    marker = false;
                                }
                                p = j;
                            }
                            if (marker)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 38:
                    {
                        Console.WriteLine("Series38");
                        int k = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            int marker = 0;
                            bool sign = true;
                            int first = Convert.ToInt32(Console.ReadLine());
                            int p = Convert.ToInt32(Console.ReadLine());
                            if (first == p)
                            {
                                marker = 0;
                            }
                            else
                            {
                                if (first < p)
                                {
                                    marker = 1;
                                }
                                else
                                {
                                    marker = -1;
                                }
                                sign = first < p;
                            }
                            for (int j = Convert.ToInt32(Console.ReadLine());
                                j != 0;
                                j = Convert.ToInt32(Console.ReadLine()))
                            {
                                if ((sign && j <= p) || (!sign && p <= j))
                                {
                                    marker = 0;
                                }
                                p = j;
                            }
                            Console.WriteLine(marker);
                        }
                    }
                    break;
                case 39:
                    {
                        Console.WriteLine("Series39");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        for (int i = 0; i < k; i++)
                        {
                            bool marker = true;
                            int p = Convert.ToInt32(Console.ReadLine());
                            int now = Convert.ToInt32(Console.ReadLine());
                            for (int j = Convert.ToInt32(Console.ReadLine());
                                j != 0;
                                j = Convert.ToInt32(Console.ReadLine()))
                            {
                                if (!((j < now && p < now) || ( now < j && now < p)))
                                {
                                    marker = false;
                                }
                                p = now;
                                now = j;
                            }
                            if (marker)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 40:
                    {
                        Console.WriteLine("Series40");
                        int k = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            bool b = true;
                            int count = 0;
                            int marker = 0;
                            int p = Convert.ToInt32(Console.ReadLine());
                            int now = Convert.ToInt32(Console.ReadLine());
                            for (int j = Convert.ToInt32(Console.ReadLine());
                                j != 0;
                                j = Convert.ToInt32(Console.ReadLine()))
                            {
                                if (b && !((j < now && p < now) || (now < j && now < p)))
                                {
                                    marker = ++count;
                                    b= false;
                                }
                                p = now;
                                now = j;
                            }
                            Console.WriteLine(marker == 0 ? count : marker);
                        }
                    }
                    break;
            }
        }
    }
}
