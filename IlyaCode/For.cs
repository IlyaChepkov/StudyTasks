namespace IlyaCode
{
    public static class For
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("For1");
                    }
                    break;
            }
        }
    }
}
