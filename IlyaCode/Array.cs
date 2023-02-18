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
        public static void Array23()
        {
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k - 1; i++)
            {
                sum += array[i];
            }
            for (int i = l; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum / (array.Length - (l - k + 1)));
        }

        public static void Array24()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int d = array[1] - array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] + d != array[i + 1])
                {
                    d = 0;
                    break;
                }
            }
            Console.WriteLine(d);
        }

        public static void Array25()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int q = array[1] / array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] * q != array[i + 1])
                {
                    q = 0;
                    break;
                }
            }
            Console.WriteLine(q);
        }

        public static void Array26()
        {
            int number = 0;
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 2 == array[i + 1] % 2)
                {
                    number = i + 2;
                    break;
                }
            }
            Console.WriteLine(number);
        }

        public static void Array27()
        {
            int number = 0;
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > 0 == array[i + 1] > 0)
                {
                    number = i + 2;
                    break;
                }
            }
            Console.WriteLine(number);
        }

        public static void Array28()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = array[1];
            for (int i = 3; i < array.Length; i += 2)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
        }

        public static void Array29()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0];
            for (int i = 2; i < array.Length; i += 2)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void Array30()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void Array31()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            for (int i = array.Length - 1; i >= 1; i--)
            {
                if (array[i] > array[i - 1])
                {
                    Console.WriteLine(i + 1);
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void Array32()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] > array[i] && array[i] < array[i + 1])
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }

        public static void Array33()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = array.Length - 1; i > 1; i--)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }

        public static void Array34()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int? maxMin = null;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] > array[i] && array[i] < array[i + 1])
                {
                    if (maxMin == null || maxMin < array[i])
                    {
                        maxMin = array[i];
                    }
                }
            }
            if (maxMin != null)
            {
                Console.WriteLine(maxMin);
            }
        }

        public static void Array35()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int? minMax = null;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    if (minMax == null || minMax > array[i])
                    {
                        minMax = array[i];
                    }
                }
            }
            if (minMax != null)
            {
                Console.WriteLine(minMax);
            }
        }

        public static void Array36()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0] > array[^1] ? array[0] : array[^1];
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (!(array[i - 1] < array[i] && array[i] > array[i + 1] ||
                      array[i - 1] > array[i] && array[i] < array[i + 1]))
                {
                    if (max < array[i])
                    {
                        max = array[i];
                    }
                }
            }
            Console.WriteLine(max);
        }

        public static void Array37()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            bool localCount = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    localCount = true;
                }
                else
                {
                    if (localCount)
                    {
                        count++;
                    }
                    localCount = false;
                }
            }
            Console.WriteLine(localCount ? count + 1 : count);
        }

        public static void Array38()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            bool localCount = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    localCount = true;
                }
                else
                {
                    if (localCount)
                    {
                        count++;
                    }
                    localCount = false;
                }
            }
            Console.WriteLine(localCount ? count + 1 : count);
        }

        public static void Array39()
        {
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            bool localCount = false;
            bool localMinCount = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    localCount = true;
                }
                else
                {
                    if (localCount)
                    {
                        count++;
                    }
                    localCount = false;
                }
                if (array[i - 1] > array[i])
                {
                    localMinCount = true;
                }
                else
                {
                    if (localMinCount)
                    {
                        count++;
                    }
                    localMinCount = false;
                }
            }
            Console.WriteLine(localCount || localMinCount ? count + 1 : count);
        }

        public static void Array40()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            double min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - r) < Math.Abs(min - r))
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
        }

        public static void Array41()
        {
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            int index = 1;
            for (int i = 2; i < array.Length; i++)
            {
                if (array[index] + array[index - 1] < array[i] + array[i - 1])
                {
                    index = i;
                }
            }
            Console.WriteLine(array[index - 1]);
            Console.WriteLine(array[index]);
        }

        public static void Array42()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            int index = 1;
            for (int i = 2; i < array.Length; i++)
            {
                if (Math.Abs(array[index] + array[index - 1] - r) > Math.Abs(array[i] + array[i - 1] - r))
                {
                    index = i;
                }
            }
            Console.WriteLine(array[index - 1]);
            Console.WriteLine(array[index]);
        }

        public static void Array43()
        {
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            int count = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void Array44()
        {
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(i + 1);
                        Console.WriteLine(j + 1);
                        return;
                    }
                }
            }
        }

        public static void Array45()
        {
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            int indexI = 0;
            int indexJ = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[indexI] - array[indexJ]) > Math.Abs(array[i] - array[j]))
                    {
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            Console.WriteLine(indexI + 1);
            Console.WriteLine(indexJ + 1);
        }

        public static void Array46()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double[] array = new double[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sum = array[0] + array[1];
            int indexI = 0;
            int indexJ = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i] + array[j] - r) < Math.Abs(sum - r))
                    {
                        indexI = i;
                        indexJ = j;
                        sum = array[i] + array[j];
                    }
                }
            }
            Console.WriteLine(array[indexI]);
            Console.WriteLine(array[indexJ]);
        }
    }
}

