﻿namespace IlyaCode
{
    internal static class Array
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("Array");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            try
            {
                typeof(Array).GetMethod("Array" + taskNumber).Invoke(null, null);
            }
            catch { }
        }

        public static void Array1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i * 2 + 1;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int mul = 1;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                mul *= 2;
                array[i] = mul;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = a + i * d;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array4()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double[] array = new double[n];
            array[0] = a;
            for (int i = 1; i < n; i++)
            {
                array[i] = array[i - 1] * d;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array5()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i < n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array6()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = array[0] + array[1];
            for (int i = 3; i < n; i++)
            {
                array[i] = array[i - 1] * 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array7()
        {
            string[] array = new string[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array8()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                    k++;
                }
            }
            Console.WriteLine(k);
        }

        public static void Array9()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                    k++;
                }
            }
            Console.WriteLine(k);
        }

        public static void Array10()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        public static void Array11()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = k - 1; i < array.Length; i += k)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array12()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < array.Length; i += 2)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array13()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = array.Length - 1; i >= 0; i -= 2)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array14()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < array.Length; i += 2)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array15()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = array.Length / 2 * 2 - 1; i >= 1; i -= 2)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void Array16()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i % 2 == 0 ? array[i / 2] :
                    array[array.Length - (i + 1) / 2]);
            }
        }

        public static void Array17()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine((i % 4) switch
                {
                    0 => array[i / 2],
                    1 => array[(i + 1) / 2],
                    2 => array[array.Length - (i + 1) / 2],
                    3 => array[array.Length - (i + 1) / 2],
                });
            }
        }

        public static void Array18()
        {
            int[] array = new int[10];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[9])
                {
                    k = array[i];
                    break;
                }
            }
            Console.WriteLine(k);
        }

        public static void Array19()
        {
            int[] array = new int[10];
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[0] < array[i] && array[i] < array[9])
                {
                    number = i + 1;
                    break;
                }
            }
            Console.WriteLine(number);
        }

        public static void Array20()
        {
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            for (int i = k - 1; i < l; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        public static void Array21()
        {
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            for (int i = k - 1; i < l; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum / (l - k + 1));
        }

        public static void Array22()
        {
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            double sumkl = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            for (int i = k - 1; i < l; i++)
            {
                sumkl += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum - sumkl);
        }
    }
}
