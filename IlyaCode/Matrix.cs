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
