using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal partial class Recur
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("Recur");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            try
            {
                typeof(Recur).GetMethod("Recur" + taskNumber).Invoke(null, null);
            }
            catch { }
        }

        public static void Recur1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(FactN(int.Parse(Console.ReadLine())));
            }
        }

        public static void Recur2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Fact2(int.Parse(Console.ReadLine())));
            }
        }

        public static void Recur3()
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(PowerN(x, int.Parse(Console.ReadLine())));
            }
        }

        public static void Recur4()
        {
            for (int i = 0; i < 5; i++)
            {
                int count = 0;
                Console.WriteLine(Fib1(int.Parse(Console.ReadLine()), ref count));
                Console.WriteLine(count);
            }
        }

        public static void Recur5()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Fib2(int.Parse(Console.ReadLine())));
            }
        }

        public static void Recur6()
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                int count = 0;
                Console.WriteLine(Combin1(x, int.Parse(Console.ReadLine()), ref count));
                Console.WriteLine(count);
            }
        }
    }
}
