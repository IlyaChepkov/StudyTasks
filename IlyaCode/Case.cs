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
                        switch (Convert.ToByte(Console.ReadLine()))
                        {
                            case 1:
                                {
                                    Console.WriteLine("Понедельник");
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Вторник");
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Среда");
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Четверг");
                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("Пятница");
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("Суббота");
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("Воскресенье");
                                }
                                break;
                        }
                    }
                    break;
            }
        }
    }
}
