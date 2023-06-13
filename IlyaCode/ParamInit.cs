using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal partial class Param
    {
        public static int MinElem(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int MaxNum(double[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[max] < array[i])
                {
                    max = i;
                }
            }
            return max;
        }

        public static void MinmaxNum(double[] array, out int min, out int max)
        {
            min = 0;
            max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[max] < array[i])
                {
                    max = i;
                }
                if (array[min] > array[i])
                {
                    min = i;
                }
            }
        }

        public static void Invert<T>(T[] a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                Proc.Swap(ref a[i], ref a[^(i + 1)]);
            }
        }

        public static void Smooth1(double[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                double value = a[i];
                a[i] = sum / (i + 1);
                sum += value;
            }                                                                                 
        }

        public static void Smooth2(double[] a)
        {
            double prev = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                double current = a[i];
                a[i] = (a[i] + prev) / 2;
                prev = current;
            }
        }

        public static void Smooth3(double[] a)
        {
            double prev = a[0];
            a[0] = (a[0] + a[1]) / 2;
            for (int i = 1; i < a.Length - 1; i++)
            {
                double current = a[i];
                a[i] = (prev + a[i] + a[i + 1]) / 3;
                prev = current;
            }
            a[^1] = (prev + a[^1]) / 2;
        }

        public static void RemoveX(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    Array.RemoveAt(a, i);
                    i--;
                }    
            }
        }

        public static void RemoveForInc(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] <= a[i - 1])
                {
                    Array.RemoveAt(a, i);
                    i--;
                }
            }
        }

        public static void DoubleX(int[] a, int x)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    Array.Insert(a, i, x);
                    i++;
                }
            }
        }
    }
}
