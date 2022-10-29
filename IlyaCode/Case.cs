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
                        byte n = Convert.ToByte(Console.ReadLine());
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        switch (n)
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
                case 6:
                    {
                        Console.WriteLine("Case6");
                        byte b = Convert.ToByte(Console.ReadLine());
                        double d = Convert.ToDouble(Console.ReadLine());
                        switch (b)
                        {
                            case 1:
                                {
                                    Console.WriteLine(d / 10);
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine(d * 1000);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine(d);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine(d / 1000);
                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine(d / 100);
                                }
                                break;
                        }
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Case7");
                        byte b = Convert.ToByte(Console.ReadLine());
                        double m = Convert.ToDouble(Console.ReadLine());
                        switch (b)
                        {
                            case 1:
                                {
                                    Console.WriteLine(m);
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine(m / 1000000);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine(m / 1000);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine(m * 1000);
                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine(m * 100);
                                }
                                break;
                        }
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Case8");
                        byte d = Convert.ToByte(Console.ReadLine());
                        byte m = Convert.ToByte(Console.ReadLine());
                        if (d != 1)
                        {
                            Console.WriteLine(d - 1);
                            Console.WriteLine(m);
                        }
                        else
                        {
                            if (m == 1)
                            {
                                Console.WriteLine(31);
                                Console.WriteLine(12);
                            }
                            else
                            {
                                switch (m - 1)
                                {
                                    case 1:
                                    case 3:
                                    case 5:
                                    case 7:
                                    case 8:
                                    case 10:
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
                                Console.WriteLine(m - 1);
                            }
                        }
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Case9");
                        byte d = Convert.ToByte(Console.ReadLine());
                        byte m = Convert.ToByte(Console.ReadLine());
                        byte dayCount = 0;
                        switch (m)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                dayCount = 31;
                                break;
                            case 2:
                                dayCount = 28;
                                break;
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                dayCount = 30;
                                break;
                        }
                        if (d == dayCount)
                        {
                            Console.WriteLine(1);
                            if (m == 12)
                            {
                                Console.WriteLine(1);
                            }
                            else
                            {
                                Console.WriteLine(m + 1);
                            }
                        }
                        else
                        {
                            Console.WriteLine(d + 1);
                            Console.WriteLine(m);
                        }
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Case10");
                        string c = Console.ReadLine();
                        sbyte n = Convert.ToSByte(Console.ReadLine());
                        switch (n)
                        {
                            case 0:
                                {
                                    Console.WriteLine(c);
                                }
                                break;
                            case 1:
                                {
                                    switch(c)
                                    {
                                        case "С":
                                            {
                                                Console.WriteLine("З");
                                            }
                                            break;
                                        case "З":
                                            {
                                                Console.WriteLine("Ю");
                                            }
                                            break;
                                        case "Ю":
                                            {
                                                Console.WriteLine("В");
                                            }
                                            break;
                                        case "В":
                                            {
                                                Console.WriteLine("С");
                                            }
                                            break;
                                    }
                                }
                                break;
                            case -1:
                                {
                                    switch (c)
                                    {
                                        case "С":
                                            {
                                                Console.WriteLine("В");
                                            }
                                            break;
                                        case "З":
                                            {
                                                Console.WriteLine("С");
                                            }
                                            break;
                                        case "Ю":
                                            {
                                                Console.WriteLine("З");
                                            }
                                            break;
                                        case "В":
                                            {
                                                Console.WriteLine("Ю");
                                            }
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case 11:
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
                case 12:
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
                case 13:
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
                case 14:
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
                case 15:
                    {
                        Console.WriteLine("Case5");
                        byte n = Convert.ToByte(Console.ReadLine());
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        switch (n)
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
                case 16:
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
                case 17:
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
                case 18:
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
                case 19:
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
                case 20:
                    {
                        Console.WriteLine("Case5");
                        byte n = Convert.ToByte(Console.ReadLine());
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        switch (n)
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
