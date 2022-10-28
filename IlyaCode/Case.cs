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
                case 2:
                    {
                        Console.WriteLine("Case2");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                {
                                    Console.WriteLine("Плохо");
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Неудовлетворительно");
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Удовлетворительно");
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Хорошо");
                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("Отлично");
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Ошибка");
                                }
                                break;
                        }
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Case3");
                        switch (Convert.ToByte(Console.ReadLine()))
                        {
                            case 1:
                            case 2:
                            case 12:
                                Console.WriteLine("Зима");
                                break;
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("Весна");
                                break;
                            case 6:
                            case 7:
                            case 8:
                                Console.WriteLine("Лето");
                                break;
                            case 9:
                            case 10:
                            case 11:
                                Console.WriteLine("Осень");
                                break;
                        }
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Case4");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                Console.WriteLine(31);
                                break;
                            case 2:
                                Console.WriteLine(28);
                                break;
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                Console.WriteLine(30);
                                break;
                        }
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Case5");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                {
                                    Console.WriteLine(a + b);
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine(a - b);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine(a * b);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine(a / b);
                                }
                                break;
                        }
                    }
                    break;
            }
        }
    }
}
