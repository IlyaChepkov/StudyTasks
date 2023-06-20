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

        public static void Recur7()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(Combin2(n, k));
            }
        }

        public static void Recur8()
        {
            double x = double.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(RootK(x, k, n));
            }
        }

        public static void Recur9()
        {
            uint a = uint.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                uint bcd = uint.Parse(Console.ReadLine());
                Console.WriteLine(NOD(a, bcd));
            }
        }

        public static void Recur10()
        {
            for (int i = 0; i < 5; i++)
            {
                int bcd = int.Parse(Console.ReadLine());
                Console.WriteLine(DigitSum(bcd));
            }
        }

        public static void Recur11()
        {
            for (int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] bcd = Array.IntInput(n);
                Console.WriteLine(MaxElem(bcd, n));
            }
        }

        public static void Recur12()
        {
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                Console.WriteLine(DigitCount(s));
            }
        }

        public static void Recur13()
        {
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                Console.WriteLine(Palindrom(s));
            }
        }

        public static void Recur14() =>
            Console.WriteLine(Expretion1(Console.ReadLine()));

        public static void Recur15() =>
            Console.WriteLine(Expretion2(Console.ReadLine()));

        public static void Recur16() =>
            Console.WriteLine(Expretion3(Console.ReadLine()));

        public static void Recur17()
        {
            int a = 0;
            Console.WriteLine(Expretion4(Console.ReadLine(), ref a));
        }

        public static void Recur18()
        {
            int a = 0;
            Console.WriteLine(CheckExpretion4(Console.ReadLine(), ref a));
        }

        public static void Recur19()
        {
            int a = 0;
            Console.WriteLine(HardCheckExpretion4(Console.ReadLine(), ref a));
        }

        public static void Recur20()
        {
            int a = 0;
            Console.WriteLine(HardExpretion5(Console.ReadLine(), ref a));
        }

        public static void Recur21()
        {
            int a = 0;
            Console.WriteLine(HardExpretion6(Console.ReadLine(), ref a));
        }

        public static void Recur22()
        {
            int a = 0;
            Console.WriteLine(HardExpretion7(Console.ReadLine(), ref a));
        }

        public static void Recur23()
        {
            int a = 0;
            Console.WriteLine(HardExpretion8(Console.ReadLine(), ref a));
        }

        public static void Recur24()
        {
            int a = 0;
            Console.WriteLine(HardExpretion9(Console.ReadLine(), ref a));
        }
    }
}
