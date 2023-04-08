using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
