namespace IlyaCode
{
    public static class While
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("While1");
                    }
                    break;
            }
        }

    }
}
