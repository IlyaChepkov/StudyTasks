using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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
            for (int i = 0; i < a.Length ; i++)
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
        public static void Output<T>(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public static int[] Concat(int[]a, int[]b)
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
    }
}

