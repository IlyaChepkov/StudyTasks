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
    }
}
