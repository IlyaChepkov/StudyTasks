namespace IlyaCode
{
    internal static class Minmax
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Minmax" + taskNumber);
            switch (taskNumber)
            {
                case 1:
                    MinMax1();
                    break;
                case 2:
                    MinMax2();
                    break;
                case 3:
                    MinMax3();
                    break;
                case 4:
                    MinMax4();
                    break;
                case 5:
                    MinMax5();
                    break;
                case 6:
                    MinMax6();
                    break;
                case 7:
                    MinMax7();
                    break;
                case 8:
                    MinMax8();
                    break;
                case 9:
                    MinMax9();
                    break;
                case 10:
                    MinMax10();
                    break;
                case 11:
                    MinMax11();
                    break;
                case 12:
                    MinMax12();
                    break;
                case 13:
                    MinMax13();
                    break;
                case 14:
                    MinMax14();
                    break;
                case 15:
                    MinMax15();
                    break;
                case 16:
                    MinMax16();
                    break;
                case 17:
                    MinMax17();
                    break;
                case 18:
                    MinMax18();
                    break;
                case 19:
                    MinMax19();
                    break;
                case 20:
                    MinMax20();
                    break;
                case 21:
                    MinMax21();
                    break;
                case 22:
                    MinMax22();
                    break;
                case 23:
                    MinMax23();
                    break;
                case 24:
                    MinMax24();
                    break;
                case 25:
                    MinMax25();
                    break;
                case 26:
                    MinMax26();
                    break;
                case 27:
                    MinMax27();
                    break;
                case 28:
                    MinMax28();
                    break;
                case 29:
                    MinMax29();
                    break;
                case 30:
                    MinMax3();
                    break;
            }
        }

        public static void MinMax1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            double max = min;
            for (int i = 1; i < n; i++)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }

        public static void MinMax2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine())
                       * Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                if (min > a * b)
                {
                    min = a * b;
                }
            }
            Console.WriteLine(min);
        }

        public static void MinMax3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double max = (Convert.ToDouble(Console.ReadLine())
                       + Convert.ToDouble(Console.ReadLine()))
                       * 2;
            for (int i = 1; i < n; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                if (max < (a + b) * 2)
                {
                    max = (a + b) * 2;
                }
            }
            Console.WriteLine(max);
        }

        public static void MinMax4()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            int number = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min > numeric)
                {
                    min = numeric;
                    number = i;
                }
            }
            Console.WriteLine(number);
        }

        public static void MinMax5()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double max = Convert.ToDouble(Console.ReadLine())
                       / Convert.ToDouble(Console.ReadLine());
            int number = 1;
            for (int i = 2; i <= n; i++)
            {
                double m = Convert.ToDouble(Console.ReadLine());
                double v = Convert.ToDouble(Console.ReadLine());
                if (max < m / v)
                {
                    max = m / v;
                    number = i;
                }
            }
            Console.WriteLine(number);
            Console.WriteLine(max);
        }

        public static void MinMax6()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            double max = min;
            int numberMin = 1;
            int numberMax = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min > numeric)
                {
                    min = numeric;
                    numberMin = i;
                }
                if (max <= numeric)
                {
                    max = numeric;
                    numberMax = i;
                }
            }
            Console.WriteLine(numberMin);
            Console.WriteLine(numberMax);
        }

        public static void MinMax7()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            double max = min;
            int numberMin = 1;
            int numberMax = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min >= numeric)
                {
                    min = numeric;
                    numberMin = i;
                }
                if (max < numeric)
                {
                    max = numeric;
                    numberMax = i;
                }
            }
            Console.WriteLine(numberMin);
            Console.WriteLine(numberMax);
        }

        public static void MinMax8()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            int numberFirst = 1;
            int numberLast = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min > numeric)
                {
                    min = numeric;
                    numberFirst = i;
                }
                if (min == numeric)
                {
                    numberLast = i;
                }
            }
            Console.WriteLine(numberFirst);
            Console.WriteLine(numberLast);
        }

        public static void MinMax9()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double max = Convert.ToDouble(Console.ReadLine());
            int numberFirst = 1;
            int numberLast = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (max < numeric)
                {
                    max = numeric;
                    numberFirst = i;
                }
                if (max == numeric)
                {
                    numberLast = i;
                }
            }
            Console.WriteLine(numberFirst);
            Console.WriteLine(numberLast);
        }

        public static void MinMax10()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            double max = min;
            int numberMin = 1;
            int numberMax = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min > numeric)
                {
                    min = numeric;
                    numberMin = i;
                }
                if (max < numeric)
                {
                    max = numeric;
                    numberMax = i;
                }
            }
            Console.WriteLine(numberMin < numberMax ? numberMin : numberMax);
        }

        public static void MinMax11()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            double max = min;
            int numberMin = 1;
            int numberMax = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min >= numeric)
                {
                    min = numeric;
                    numberMin = i;
                }
                if (max <= numeric)
                {
                    max = numeric;
                    numberMax = i;
                }
            }
            Console.WriteLine(numberMin < numberMax ? numberMin : numberMax);
        }
        public static void MinMax12()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = 0;
            for (int i = 1; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if ((min > numeric || min <= 0) && numeric > 0)
                {
                    min = numeric;
                }
            }
            Console.WriteLine(min);
        }

        public static void MinMax13()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double max = 0;
            double number = 0;
            for (int i = 1; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if ((max < numeric || max % 2 == 0) && numeric % 2 == 1)
                {
                    max = numeric;
                    number = i;
                }
            }
            Console.WriteLine(number);
        }

        public static void MinMax14()
        {
            double b = Convert.ToDouble(Console.ReadLine());
            double min = 0;
            int number = 0;
            for (int i = 1; i <= 10; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if ((min > numeric || min <= b) && numeric > b)
                {
                    min = numeric;
                    number = i;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(number);
        }

        public static void MinMax15()
        {
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double max = 0;
            int number = 0;
            for (int i = 1; i <= 10; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if ((max < numeric || max <= b) && (numeric > b && numeric < c))
                {
                    max = numeric;
                    number = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(number);
        }

        public static void MinMax16()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            int numberFirst = 0;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min > numeric)
                {
                    min = numeric;
                    numberFirst = i - 1;
                }
            }
            Console.WriteLine(numberFirst);
        }

        public static void MinMax17()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double max = Convert.ToDouble(Console.ReadLine());
            int numberLast = n - 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (max <= numeric)
                {
                    max = numeric;
                    numberLast = n - i;
                }
            }
            Console.WriteLine(numberLast);
        }

        public static void MinMax18()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double max = Convert.ToDouble(Console.ReadLine());
            int numberFirst = 1;
            int numberLast = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (max < numeric)
                {
                    max = numeric;
                    numberFirst = i;
                }
                if (max == numeric)
                {
                    numberLast = i;
                }
            }
            Console.WriteLine(numberFirst == numberLast ? 0 : numberLast - numberFirst - 1);
        }

        public static void MinMax19()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            int count = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min >= numeric)
                {
                    if (min == numeric)
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                        min = numeric;
                    }
                }
            }
            Console.WriteLine(count);
        }


        public static void MinMax20()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            double max = min;
            int countMin = 1;
            int countMax = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min >= numeric)
                {
                    if (min == numeric)
                    {
                        countMin++;
                    }
                    else
                    {
                        countMin = 1;
                        min = numeric;
                    }
                }
                if (max <= numeric)
                {
                    if (max == numeric)
                    {
                        countMax++;
                    }
                    else
                    {
                        countMax = 1;
                        max = numeric;
                    }
                }
            }
            Console.WriteLine(min == max ? countMin : countMax + countMin);
        }

        public static void MinMax21()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            double max = min;
            int countMin = 1;
            int countMax = 1;
            double sum = min;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                sum += numeric;
                if (min >= numeric)
                {
                    if (min == numeric)
                    {
                        countMin++;
                    }
                    else
                    {
                        countMin = 1;
                        min = numeric;
                    }
                }
                if (max <= numeric)
                {
                    if (max == numeric)
                    {
                        countMax++;
                    }
                    else
                    {
                        countMax = 1;
                        max = numeric;
                    }
                }
            }
            if (min == max)
            {
                Console.WriteLine(0.0 / 0.0);
            }
            else
            {
                sum -= min * countMin + max * countMax;
                Console.WriteLine(sum / (n - countMin - countMax));
            }
        }

        public static void MinMax22()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double minFirst = Convert.ToDouble(Console.ReadLine());
            double minLast = Convert.ToDouble(Console.ReadLine());
            Proc.MinMax(ref minFirst, ref minLast);
            for (int i = 3; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (minLast > numeric)
                {
                    minLast = numeric;
                }
                if (minFirst > numeric)
                {
                    minLast = minFirst;
                    minFirst = numeric;
                }
            }
            Console.WriteLine(minFirst);
            Console.WriteLine(minLast);
        }

        public static void MinMax23()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double maxFirst = Convert.ToDouble(Console.ReadLine());
            double maxMidle = Convert.ToDouble(Console.ReadLine());
            double maxLast = Convert.ToDouble(Console.ReadLine());
            Proc.SortInc3(ref maxLast, ref maxMidle, ref maxFirst);
            for (int i = 4; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (maxFirst < numeric)
                {
                    maxLast = maxMidle;
                    maxMidle = maxFirst;
                    maxFirst = numeric;
                }
                else
                {
                    if (maxMidle < numeric)
                    {
                        maxLast = maxMidle;
                        maxMidle = numeric;
                    }
                    else
                    {
                        if (maxLast < numeric)
                        {
                            maxLast = numeric;
                        }
                    }
                }
            }
            Console.WriteLine(maxFirst);
            Console.WriteLine(maxMidle);
            Console.WriteLine(maxLast);
        }

        public static void MinMax24()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double? maxSum = null;
            double now = Convert.ToDouble(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (!maxSum.HasValue || maxSum < numeric + now)
                {
                    maxSum = numeric + now;
                }
                now = numeric;
            }
            Console.WriteLine(maxSum);
        }
        public static void MinMax25()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double? minMul = null;
            int number = 0;
            double now = Convert.ToDouble(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (!minMul.HasValue || minMul > numeric * now)
                {
                    minMul = numeric * now;
                    number = i;
                }
                now = numeric;
            }
            Console.WriteLine(number - 1);
            Console.WriteLine(number);
        }

        public static void MinMax26()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int maxCount = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (numeric % 2 == 0)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine(maxCount);
        }
        public static void MinMax27()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int maxCount = 1;
            int count = 1;
            int maxNumber = 1;
            int number = 1;
            double now = -1;
            for (int i = 1; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (numeric == now)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxNumber = number;
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                    now = numeric;
                    number = i;
                }
            }
            Console.WriteLine(maxNumber);
        }

        public static void MinMax28()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int maxCount = 0;
            int count = 0;
            int maxNumber = 0;
            int number = 1;
            for (int i = 1; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (numeric == 1)
                {
                    count++;
                    if (count >= maxCount)
                    {
                        maxNumber = number;
                        maxCount = count;
                    }
                }
                else
                {
                    count = 0;
                    number = i + 1;
                }
            }
            Console.WriteLine(maxNumber);
            Console.WriteLine(maxCount);
        }

        public static void MinMax29()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            int maxCount = 1;
            int count = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (min == numeric)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                    if (min > numeric)
                    {
                        maxCount = 1;
                        min = numeric;
                    }
                }
            }
            Console.WriteLine(maxCount);
        }
        public static void MinMax30()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double max = Convert.ToDouble(Console.ReadLine());
            int minCount = 1;
            int count = 1;
            for (int i = 2; i <= n; i++)
            {
                double numeric = Convert.ToDouble(Console.ReadLine());
                if (max == numeric)
                {
                    count++;
                }
                else
                {
                    if (count < minCount)
                    {
                        minCount = count;
                    }
                    count = 1;
                    if (max < numeric)
                    {
                        minCount = 1;
                        max = numeric;
                    }
                }
            }
            Console.WriteLine(minCount);
        }
    }
}
