namespace IlyaCode
{
    internal static class Case
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Case1");
                    break;
            }
        }
    }
}
