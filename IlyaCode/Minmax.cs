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
            double max= Convert.ToDouble(Console.ReadLine());
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
    }
}
