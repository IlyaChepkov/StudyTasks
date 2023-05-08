using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal static class Matrix
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("Matrix");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            try
            {
                typeof(Matrix).GetMethod("Matrix" + taskNumber).Invoke(null, null);
            }
            catch { }

        }

        public static void Matrix1()
        {
            int[,] matrix = new int[Convert.ToInt32(Console.ReadLine()),
                                         Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i + 1) * 10;
                }
            }
            Output(matrix);
        }

        public static void Matrix2()
        {
            int[,] matrix = new int[Convert.ToInt32(Console.ReadLine()),
                                         Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[j, i] = (i + 1) * 5;
                }
            }
            Output(matrix);
        }

        public static void Matrix3()
        {
            string[,] matrix = new string[Convert.ToInt32(Console.ReadLine()),
                                         Convert.ToInt32(Console.ReadLine())];
            string[] array = Array.StringInput(matrix.GetLength(0));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[i];
                }
            }
            Output(matrix);
        }

        public static void Matrix4()
        {
            string[,] matrix = new string[Convert.ToInt32(Console.ReadLine()),
                                         Convert.ToInt32(Console.ReadLine())];
            string[] array = Array.StringInput(matrix.GetLength(1));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[j];
                }
            }
            Output(matrix);
        }

        public static void Matrix5()
        {
            double[,] matrix = new double[Convert.ToInt32(Console.ReadLine()),
                                         Convert.ToInt32(Console.ReadLine())];
            double d = Convert.ToInt32(Console.ReadLine());
            double[] array = Array.DoubleInput(matrix.GetLength(0));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[i] + d * j;
                }
            }
            Output(matrix);
        }

        public static void Matrix6()
        {
            double[,] matrix = new double[Convert.ToInt32(Console.ReadLine()),
                                         Convert.ToInt32(Console.ReadLine())];
            double d = Convert.ToInt32(Console.ReadLine());
            double[] array = Array.DoubleInput(matrix.GetLength(1));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[j] + d * i;
                }
            }
            Output(matrix);
        }

        public static void Matrix7()
        {
            string[,] matrix = StringInput(Convert.ToInt32(Console.ReadLine()),
                                            Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write(matrix[k, i] + " ");
            }
        }

        public static void Matrix8()
        {
            string[,] matrix = StringInput(Convert.ToInt32(Console.ReadLine()),
                                            Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, k]);
            }
        }

        public static void Matrix9()
        {
            string[,] matrix = StringInput(Convert.ToInt32(Console.ReadLine()),
                                            Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i < matrix.GetLength(0); i += 2)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Matrix10()
        {
            string[,] matrix = StringInput(Convert.ToInt32(Console.ReadLine()),
                                            Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j += 2)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Matrix11()
        {
            string[,] matrix = StringInput(Convert.ToInt32(Console.ReadLine()),
                                            Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, i % 2 == 0 ? j : matrix.GetLength(1) - j - 1] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Matrix12()
        {
            string[,] matrix = StringInput(Convert.ToInt32(Console.ReadLine()),
                                            Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[j % 2 == 0 ? i : matrix.GetLength(1) - i - 1, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Matrix13()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            string[,] matrix = StringInput(m, m);
            for (int i = 0; i < m * 2 - 1; i++)
            {
                for (int j = 0; j < m - (i + 1) / 2; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(matrix[i / 2, j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[(i + 1) / 2 + j, m - ((i + 1) / 2)] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Matrix14()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            string[,] matrix = StringInput(m, m);
            for (int i = 0; i < m * 2 - 1; i++)
            {
                for (int j = 0; j < m - (i + 1) / 2; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(matrix[m - ((i + 1) / 2), (i + 1) / 2 + j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[j, i / 2] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Matrix15()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            string[,] matrix = StringInput(m, m);
            for (int i = 0; i < m * 2 - 1; i++)
            {
                for (int j = 0; j < m - (i + 1) / 2; j++)
                {
                    switch (i % 4)
                    {
                        case 0:
                            {
                                Console.Write(matrix[i / 4, i / 4 + j] + " ");
                            } break;
                        case 1:
                            {
                                Console.Write(matrix[i / 4 + 1 + j, m - (i / 4 + 1)] + " ");
                            }
                            break;
                        case 2:
                            {
                                Console.Write(matrix[m - (i / 4 + 1), m - (i / 4 + 2) - j] + " ");
                            }
                            break;
                        case 3:
                            {
                                Console.Write(matrix[m - (i / 4 + 2) - j, i / 4] + " ");
                            }
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Matrix16()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            string[,] matrix = StringInput(m, m);
            for (int i = 0; i < m * 2 - 1; i++)
            {
                for (int j = 0; j < m - (i + 1) / 2; j++)
                {
                    switch (i % 4)
                    {
                        case 0:
                            {
                                Console.Write(matrix[i / 4 + j, i / 4] + " ");
                            }
                            break;
                        case 1:
                            {
                                Console.Write(matrix[m - (i / 4 + 1), (i / 4 + 1) + j] + " ");
                            }
                            break;
                        case 2:
                            {
                                Console.Write(matrix[m - (i / 4 + 2) - j, m - (i / 4 + 1)] + " ");
                            }
                            break;
                        case 3:
                            {
                                Console.Write(matrix[i / 4, m - (i / 4 + 2) - j] + " ");
                            }
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Matrix17()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            int sum = 0;
            int mul = 1;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sum += matrix[k, i];
                mul *= matrix[k, i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(mul);
        }

        public static void Matrix18()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            int sum = 0;
            int mul = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, k];
                mul *= matrix[i, k];
            }
            Console.WriteLine(sum);
            Console.WriteLine(mul);
        }

        public static void Matrix19()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine(sum);
            }
        }

        public static void Matrix20()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int mul = 1;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    mul *= matrix[i, j];
                }
                Console.WriteLine(mul);
            }
        }

        public static void Matrix21()
        {
            double[,] matrix = DoubleInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i += 2)
            {
                double sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine(sum / matrix.GetLength(1));
            }
        }

        public static void Matrix22()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            for (int j = 1; j < matrix.GetLength(1); j += 2)
            {
                int sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine(sum);
            }
        }

        public static void Matrix23()
        {
            double[,] matrix = DoubleInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double? min = null;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min == null || min > matrix[i, j])
                    {
                        min = matrix[i, j];
                    }
                }
                Console.WriteLine(min);
            }
        }

        public static void Matrix24()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int? max = null;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (max == null || max < matrix[j, i])
                    {
                        max = matrix[i, j];
                    }
                }
                Console.WriteLine(max);
            }
        }

        public static void Matrix25()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            int? maxSum = null;
            int maxString = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                if (maxSum == null || maxSum < sum)
                {
                    maxSum = sum;
                    maxString = i;
                }
            }
            Console.WriteLine(maxString + 1);
            Console.WriteLine(maxSum);
        }

        public static void Matrix26()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            int? minMul = null;
            int minColumn = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int mul = 1;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    mul *= matrix[i, j];
                }
                if (minMul == null || minMul > mul)
                {
                    minMul = mul;
                    minColumn = j;
                }
            }
            Console.WriteLine(minColumn + 1);
            Console.WriteLine(minMul);
        }

        public static void Matrix27()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            int? max = null;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                    }
                }
                if (max == null || max < min)
                {
                    max = min;
                }
            }
            Console.WriteLine(max);
        }
        
        public static void Matrix28()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                                Convert.ToInt32(Console.ReadLine()));
            int? min = null;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int max = matrix[0, j];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                }
                if (min == null || min > max)
                {
                    min = max;
                }
            }
            Console.WriteLine(min);
        }

        public static void Matrix29()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int count = 0;
                double avg = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    avg += matrix[i, j];
                }
                avg /= matrix.GetLength(1);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < avg)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }

        public static void Matrix30()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int count = 0;
                double avg = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    avg += matrix[i, j];
                }
                avg /= matrix.GetLength(0);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] > avg)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
        public static void Matrix31()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                              Convert.ToInt32(Console.ReadLine()));
            double avg = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    avg += matrix[i, j];
                }
            }
            avg /= matrix.Length;
            int line = 0;
            int column = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (Math.Abs(matrix[i, j] - avg) < Math.Abs(matrix[line, column] - avg))
                    {
                        line = i;
                        column = j;
                    }
                }
            }
            Console.WriteLine(line + 1);
            Console.WriteLine(column + 1);
        }

        public static void Matrix32()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                              Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int plus = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        plus++;
                    }
                    if (matrix[i, j] < 0)
                    {
                        plus--;
                    }
                }
                if (plus == 0)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }
            Console.WriteLine(0);
        }
        public static void Matrix33()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                              Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int plus = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[matrix.GetLength(0) - i - 1, matrix.GetLength(1) - j - 1] > 0)
                    {
                        plus++;
                    }
                    if (matrix[matrix.GetLength(0) - i - 1, matrix.GetLength(1) - j - 1] < 0)
                    {
                        plus--;
                    }
                }
                if (plus == 0)
                {
                    Console.WriteLine(matrix.GetLength(1) - j);
                    return;
                }
            }
            Console.WriteLine(0);
        }

        public static void Matrix34()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                              Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool isOdd = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[matrix.GetLength(0) - i - 1, matrix.GetLength(1) - j - 1] % 2 == 1)
                    {
                        isOdd = true;
                        break;
                    }
                }
                if (!isOdd) // !!!!!!!
                {
                    Console.WriteLine(matrix.GetLength(0) - i);
                    return;
                }
            }
            Console.WriteLine(0);
        }

        public static void Matrix35()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                              Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isEven = false;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        isEven = true;
                        break;
                    }
                }
                if (!isEven) // !!!!!!!
                {
                    Console.WriteLine(j + 1);
                    return;
                }
            }
            Console.WriteLine(0);
        }

        public static void Matrix36()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                              Convert.ToInt32(Console.ReadLine()));
            int count = matrix.GetLength(0) - 1;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bool firstHas = false;
                    bool iHas = false;
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (matrix[0, j] == matrix[i, k])
                        {
                            firstHas = true;
                        }
                        if (matrix[i, j] == matrix[0, k])
                        {
                            iHas = true;
                        }
                    }
                    if (!(firstHas && iHas)) // !!!!!!
                    {
                        count--;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }

        public static void Matrix37()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int count = matrix.GetLength(1) - 1;
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    bool firstHas = false;
                    bool iHas = false;
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[i, matrix.GetLength(1) - 1] == matrix[k, matrix.GetLength(1) - j - 1])
                        {
                            firstHas = true;
                        }
                        if (matrix[i, matrix.GetLength(1) - j - 1] == matrix[k, matrix.GetLength(1) - 1])
                        {
                            iHas = true;
                        }
                    }
                    if (!(firstHas && iHas)) // !!!!!!
                    {
                        count--;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }

        public static void Matrix38()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                              Convert.ToInt32(Console.ReadLine()));
            int count = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bool has = false;
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (matrix[i, j] == matrix[i, k])
                        {
                            has = true;
                            break;
                        } 
                    }
                    if (has)
                    {
                        count--;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }

        public static void Matrix39()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int count = matrix.GetLength(1);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    bool has = false;
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[i, j] == matrix[k, j])
                        {
                            has = true;
                            break;
                        }
                    }
                    if (has)
                    {
                        count--;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }

        public static void Matrix40()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int number = 1;
            int maxCount = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int count = 1;
                    for (int k = j + 1; k < matrix.GetLength(1); k++)
                    {
                        if (matrix[i, j] == matrix[i, k])
                        {
                            count++;
                        }
                    }
                    if (maxCount <= count)
                    {
                        maxCount = count;
                        number = i + 1;
                    }
                }
            }
            Console.WriteLine(number);
        }

        public static void Matrix41()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int number = 1;
            int maxCount = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int count = 1;
                    for (int k = j + 1; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[i, j] == matrix[k, j])
                        {
                            count++;
                        }
                    }
                    if (maxCount < count)
                    {
                        maxCount = count;
                        number = j + 1;
                    }
                }
            }
            Console.WriteLine(number);
        }

        public static void Matrix42()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool ishas = false;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j - 1] >= matrix[i, j])
                    {
                        ishas = true;
                        break;
                    }
                }
                if (!ishas) count++;
            }
            Console.WriteLine(count);
        }

        public static void Matrix43()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool ishas = false;
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i - 1, j] <= matrix[i, j])
                    {
                        ishas = true;
                        break;
                    }
                }
                if (!ishas) count++;
            }
            Console.WriteLine(count);
        }

        public static void Matrix44()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int? min = null;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool isUp = matrix[i, 0] < matrix[i, 1];
                bool ishas = false;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j - 1] == matrix[i, j] ||
                        matrix[i, j - 1] < matrix[i, j] != isUp)
                    {
                        ishas = true;
                        break;
                    }
                }
                if (!ishas)
                { 
                    if (!min.HasValue || min > matrix[i, 0])
                        min = matrix[i, 0];
                    if (min > matrix[i, matrix.GetLength(1) - 1])
                        min = matrix[i, matrix.GetLength(1) - 1];
                } 
            }
            Console.WriteLine(!min.HasValue ? 0 : min);
        }

        public static void Matrix45()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int? max = null;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isUp = matrix[0, j] < matrix[1, j];
                bool ishas = false;
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i - 1, j] == matrix[i, j] ||
                        matrix[i - 1, j] < matrix[i, j] != isUp)
                    {
                        ishas = true;
                        break;
                    }
                }
                if (!ishas)
                {
                    if (!max.HasValue || max < matrix[0, j])
                        max = matrix[0, j];
                    if (max < matrix[matrix.GetLength(0) - 1, j])
                        max = matrix[matrix.GetLength(0) - 1, j];
                }
            }
            Console.WriteLine(!max.HasValue ? 0 : max);
        }

        public static void Matrix46()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = 0;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, max] < matrix[i, j])
                    {
                        max = j;
                    }
                }
                bool isMin = true;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[i, max] > matrix[k, max])
                    {
                        isMin = false;
                        break;
                    }
                }
                if (isMin)
                {
                    Console.WriteLine(matrix[i, max]);
                    return;
                }
            }
            Console.WriteLine(0);
        }

        public static void Matrix47()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int k1 = Convert.ToInt32(Console.ReadLine());
            int k2 = Convert.ToInt32(Console.ReadLine());
            Output(SwapRow(matrix, k1, k2));
        }

        public static void Matrix48()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int k1 = Convert.ToInt32(Console.ReadLine());
            int k2 = Convert.ToInt32(Console.ReadLine());
            Output(SwapCollumn(matrix, k1, k2));
        }

        public static void Matrix49()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = 0;
                int max = 0;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, min] > matrix[i, j])
                    {
                        min = j;
                    }
                    if (matrix[i, max] < matrix[i, j])
                    {
                        max = j;
                    }
                }
                Proc.Swap(ref matrix[i, min], ref matrix[i, max]);
            }
            Output(matrix);
        }

        public static void Matrix50()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int min = 0;
                int max = 0;
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[min, j] > matrix[i, j])
                    {
                        min = i;
                    }
                    if (matrix[max, j] < matrix[i, j])
                    {
                        max = i;
                    }
                }
                Proc.Swap(ref matrix[min, j], ref matrix[max, j]);
            }
            Output(matrix);
        }

        public static void Matrix51()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int min = matrix[0, 0];
            int minNum = 0;
            int max = matrix[0, 0];
            int maxNum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        minNum = i;
                    }
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        maxNum = i;
                    }
                }
            }
            Output(SwapRow(matrix, minNum, maxNum));
        }

        public static void Matrix52()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int min = matrix[0, 0];
            int minNum = 0;
            int max = matrix[0, 0];
            int maxNum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        minNum = j;
                    }
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        maxNum = j;
                    }
                }
            }
            Output(SwapCollumn(matrix, minNum, maxNum));
        }

        public static void Matrix53()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isPlus = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, matrix.GetLength(0) - j - 1] <= 0)
                    {
                        isPlus = false;
                        break;
                    }
                }
                if (isPlus)
                {
                    Output(SwapCollumn(matrix, 0, j));
                    return;
                }
            }
            Output(matrix);
        }

        public static void Matrix54()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isMines = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        isMines = false;
                        break;
                    }
                }
                if (isMines)
                {
                    Output(SwapCollumn(matrix, matrix.GetLength(1) - 1, j));
                    return;
                }
            }
            Output(matrix);
        }

        public static void Matrix55()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0) / 2; i++)
            {
                matrix = SwapRow(matrix, i, i + matrix.GetLength(0) / 2);
            }
            Output(matrix);
        }

        public static void Matrix56()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1) / 2; j++)
            {
                matrix = SwapCollumn(matrix, j, j + matrix.GetLength(1) / 2);
            }
            Output(matrix);
        }

        public static void Matrix57()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0) / 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) / 2; j++)
                {
                    Proc.Swap(ref matrix[i, j], ref matrix[i + matrix.GetLength(0) / 2, j + matrix.GetLength(1) / 2]);
                }
            }
            Output(matrix);
        }

        public static void Matrix58()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0) / 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) / 2; j++)
                {
                    Proc.Swap(ref matrix[i, j + matrix.GetLength(1) / 2], ref matrix[i + matrix.GetLength(0) / 2, j]);
                }
            }
            Output(matrix);
        }

        public static void Matrix59()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0) / 2; i++)
            {
                matrix = SwapRow(matrix, i, matrix.GetLength(0) - i - 1);
            }
            Output(matrix);
        }

        public static void Matrix60()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1) / 2; j++)
            {
                matrix = SwapCollumn(matrix, j, matrix.GetLength(1) - j - 1);
            }
            Output(matrix);
        }

        public static void Matrix61()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            Output(RemoveRow(matrix, k));
        }

        public static void Matrix62()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine()) - 1; 
            Output(RemoveCollumn(matrix, k));
        }

        public static void Matrix63()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int min = matrix[0, 0];
            int indexRow = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j< matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        indexRow = i;
                        min = matrix[i, j];
                    }
                }
            }
            Output(RemoveRow(matrix, indexRow));
        }

        public static void Matrix64()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int max = matrix[0, 0];
            int indexCollumn = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        indexCollumn = j;
                        max = matrix[i, j];
                    }
                }
            }
            Output(RemoveCollumn(matrix, indexCollumn));
        }

        public static void Matrix65()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isplus = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] <= 0)
                    {
                        isplus = false;
                        break;
                    }
                }
                if (isplus)
                {
                    matrix = RemoveCollumn(matrix, j);
                    break;
                }
            }
            Output(matrix);
        }

        public static void Matrix66()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isMines = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, matrix.GetLength(1) - j - 1] >=
                        0)
                    {
                        isMines = false;
                        break;
                    }
                }
                if (isMines)
                {
                    matrix = RemoveCollumn(matrix, j);
                    break;
                }
            }
            Output(matrix);
        }

        public static void Matrix67()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isplus = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] <= 0)
                    {
                        isplus = false;
                        break;
                    }
                }
                if (isplus)
                {
                    matrix = RemoveCollumn(matrix, j);             
                }
            }
            Output(matrix);
        }

        public static void Matrix68()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            Output(InsertRow(matrix, new int[matrix.GetLength(1)], index));
        }

        public static void Matrix69()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            int[] insert = new int[matrix.GetLength(0)];
            for (int i = 0; i < insert.Length; i++) insert[i] = 1;
            Output(InsertCollumn(matrix, insert, index + 1));
        }

        public static void Matrix70()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int max = matrix[0, 0];
            int maxRow = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        maxRow = i;
                    }
                }
            }
            int[] insert = new int[matrix.GetLength(1)];
            for (int i = 0; i < insert.Length; i++) insert[i] = matrix[maxRow, i];
            Output(InsertRow(matrix, insert, maxRow));
        }

        public static void Matrix71()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int min = matrix[0, 0];
            int minCollumn = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        minCollumn = j;
                    }
                }
            }
            int[] insert = new int[matrix.GetLength(0)];
            for (int i = 0; i < insert.Length; i++) insert[i] = matrix[i, minCollumn];
            Output(InsertCollumn(matrix, insert, minCollumn));
        }

        public static void Matrix72()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isPlus = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] <= 0)
                    {
                        isPlus = false;
                        break;
                    }
                }
                if (isPlus)
                {
                    int[] insert = new int[matrix.GetLength(0)];
                    for (int i = 0; i < insert.Length; i++) insert[i] = 1;
                    matrix = InsertCollumn(matrix, insert, j);
                    break;
                }
            }
            Output(matrix);
        }

        public static void Matrix73()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isMines = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, matrix.GetLength(1) - j - 1] >= 0)
                    {
                        isMines = false;
                        break;
                    }
                }
                if (isMines)
                {
                    matrix = InsertCollumn(matrix, new int[matrix.GetLength(0)],
                        matrix.GetLength(1) - j); 
                    break;
                }
            }
            Output(matrix);
        }

        public static void Matrix74()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int[,] output = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bool isAllSmaller = true;
                    for (int y = -1; y <= 1; y++)
                    {
                        for (int x = -1; x <= 1; x++)
                        {
                            if (!(y == 0 && x == 0) &&
                                i + y >= 0 && i + y < matrix.GetLength(0) &&
                                j + x >= 0 && j + x < matrix.GetLength(1))
                            {
                                if (matrix[i, j] >= matrix[i + y, j + x])
                                {
                                    isAllSmaller = false;
                                    break;
                                }
                            }
                        }
                        if (!isAllSmaller) break;
                    }
                    if (!isAllSmaller)
                    {
                        output[i, j] = matrix[i, j];
                    }
                }
            }
            Output(output);
        }

        public static void Matrix75()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            int[,] output = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bool isAllBigger = true;
                    for (int y = -1; y <= 1; y++)
                    {
                        for (int x = -1; x <= 1; x++)
                        {
                            if (!(y == 0 && x == 0) &&
                                i + y >= 0 && i + y < matrix.GetLength(0) &&
                                j + x >= 0 && j + x < matrix.GetLength(1))
                            {
                                if (matrix[i, j] <= matrix[i + y, j + x])
                                {
                                    isAllBigger = false;
                                    break;
                                }
                            }
                        }
                        if (!isAllBigger) break;
                    }
                   output[i, j] = isAllBigger? -matrix[i, j] : matrix[i, j];
                }
            }
            Output(output);
        }

        public static void Matrix76()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    if (matrix[min, 0] > matrix[j, 0])
                    {
                        min = j;
                    }
                }
                matrix = SwapRow(matrix, min, i);
            }
            Output(matrix);
        }

        public static void Matrix77()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int max = j;
                for (int i = j + 1; i < matrix.GetLength(1); i++)
                {
                    if (matrix[matrix.GetLength(0) - 1, max] < matrix[matrix.GetLength(0) - 1, j])
                    {
                        max = i;
                    }
                }
                matrix = SwapCollumn(matrix, max, j);
            }
            Output(matrix);
        }

        public static void Matrix78()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int maxIndex = -1;
                int max = 0;
                for (int j = i; j < matrix.GetLength(0); j++)
                {
                     
                    int min = matrix[j, 0];
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (min > matrix[j, k])
                        {
                            min = matrix[j, k];
                        }
                    }
                    if (maxIndex == -1 || max < min)
                    {
                        maxIndex = j;
                        max = min;
                    }
                }
                matrix = SwapRow(matrix, maxIndex, i);
            }
            Output(matrix);
        }

        public static void Matrix79()
        {
            int[,] matrix = IntInput(Convert.ToInt32(Console.ReadLine()),
                                               Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                int minIndex = -1;
                int min = 0;
                for (int j = i; j < matrix.GetLength(1); j++)
                {

                    int max = matrix[0, j];
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        if (max < matrix[k, j])
                        {
                            max = matrix[k, j];
                        }
                    }
                    if (minIndex == -1 || min > max)
                    {
                        minIndex = j;
                        min = max;
                    }
                }
                matrix = SwapCollumn(matrix, minIndex, i);
            }
            Output(matrix);
        }

        public static void Matrix80()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = IntInput(m, m);
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }

        public static void Matrix81()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = IntInput(m, m);
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += matrix[i, m - i - 1];
            }
            Console.WriteLine(sum / m);
        }

        public static void Matrix82()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[][] d = GetMainD(IntInput(m, m));
            for (int i = 0; i < d.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < d[i].Length; j++)
                {
                    sum += d[i][j];
                }
                Console.WriteLine(sum);
            }
        }

        public static void Matrix83()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[][] d = GetSubMainD(IntInput(m, m));
            for (int i = 0; i < d.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < d[i].Length; j++)
                {
                    sum += d[i][j];
                }
                Console.WriteLine(sum);
            }
        }
        public static void Matrix84()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[][] d = GetMainD(IntInput(m, m));
            for (int i = 0; i < d.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < d[i].Length; j++)
                {
                    sum += d[i][j];
                }
                Console.WriteLine(sum / d[i].Length);
            }
        }

        public static void Matrix85()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[][] d = GetSubMainD(IntInput(m, m));
            for (int i = 0; i < d.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < d[i].Length; j++)
                {
                    sum += d[i][j];
                }
                Console.WriteLine(sum / d[i].Length);
            }
        }

        public static void Matrix86()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[][] d = GetMainD(IntInput(m, m));
            for (int i = 0; i < d.Length; i++)
            {
                int min = d[i][0];
                for (int j = 0; j < d[i].Length; j++)
                {
                    if (min > d[i][j])
                    {
                        min = d[i][j];
                    }
                }
                Console.WriteLine(min);
            }
        }

        public static void Matrix87()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[][] d = GetSubMainD(IntInput(m, m));
            for (int i = 0; i < d.Length; i++)
            {
                int max = d[i][0];
                for (int j = 0; j > d[i].Length; j++)
                {
                    if (max < d[i][j])
                    {
                        max = d[i][j];
                    }
                }
                Console.WriteLine(max);
            }
        }

        public static string[,] StringInput(int m, int n)
        {
            string[,] matrix = new string[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }
            return matrix;
        }

        public static int[,] IntInput(int m, int n)
        {
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        public static void Output<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static double[,] DoubleInput(int m, int n)
        {
            double[,] matrix = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        public static T[,] SwapRow<T>(T[,] matrix, int firstIndex, int SecondIndex)
        {
            if ((firstIndex < 0 || SecondIndex < 0) || 
                (firstIndex >= matrix.GetLength(0) || SecondIndex >= matrix.GetLength(0)))
            {
                throw new ArgumentException("таких строк не существует");
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Proc.Swap(ref matrix[firstIndex, i], ref matrix[SecondIndex, i]);
            }
            return matrix;
        }

        public static T[,] SwapCollumn<T>(T[,] matrix, int firstIndex, int SecondIndex)
        {
            if ((firstIndex < 0 || SecondIndex < 0) ||
                (firstIndex >= matrix.GetLength(1) || SecondIndex >= matrix.GetLength(1)))
            {
                throw new ArgumentException("таких столбцов не существует");
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Proc.Swap(ref matrix[i, firstIndex], ref matrix[i, SecondIndex]);
            }
            return matrix;
        }

        public static T[,] RemoveRow<T>(T[,] input, int index)
        {
            if (index < 0 || index >= input.GetLength(0))
            {
                throw new ArgumentException("такой строки не существует");
            }
            T[,] output = new T[input.GetLength(0) - 1, input.GetLength(1)];
            for (int i = 0; i < output.GetLength(0); i++)
            {
                for (int j = 0; j < output.GetLength(1); j++)
                {
                    if (i >= index)
                    {
                        output[i, j] = input[i + 1, j];
                    }
                    else
                    {
                        output[i, j] = input[i, j];
                    }
                }
            }
            return output;
        }

        public static T[,] RemoveCollumn<T>(T[,] input, int index)
        {
            if (index < 0 || index >= input.GetLength(1))
            {
                throw new ArgumentException("такого столбца не существует");
            }
            T[,] output = new T[input.GetLength(0), input.GetLength(1) - 1];
            for (int j = 0; j < output.GetLength(1); j++)
            {
                for (int i = 0; i < output.GetLength(0); i++)
                {
                    if (j >= index)
                    {
                        output[i, j] = input[i, j + 1];
                    }
                    else
                    {
                        output[i, j] = input[i, j];
                    }
                }
            }
            return output;
        }

        public static T[,] InsertRow<T>(T[,] input, T[] array, int index)
        {
            if (index < 0 || index > input.GetLength(0))
            {
                throw new ArgumentException("такой строки не существует");
            }
            if (array.Length != input.GetLength(1))
            {
                throw new ArgumentException("неправильный размер строки");
            }
            T[,] output = new T[input.GetLength(0) + 1, input.GetLength(1)];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (i < index)
                    {
                        output[i, j] = input[i, j];
                    }
                    else
                    {
                        output[i + 1, j] = input[i, j];
                    }
                }
            }
            for (int j = 0; j < array.Length; j++)
            {
                output[index, j] = array[j];
            }
            return output;
        }

        public static T[,] InsertCollumn<T>(T[,] input, T[] array, int index)
        {
            if (index < 0 || index > input.GetLength(1))
            {
                throw new ArgumentException("такго столбца не существует");
            }
            if (array.Length != input.GetLength(0))
            {
                throw new ArgumentException("неправильный размер столбца");
            }
            T[,] output = new T[input.GetLength(0), input.GetLength(1) + 1];
            for (int j = 0; j < input.GetLength(1); j++)
            {
                for (int i = 0; i < input.GetLength(0); i++)
                {
                    if (j < index)
                    {
                        output[i, j] = input[i, j];
                    }
                    else
                    {
                        output[i, j + 1] = input[i, j];
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                output[i, index] = array[i];
            }
            return output;
        }

        public static T[][] GetMainD<T>(T[,] matrix)
        {
            int m = matrix.GetLength(0);
            T[][] d = new T[m * 2 - 1][];
            for (int i = 0; i < m; i++)
            {
                d[i] = new T[i + 1];
                for (int j = 0; j < d[i].Length; j++)
                {
                    d[i][j] = matrix[j, m - i - 1 + j];
                }
            }
            for (int i = 0; i < m - 1; i++)
            {
                d[i + m] = new T[m - i - 1];
                for (int j = 0; j < d[i + m].Length; j++)
                {
                    d[i + m][j] = matrix[i + j + 1, j];
                }
            }
            return d;
        }

        public static T[,] GetFromMainD<T>(T[][] matrix)
        {
            return null;
        }

        public static T[][] GetSubMainD<T>(T[,] matrix)
        {
            int m = matrix.GetLength(0);
            T[][] d = new T[m * 2 - 1][];
            for (int i = 0; i < m; i++)
            {
                d[i] = new T[i + 1];
                for (int j = 0; j < d[i].Length; j++)
                {
                    d[i][j] = matrix[i - j, j];
                }
            }
            for (int i = 0; i < m - 1; i++)
            {
                d[i + m] = new T[m - i - 1];
                for (int j = 0; j < d[i + m].Length; j++)
                {
                    d[i + m][j] = matrix[m - 1 - j, i + j + 1];
                }
            }
            return d;
        }

        public static T[,] GetFromSubMainD<T>(T[][] matrix)
        {
            return null;
        }
    }
}
