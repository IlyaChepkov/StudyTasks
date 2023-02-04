namespace IlyaCode
{
    internal static class OGE
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("OGE");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            try
            {
                typeof(OGE).GetMethod("OGE" + taskNumber).Invoke(null, null);
            }
            catch { }
        }

        public static void OGE836()
        {
            int sum = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            { 
                if (number % 4 == 0 && number % 10 == 8)
                {
                    sum += number;
                }
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
