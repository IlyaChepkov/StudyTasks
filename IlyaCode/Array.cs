using System;
using System.Reflection;

namespace IlyaCode
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = k - 1; i < array.Length; i += k)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array12()
        {
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i < array.Length; i += 2)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array13()
        {
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = array.Length - 1; i >= 0; i -= 2)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Array14()
        {
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i % 2 == 0 ? array[i / 2] :
                    array[array.Length - (i + 1) / 2]);
            }
        }

        public static void Array17()
        {
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(10);
            int k = 0;
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
            int[] array = IntInput(10);
            int number = 0;
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double sum = 0;
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double sum = 0;
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double sumkl = 0;
            double sum = 0;
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double sum = 0;
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            int[] array = IntInput(Convert.ToInt32(Console.ReadLine()));
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
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
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
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

        public static void Array47()
        {
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int count = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count--;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }
        public static void Array48()
        {
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int max = 1;
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (max < count)
                {
                    max = count;
                }
            }
            Console.WriteLine(max);
        }

        public static void Array49()
        {
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array.Length && array[i] < 1)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(j + 1);
                        return;
                    }
                }
            }
            Console.WriteLine(0);
        }
        public static void Array50()
        {
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        public static void Array51()
        {

            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = DoubleInput(a.Length);
            for (int i = 0; i < a.Length; i++)
            {
                Proc.Swap(ref a[i], ref b[i]);
            }
            Output(a);
            Output(b);
        }

        public static void Array52()
        {

            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = new double[a.Length];
            for (int i = 0; i < b.Length; i++)
            {
                if (a[i] < 5)
                {
                    b[i] = a[i] * 2;
                }
                else
                {
                    b[i] = a[i] / 2;
                }
            }
            Output(b);
        }

        public static void Array53()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = DoubleInput(a.Length);
            double[] c = new double[a.Length];
            for (int i = 0; i < c.Length; i++)
            {
                if (b[i] > a[i])
                {
                    c[i] = b[i];
                }
                else
                {
                    c[i] = a[i];
                }
            }
            Output(c);
        }

        public static void Array54()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    count++;
                }
            }
            double[] b = new double[count];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[^count] = a[i];
                    count--;
                }
            }
            Console.WriteLine(b.Length);
            Output(b);
        }

        public static void Array55()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = new double[a.Length / 2];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i * 2];
            }
            Console.WriteLine(b.Length);
            Output(b);
        }

        public static void Array56()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = new double[a.Length / 3];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i * 3 + 2];
            }
            Console.WriteLine(b.Length);
            Output(b);
        }

        public static void Array57()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = new double[a.Length];
            for (int i = 0; i < b.Length / 2; i++)
            {
                b[i] = a[i * 2 + 1];

            }
            for (int i = b.Length / 2; i < b.Length; i++)
            {
                b[i] = a[(i - b.Length / 2) * 2];
            }
            Output(b);
        }
        public static void Array58()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = new double[a.Length];
            double sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += a[i];
                b[i] = sum;
            }
            Output(b);
        }
        public static void Array59()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = new double[a.Length];
            double sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += a[i];
                b[i] = sum / (i + 1);
            }
            Output(b);
        }
        public static void Array60()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = new double[a.Length];
            double sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += a[^(i + 1)];
                b[^(i + 1)] = sum;
            }
            Output(b);
        }
        public static void Array61()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double[] b = new double[a.Length];
            double sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += a[^(i + 1)];
                b[^(i + 1)] = sum / (i + 1);
            }
            Output(b);
        }
        public static void Array62()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int pCount = 0;
            int nCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    pCount++;
                }
                else
                {
                    if (a[i] < 0)
                    {
                        nCount++;
                    }
                }
            }
            double[] b = new double[pCount];
            double[] c = new double[nCount];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    b[^pCount] = a[i];
                    pCount--;
                }
                else
                {
                    if (a[i] < 0)
                    {
                        c[^nCount] = a[i];
                        nCount--;
                    }
                }
            }
            Console.WriteLine(b.Length);
            Output(b);
            Console.WriteLine(c.Length);
            Output(c);
        }
        public static void Array63()
        {
            double[] a = DoubleInput(5);
            double[] b = DoubleInput(5);
            double[] c = new double[10];
            for (int i = 0, j = 0, k = 0; i < 10; i++)
            {
                if (k == 5)
                {
                    c[i] = a[j];
                    j++;
                    continue;
                }
                if (j == 5)
                {
                    c[i] = b[k];
                    k++;
                    continue;
                }
                if (a[j] < b[k])
                {
                    c[i] = a[j];
                    j++;
                }
                else
                {
                    c[i] = b[k];
                    k++;
                }
            }
            Output(c);
        }
        public static void Array64()
        {
            int[] a = IntInput(Convert.ToInt32(Console.ReadLine()));
            int[] b = IntInput(Convert.ToInt32(Console.ReadLine()));
            int[] c = IntInput(Convert.ToInt32(Console.ReadLine()));
            int[] d = Concat(Concat(a, b), c);
            Output(d);
        }
        public static void Array65()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            double ak = a[k];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += ak;
            }
            Output(a);
        }
        public static void Array66()
        {
            int[] a = IntInput(Convert.ToInt32(Console.ReadLine()));
            int firstEven = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    if (firstEven == 1)
                    {
                        firstEven = a[i];
                    }
                    a[i] += firstEven;
                }
            }
            Output(a);
        }
        public static void Array67()
        {
            int[] a = IntInput(Convert.ToInt32(Console.ReadLine()));
            int lastOdd = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[^(i + 1)] % 2 != 0)
                {
                    if (lastOdd == 0)
                    {
                        lastOdd = a[^(i + 1)];
                    }
                    a[^(i + 1)] += lastOdd;
                }
            }
            Output(a);
        }
        public static void Array68()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int min = 0;
            int max = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[min])
                {
                    min = i;
                }
                if (a[i] > a[max])
                {
                    max = i;
                }
            }
            Proc.Swap(ref a[min], ref a[max]);
            Output(a);
        }
        public static void Array69()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i < a.Length; i += 2)
            {
                Proc.Swap(ref a[i], ref a[i - 1]);
            }
            Output(a);
        }
        public static void Array70()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < a.Length / 2; i++)
            {
                Proc.Swap(ref a[i], ref a[a.Length / 2 + i]);
            }
            Output(a);
        }
        public static void Array71()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < a.Length / 2; i++)
            {
                Proc.Swap(ref a[i], ref a[^(i + 1)]);
            }
            Output(a);
        }
        public static void Array72()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            int l = Convert.ToInt32(Console.ReadLine()) - 1;
            for (; k < l; k++, l--)
            {
                Proc.Swap(ref a[k], ref a[l]);
            }
            Output(a);
        }
        public static void Array73()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine()) - 2;
            for (; k < l; k++, l--)
            {
                Proc.Swap(ref a[k], ref a[l]);
            }
            Output(a);
        }
        public static void Array74()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int min = 0;
            int max = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[min])
                {
                    min = i;
                }
                if (a[i] > a[max])
                {
                    max = i;
                }
            }
            if (min > max)
            {
                Proc.Swap(ref min, ref max);
            }
            min++;
            max--;
            for (; min <= max; min++, max--)
            {
                a[min] = 0;
                a[max] = 0;
            }
            Output(a);
        }
        public static void Array75()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int min = 0;
            int max = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[min])
                {
                    min = i;
                }
                if (a[i] > a[max])
                {
                    max = i;
                }
            }
            if (min > max)
            {
                Proc.Swap(ref min, ref max);
            }
            for (; min < max; min++, max--)
            {
                Proc.Swap(ref a[min], ref a[max]);
            }
            Output(a);
        }
        public static void Array76()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i] > a[i - 1] && a[i] > a[i + 1])
                {
                    a[i] = 0;
                    i++;
                }
            }
            Output(a);
        }
        public static void Array77()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i] < a[i - 1] && a[i] < a[i + 1])
                {
                    a[i] = a[i] * a[i];
                    i++;
                }
            }
            Output(a);
        }
        public static void Array78()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double prev = a[0];
            a[0] = (a[0] + a[1]) / 2;
            for (int i = 1; i < a.Length - 1; i++)
            {
                double now = a[i];
                a[i] = (prev + a[i] + a[i + 1]) / 3;
                prev = now;
            }
            a[^1] = (a[^1] + prev) / 2;
            Output(a);
        }
        public static void Array79()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i < a.Length; i++)
            {
                a[^i] = a[^(i + 1)];
            }
            a[0] = 0;
            Output(a);
        }
        public static void Array80()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            a[^1] = 0;
            Output(a);
        }
        public static void Array81()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i + k <= a.Length; i++)
            {
                a[^i] = a[^(k + i)];
            }
            for (int i = 0; i < k; i++)
            {
                a[i] = 0;
            }
            Output(a);
        }
        public static void Array82()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i + k < a.Length; i++)
            {
                a[i] = a[k + i];
            }
            for (int i = 1; i <= k; i++)
            {
                a[^i] = 0;
            }
            Output(a);
        }
        public static void Array83()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double prev = a[^1];
            for (int i = 1; i < a.Length; i++)
            {
                a[^i] = a[^(i + 1)];
            }
            a[0] = prev;
            Output(a);
        }
        public static void Array84()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            double prev = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            a[^1] = prev;
            Output(a);
        }
        public static void Array85()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) % a.Length;
            double[] prevs = new double[k];
            for (int i = 1; i <= k; i++)
            {
                prevs[^i] = a[^i];
            }
            for (int i = 1; i + k <= a.Length; i++)
            {
                a[^i] = a[^(k + i)];
            }
            for (int i = 0; i < k; i++)
            {
                a[i] = prevs[i];
            }
            Output(a);
        }
        public static void Array86()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) % a.Length;
            double[] prevs = new double[k];
            for (int i = 0; i < k; i++)
            {
                prevs[i] = a[i];
            }
            for (int i = 0; i + k < a.Length; i++)
            {
                a[i] = a[k + i];
            }
            for (int i = 1; i <= k; i++)
            {
                a[^i] = prevs[^i];
            }
            Output(a);
        }
        public static void Array87()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] > a[i])
                {
                    Proc.Swap(ref a[i - 1], ref a[i]);
                }
                else
                {
                    break;
                }
            }
            Output(a);
        }
        public static void Array88()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 2; i < a.Length; i++)
            {
                if (a[^(i - 1)] < a[^i])
                {
                    Proc.Swap(ref a[^(i - 1)], ref a[^i]);
                }
                else
                {
                    break;
                }
            }
            Output(a);
        }
        public static void Array89()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] < a[i])
                {
                    if (i + 1 < a.Length)
                    {
                        if (a[i - 1] < a[1 + 1])
                        {
                            for (int j = i; j < a.Length; j++)
                            {
                                if (a[j - 1] < a[j])
                                {
                                    Proc.Swap(ref a[j - 1], ref a[j]);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            for (int j = i; j < a.Length; j++)
                            {
                                if (a[^(j - 1)] > a[^j])
                                {
                                    Proc.Swap(ref a[^(j - 1)], ref a[^j]);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Proc.Swap(ref a[i - 1], ref a[i]);
                    }
                    break;
                }
            }
            Output(a);
        }

        public static void Array90()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            a = RemoveAt(a, Convert.ToInt32(Console.ReadLine()));
            Output(a);
        }

        public static void Array91()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            a = RemoveRange(a, k, l - k + 1);
            Console.WriteLine(a.Length);
            Output(a);
        }
        public static void Array92()
        {
            int[] a = IntInput(Convert.ToInt32(Console.ReadLine()));
            int countEven = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    countEven++;
                }
            }
            int[] b = new int[countEven];
            countEven = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (a[i + countEven] % 2 == 1)
                {
                    countEven++;
                    i--;
                }
                else
                {
                    b[i] = a[i + countEven];
                }
            }
            Console.WriteLine(b.Length);
            Output(b);
        }
        public static void Array93()
        {
            int[] a = IntInput(Convert.ToInt32(Console.ReadLine()));
            int[] b = new int[a.Length / 2 + a.Length % 2];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i * 2];
            }
            Output(a);
        }
        public static void Array94()
        {
            int[] a = IntInput(Convert.ToInt32(Console.ReadLine()));
            int[] b = new int[a.Length / 2 + a.Length % 2];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i * 2 + 1];
            }
            Output(a);
        }
        public static void Array95()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    a = RemoveAt(a, i + 1);
                    i--;
                }
            }
            Output(a);
        }
        public static void Array96()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        a = RemoveAt(a, j);
                        j--;
                    }
                }
            }
            Output(a);
        }
        public static void Array97()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = a.Length - 1; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        a = RemoveAt(a, j);
                        i--;
                    }
                }
            }
            Output(a);
        }
        public static void Array98()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < a.Length - 1; i++)
            {
                int count = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                if (count < 3)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            a = RemoveAt(a, j);
                            j--;
                        }
                    }
                    a = RemoveAt(a, i);
                    i--;
                }
            }
            Output(a);
        }
        public static void Array99()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < a.Length - 1; i++)
            {
                int count = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                if (count > 2)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            a = RemoveAt(a, j);
                            j--;
                        }
                    }
                    a = RemoveAt(a, i);
                    i--;
                }
            }
            Output(a);
        }
        public static void Array100()
        {
            double[] a = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < a.Length - 1; i++)
            {
                int count = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            a = RemoveAt(a, j);
                            j--;
                        }
                    }
                    a = RemoveAt(a, i);
                    i--;
                }
            }
            Output(a);
        }
        public static void Array101()
        {
            double[] boels = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            boels = Insert(boels, index, 0);
            Output(boels);
        }
        public static void Array102()
        {
            double[] boels = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int index = Convert.ToInt32(Console.ReadLine());
            boels = Insert(boels, index, 0);
            Output(boels);
        }
        public static void Array103()
        {
            double[] boels = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int min = 0;
            int max = 0;
            for (int i = 1; i < boels.Length; i++)
            {
                if (boels[min] > boels[i])
                {
                    min = i;
                }
                if (boels[max] < boels[i])
                {
                    max = i;
                }
            }
            if (min < max)
            {
                boels = Insert(boels, min, 0);
                boels = Insert(boels, max + 1, 0);
            }
            else
            {
                boels = Insert(boels, max, 0);
                boels = Insert(boels, min + 1, 0);
            }
            Output(boels);
        }
        public static void Array104()
        {
            double[] boels = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            int countBoels = Convert.ToInt32(Console.ReadLine());
            boels = InsertRange(boels, index, new double[countBoels]);
            Output(boels);
        }
        public static void Array105()
        {
            double[] boels = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            int index = Convert.ToInt32(Console.ReadLine());
            int countBoels = Convert.ToInt32(Console.ReadLine());
            boels = InsertRange(boels, index, new double[countBoels]);
            Output(boels);
        }
        public static void Array106()
        {
            string[] assets = StringInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i < assets.Length; i += 3)
            {
                assets = Insert(assets, i, assets[i]);
            }
            Output(assets);
        }
        public static void Array107()
        {
            string[] assets = StringInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < assets.Length; i += 4)
            {
                assets = Insert(assets, i, assets[i]);
                assets = Insert(assets, i, assets[i]);
            }
            Output(assets);
        }
        public static void Array108()
        {
            double[] t = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > 0)
                {
                    Insert(t, i, 0);
                    i++;
                }
            }
            Output(t);
        }
        public static void Array109()
        {
            double[] t = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < 0)
                {
                    Insert(t, i + 1, 0);
                    i++;
                }
            }
            Output(t);
        }
        public static void Array110()
        {
            int[] assets = IntInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < assets.Length; i++)
            {
                if (assets[i] % 2 == 0)
                {
                    Insert(assets, i, assets[i]);
                    i++;
                }
            }
            Output(assets);
        }
        public static void Array111()
        {
            int[] assets = IntInput(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < assets.Length; i++)
            {
                if (assets[i] % 2 == 1)
                {
                    Insert(assets, i, assets[i]);
                    Insert(assets, i, assets[i]);
                    i += 2;
                }
            }
            Output(assets);
        }
        public static void Array112()
        {
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            BubbleSort(array);
            Output(array);
        }
        public static void Array113()
        {
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            SelectSort(array);
            Output(array);
        }
        public static void Array114()
        {
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            Output(InsertSort(array));
        }
        public static void Array115()
        {
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            Output(SuperBubbleSort(array));
        }
        public static void Array116()
        {
            double[] array = DoubleInput(Convert.ToInt32(Console.ReadLine()));
            Output(GetSeries(array));
        }
        public static void Array117()
        {
            var series = GetSeries(DoubleInput(Convert.ToInt32(Console.ReadLine())));
            for (int i = 0; i < series.Length; i += 2)
            {
                series = Insert(series, i, (0, 1));
            }
            Output(SeriesToArray(series));
        }
        public static void Array118()
        {
            var series = GetSeries(DoubleInput(Convert.ToInt32(Console.ReadLine())));
            for (int i = 0; i < series.Length; i += 2)
            {
                series = Insert(series, i + 1, (0, 1));
            }
            Output(SeriesToArray(series));
        }
        public static void Array119()
        {
            var series = GetSeries(DoubleInput(Convert.ToInt32(Console.ReadLine())));
            for (int i = 0; i < series.Length; i++)
            {
                series[i].Item2++;
            }
            Output(SeriesToArray(series));
        }
        public static void Array120()
        {
            var series = GetSeries(DoubleInput(Convert.ToInt32(Console.ReadLine())));
            for (int i = 0; i < series.Length; i++)
            {
                series[i].Item2--;
            }
            Output(SeriesToArray(series));
        }
        public static void Array121()
        {
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            if (k < series.Length)
            {
                series[k].Item2 *= 2;
            }
            Output(SeriesToArray(series));
        }
        public static void Array122()
        {
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            if (k < series.Length)
            {
                series = RemoveAt(series, k);
            }
            Output(SeriesToArray(series));
        }
        public static void Array123()
        {
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            if (k < series.Length)
            {
                Proc.Swap(ref series[0], ref series[k]);
            }
            Output(SeriesToArray(series));
        }
        public static void Array124()
        {
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            if (k < series.Length)
            {
                Proc.Swap(ref series[^1], ref series[k]);
            }
            Output(SeriesToArray(series));
        }
        public static void Array125()
        {
            int l = Convert.ToInt32(Console.ReadLine());
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i].Item2 < l)
                {
                    series[i] = (0, 1);
                }
            }
            Output(SeriesToArray(series));
        }
        public static void Array126()
        {
            int l = Convert.ToInt32(Console.ReadLine());
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i].Item2 == l)
                {
                    series[i] = (0, 1);
                }
            }
            Output(SeriesToArray(series));
        }
        public static void Array127()
        {
            int l = Convert.ToInt32(Console.ReadLine());
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i].Item2 > l)
                {
                    series[i] = (0, 1);
                }
            }
            Output(SeriesToArray(series));
        }
        public static void Array128()
        {
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            int max = 0;
            for (int i = 1; i < series.Length; i++)
            {
                if (series[max].Item2 < series[i].Item2)
                {
                    max = i;
                }
            }
            series[max].Item2++;
            Output(SeriesToArray(series));
        }
        public static void Array129()
        {
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            int max = 0;
            for (int i = 1; i < series.Length; i++)
            {
                if (series[max].Item2 <= series[i].Item2)
                {
                    max = i;
                }
            }
            series[max].Item2++;
            Output(SeriesToArray(series));
        }
        public static void Array130()
        {
            (double, int)[] series = GetSeries(DoubleInput
                (Convert.ToInt32(Console.ReadLine())));
            int max = series[0].Item2;
            for (int i = 1; i < series.Length; i++)
            {
                if (series[max].Item2 < series[i].Item2)
                {
                    max = series[i].Item2;
                }
            }
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i].Item2 == max)
                {
                    series[i].Item2++;
                }
            }
            Output(SeriesToArray(series));
        }
        public static void Array131()
        {
            (double, double)[] cordinats = new (double, double)
                                [Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < cordinats.Length; i++)
            {
                cordinats[i].Item1 = Convert.ToDouble(Console.ReadLine());
                cordinats[i].Item2 = Convert.ToDouble(Console.ReadLine());
            }
            (double, double) k = (Convert.ToDouble(Console.ReadLine()), 
                                    Convert.ToDouble(Console.ReadLine()));
            (double, double) min = cordinats[0];
            for (int i = 1; i < cordinats.Length; i++)
            {
                if (PointDist(min, k) > PointDist(cordinats[i], k))
                {
                    min = cordinats[i];
                }
            }
            Console.WriteLine(min);
        }
        public static void Array132()
        {
            (double, double)[] cordinats = new (double, double)
                                [Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < cordinats.Length; i++)
            {
                cordinats[i].Item1 = Convert.ToDouble(Console.ReadLine());
                cordinats[i].Item2 = Convert.ToDouble(Console.ReadLine());
            }
            (double, double) k = (0, 0);
            (double, double)? max = null;
            for (int i = 1; i < cordinats.Length; i++)
            {
                if ((cordinats[i].Item1 < 0 && cordinats[i].Item2 > 0) && 
                    (max == null || PointDist(max.Value, k) < PointDist(cordinats[i], k)))
                {
                    max = cordinats[i];
                }
            }
            Console.WriteLine(max != null ? max : k);
        }
        public static void Array133()
        {
            (double, double)[] cordinats = new (double, double)
                                [Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < cordinats.Length; i++)
            {
                cordinats[i].Item1 = Convert.ToDouble(Console.ReadLine());
                cordinats[i].Item2 = Convert.ToDouble(Console.ReadLine());
            }
            (double, double) k = (0, 0);
            (double, double)? min = null;
            for (int i = 1; i < cordinats.Length; i++)
            {
                if ((cordinats[i].Item1 < 0 == cordinats[i].Item2 < 0) &&
                    (min == null || PointDist(min.Value, k) < PointDist(cordinats[i], k)))
                {
                    min = cordinats[i];
                }
            }
            Console.WriteLine(min != null ? min : k);
        }
        public static void Array134()
        {
            (double, double)[] cordinats = new (double, double)
                                [Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < cordinats.Length; i++)
            {
                cordinats[i].Item1 = Convert.ToDouble(Console.ReadLine());
                cordinats[i].Item2 = Convert.ToDouble(Console.ReadLine());
            }
            (double, double) point1 = cordinats[0];
            (double, double) point2 = cordinats[1];
            for (int i = 0; i < cordinats.Length; i++)
            {
                for (int j = i + 1; j < cordinats.Length; j++)
                {
                    if (PointDist(point1, point2) < PointDist(cordinats[i], cordinats[j]))
                    {
                        point1 = cordinats[i];
                        point2 = cordinats[j];
                    }
                }
            }
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine(PointDist(point1, point2));
        }

        public static void Array135()
        {
            (double, double)[] storges = new (double, double)
                                [Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < storges.Length; i++)
            {
                storges[i].Item1 = Convert.ToDouble(Console.ReadLine());
                storges[i].Item2 = Convert.ToDouble(Console.ReadLine());
            }
            (double, double)[] bunkers = new (double, double)
                                [Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < bunkers.Length; i++)
            {
                bunkers[i].Item1 = Convert.ToDouble(Console.ReadLine());
                bunkers[i].Item2 = Convert.ToDouble(Console.ReadLine());
            }
            (double, double) storge = storges[0];
            (double, double) bunker = bunkers[0];
            for (int i = 0; i < storges.Length; i++)
            {
                for (int j = 0; j < bunkers.Length; j++)
                {
                    if (PointDist(storge, bunker) > PointDist(storges[i], bunkers[j]))
                    {
                        storge = storges[i];
                        bunker = bunkers[j];
                    }
                }
            }
            Console.WriteLine(storge);
            Console.WriteLine(bunker);
            Console.WriteLine(PointDist(storge, bunker));
        }
        public static void Array136()
        {
            (double, double)[] bases = new (double, double)
                                [Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < bases.Length; i++)
            {
                bases[i].Item1 = Convert.ToDouble(Console.ReadLine());
                bases[i].Item2 = Convert.ToDouble(Console.ReadLine());
            }
            (double, double) baseMin = bases[0];
            double? sumMin = null;
            for (int i = 0; i < bases.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < bases.Length; j++)
                {
                    sum += PointDist(bases[i], bases[j]);
                }
               if (sumMin == null || sumMin > sum)
                {
                    sumMin = sum;
                    baseMin = bases[i];
                }
            }
            Console.WriteLine(baseMin);
            Console.WriteLine(sumMin);
        }
        public static void Array137()
        {
            (double, double)[] bases = new (double, double)
                                [Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < bases.Length; i++)
            {
                bases[i].Item1 = Convert.ToDouble(Console.ReadLine());
                bases[i].Item2 = Convert.ToDouble(Console.ReadLine());
            }
            (double, double) vertex1 = (0, 0);
            (double, double) vertex2 = (0, 0);
            (double, double) vertex3 = (0, 0);
            double? maxP = null;
            for (int i = 0; i < bases.Length; i++)
            {
                double p = 0;
                for (int j = i + 1; j < bases.Length; j++)
                {
                    for (int k = j + 1; k < bases.Length; k++)
                    {
                        if (PointDist(bases[i], bases[j]) + PointDist(bases[k], bases[j]) > 
                                PointDist(bases[i], bases[k]) &&
                                PointDist(bases[i], bases[j]) + PointDist(bases[i], bases[k]) >
                                PointDist(bases[j], bases[k]) &&
                                PointDist(bases[i], bases[k]) + PointDist(bases[k], bases[j]) >
                                PointDist(bases[i], bases[j]))
                        {
                            p = PointDist(bases[i], bases[j]) +
                            PointDist(bases[i], bases[k]) +
                            PointDist(bases[j], bases[k]);
                            if (maxP == null || maxP < p)
                            {
                                maxP = p;
                                vertex1 = bases[i];
                                vertex2 = bases[j];
                                vertex3 = bases[k];
                            }
                        }
                    }
                }
            }
            Console.WriteLine(vertex1);
            Console.WriteLine(vertex2);
            Console.WriteLine(vertex3);
            Console.WriteLine(maxP);
        }
        public static double[] DoubleInput(int n)
        {
            double[] a = new double[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            return a;
        }
        public static int[] IntInput(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
        public static string[] StringInput(int n)
        {
            string[] a = new string[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Console.ReadLine();
            }
            return a;
        }
        public static void Output<T>(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public static int[] Concat(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            for (int i = 0, j = 0, k = 0; i < c.Length; i++)
            {
                if (k == b.Length)
                {
                    c[i] = a[j];
                    j++;
                    continue;
                }
                if (j == a.Length)
                {
                    c[i] = b[k];
                    k++;
                    continue;
                }
                if (a[j] > b[k])
                {
                    c[i] = a[j];
                    j++;
                }
                else
                {
                    c[i] = b[k];
                    k++;
                }
            }
            return c;
        }

        public static T[] RemoveAt<T>(T[] input, int index)
        {
            if (index >= input.Length || index < 0) throw new ArgumentException("Ты дурак!? индекс не может быть больше или равен размеру массива!");
            T[] output = new T[input.Length - 1];
            for (int i = 0; i < index; i++)
            {
                output[i] = input[i];
            }
            for (int i = index; i < output.Length; i++)
            {
                output[i] = input[i + 1];
            }
            return output;
        }

        public static T[] RemoveRange<T>(T[] input, int index, int count)
        {
            if (index < 0 || count <= 0 || count + index - 1 >= input.Length) throw new ArgumentException("Ты дурак!? индекс не может быть больше или равен размеру массива!");
            T[] output = new T[input.Length - count];
            for (int i = 0; i < index; i++)
            {
                output[i] = input[i];
            }
            for (int i = index; i < output.Length; i++)
            {
                output[i] = input[i + count];
            }
            return output;
        }

        public static T[] Insert<T>(T[] input, int index, T value)
        {
            if (index > input.Length || index < 0) throw new ArgumentException("Ты дурак!? индекс не может быть больше или равен размеру массива!");
            T[] output = new T[input.Length + 1];
            for (int i = 0; i < index; i++)
            {
                output[i] = input[i];
            }
            output[index] = value;
            for (int i = index + 1; i < output.Length; i++)
            {
                output[i] = input[i - 1];
            }
            return output;
        }

        public static T[] InsertRange<T>(T[] input, int index, T[] values)
        {
            if (index < 0 || index > input.Length) throw new ArgumentException("Ты дурак!? индекс не может быть больше или равен размеру массива!");
            T[] output = new T[input.Length + values.Length];
            for (int i = 0; i < index; i++)
            {
                output[i] = input[i];
            }
            for (int i = 0; i < values.Length; i++)
            {
                output[i + index] = values[i];
            }
            for (int i = index + values.Length; i < output.Length; i++)
            {
                output[i] = input[i - values.Length];
            }
            return output;
        }
        public static void BubbleSort(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    Proc.MinMax(ref array[j], ref array[j + 1]);
                }
                Output(array);
            }
        }
        public static void SelectSort(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
                Proc.Swap(ref array[i], ref array[min]);
                Output(array);
            }
        }
        public static double[] InsertSort(double[] array)
        {
            double[] output = new double[0];
            for (int i = 0; i < array.Length; i++)
            {
                int j = 0;
                while (j < output.Length && output[j] > array[i]) j++;
                Insert(output, j, array[i]);
                Output(output);
            }
            return output;
        }

        public static int[] SuperBubbleSort(double[] array)
        {
            int[] output = new int[array.Length];
            for (int i = 1; i < array.Length; i++) output[i] = i;
            for (int i = 0; i < output.Length - 1; i++)
            {
                for (int j = 0; j < output.Length - i - 1; j++)
                {
                    if (array[output[j]] > array[output[j + 1]])
                    {
                        Proc.Swap(ref output[j], ref output[j + 1]);
                    }
                }
                Output(output);
            }
            return output;
        }
        public static (T, int)[] GetSeries<T>(T[] input)
        {
            (T, int)[] output = new (T, int)[1];
            output[0].Item1 = input[0];
            output[0].Item2 = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (output[^1].Item1.Equals(input[i]))
                {
                    output[^1].Item2++;
                }
                else
                {
                    output = Insert(output, output.Length, (input[i], 1));
                }
            }
            return output;
        }
        public static T[] SeriesToArray<T>((T, int)[] input)
        {
            T[] output = new T[0];
            for (int i = 0; i < input.Length; i++)
            {
                T[] values = new T[input[i].Item2];
                for (int j = 0; j < values.Length; j++)
                {
                    values[j] = input[i].Item1;
                }
                output = InsertRange(output, output.Length, values);
            }
            return output;
        }

        public static double PointDist((double, double) point1, (double, double) point2)
        {
            //r = корень из ((x1-x2) в квадрате + (y1-y2) в квадрате)
            return Math.Sqrt(Math.Pow(point1.Item1 - point2.Item1, 2) +
                Math.Pow(point1.Item2 - point2.Item2, 2));
        }
    }
}

