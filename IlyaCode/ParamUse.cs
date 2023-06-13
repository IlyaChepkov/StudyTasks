using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal partial class Param
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("Param");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            try
            {
                typeof(Param).GetMethod("Param" + taskNumber).Invoke(null, null);
            }
            catch { }
        }

        public static void Param1()
        {
            for (int i = 0; i < 3; i++)
            {
                int[] array = Array.IntInput(int.Parse(Console.ReadLine()));
                Console.WriteLine(MinElem(array));
            }
        }

        public static void Param2()
        {
            for (int i = 0; i < 3; i++)
            {
                double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
                Console.WriteLine(MaxNum(array));
            }
        }

        public static void Param3()
        {
            for (int i = 0; i < 3; i++)
            {
                double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
                int min, max;
                MinmaxNum(array, out min, out max);
                Console.WriteLine(min);
                Console.WriteLine(max);
            }
        }

        public static void Param4()
        {
            for (int i = 0; i < 3; i++)
            {
                double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
                Invert(array);
                Array.Output(array);
            }
        }

        public static void Param5()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            for (int i = 0; i < 5; i++)
            {
                Smooth1(array);
                Array.Output(array);
            }
        }

        public static void Param6()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            for (int i = 0; i < 5; i++)
            {
                Smooth2(array);
                Array.Output(array);
            }
        }

        public static void Param7()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            for (int i = 0; i < 5; i++)
            {
                Smooth3(array);
                Array.Output(array);
            }
        }

        public static void Param8()
        {
            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int[] array = Array.IntInput(int.Parse(Console.ReadLine()));
                RemoveX(array, x);
                Array.Output(array);
            }
        }

        public static void Param9()
        {
            for (int i = 0; i < 3; i++)
            {
                int[] array = Array.IntInput(int.Parse(Console.ReadLine()));
                RemoveForInc(array);
                Array.Output(array);
            }
        }

        public static void Param10()
        {
            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int[] array = Array.IntInput(int.Parse(Console.ReadLine()));
                DoubleX(array, x);
                Array.Output(array);
            }
        }
    }
}
