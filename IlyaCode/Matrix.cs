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
                throw new ArgumentException("Ты болбес таких строк не существует");
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
                throw new ArgumentException("Ты болбес таких столбцов не существует");
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Proc.Swap(ref matrix[i, firstIndex], ref matrix[i, SecondIndex]);
            }
            return matrix;
        }
    }
}
