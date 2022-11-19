using System.ComponentModel;

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
                                    switch (c)
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
                        Console.WriteLine("Case11");
                        string c = Console.ReadLine();
                        sbyte n1 = Convert.ToSByte(Console.ReadLine());
                        sbyte n2 = Convert.ToSByte(Console.ReadLine());
                        switch (Math.Abs(n1 + n2) % 4)
                        {
                            case 0:
                                {
                                    Console.WriteLine(c);
                                }
                                break;
                            case 1:
                                {
                                    switch (c)
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
                            case 2:
                                {
                                    switch (c)
                                    {
                                        case "С":
                                            {
                                                Console.WriteLine("Ю");
                                            }
                                            break;
                                        case "З":
                                            {
                                                Console.WriteLine("В");
                                            }
                                            break;
                                        case "Ю":
                                            {
                                                Console.WriteLine("С");
                                            }
                                            break;
                                        case "В":
                                            {
                                                Console.WriteLine("З");
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 3:
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
                case 12:
                    {
                        Console.WriteLine("Case12");
                        byte number = Convert.ToByte(Console.ReadLine());
                        double value = Convert.ToDouble(Console.ReadLine());
                        switch (number)
                        {
                            case 1:
                                {
                                    double r = value;
                                    Console.WriteLine(2 * r);
                                    Console.WriteLine(6.28 * r);
                                    Console.WriteLine(3.14 * (r * r));
                                }
                                break;
                            case 2:
                                {
                                    double r = value / 2;
                                    Console.WriteLine(r);
                                    Console.WriteLine(6.28 * r);
                                    Console.WriteLine(3.14 * (r * r));
                                }
                                break;
                            case 3:
                                {
                                    double r = value / 6.28;
                                    Console.WriteLine(r);
                                    Console.WriteLine(2 * r);
                                    Console.WriteLine(3.14 * (r * r));
                                }
                                break;
                            case 4:
                                {
                                    double r = Math.Sqrt(value / 3.14);
                                    Console.WriteLine(r);
                                    Console.WriteLine(2 * r);
                                    Console.WriteLine(6.28 * r);
                                }
                                break;
                        }
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Case13");
                        byte number = Convert.ToByte(Console.ReadLine());
                        double value = Convert.ToDouble(Console.ReadLine());
                        switch (number)
                        {
                            case 1:
                                {
                                    double c = value * Math.Sqrt(2);
                                    Console.WriteLine(c);
                                    Console.WriteLine(c / 2);
                                    Console.WriteLine(c * c / 4);
                                }
                                break;
                            case 2:
                                {
                                    double c = value;
                                    Console.WriteLine(c / Math.Sqrt(2));
                                    Console.WriteLine(c / 2);
                                    Console.WriteLine(c * c / 4);
                                }
                                break;
                            case 3:
                                {
                                    double c = value * 2;
                                    Console.WriteLine(c / Math.Sqrt(2));
                                    Console.WriteLine(c);
                                    Console.WriteLine(c * c / 4);
                                }
                                break;
                            case 4:
                                {
                                    double c = Math.Sqrt(value * 4);
                                    Console.WriteLine(c / Math.Sqrt(2));
                                    Console.WriteLine(c);
                                    Console.WriteLine(c / 2);
                                }
                                break;
                        }
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("Case14");
                        byte number = Convert.ToByte(Console.ReadLine());
                        double value = Convert.ToDouble(Console.ReadLine());
                        switch (number)
                        {
                            case 1:
                                {
                                    double a = value;
                                    Console.WriteLine(a * Math.Sqrt(3) / 6);
                                    Console.WriteLine(a * Math.Sqrt(3) / 3);
                                    Console.WriteLine((a * a) * Math.Sqrt(3) / 4);
                                }
                                break;
                            case 2:
                                {
                                    double a = value / (6 / Math.Sqrt(3));
                                    Console.WriteLine(a);
                                    Console.WriteLine(value * 2);
                                    Console.WriteLine((a * a) * Math.Sqrt(3) / 4);
                                }
                                break;
                            case 3:
                                {
                                    double a = value / (3 / Math.Sqrt(3));
                                    Console.WriteLine(a);
                                    Console.WriteLine(value / 2);
                                    Console.WriteLine((a * a) * Math.Sqrt(3) / 4);
                                }
                                break;
                            case 4:
                                {
                                    double a = Math.Sqrt(value * 4 / Math.Sqrt(3));
                                    Console.WriteLine(a);
                                    Console.WriteLine(a * Math.Sqrt(3) / 6);
                                    Console.WriteLine(a * Math.Sqrt(3) / 3);
                                }
                                break;
                        }
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Case15");
                        byte n = Convert.ToByte(Console.ReadLine());
                        byte m = Convert.ToByte(Console.ReadLine());
                        switch (n)
                        {
                            case 6:
                                {
                                    Console.Write("шестерка");
                                }
                                break;
                            case 7:
                                {
                                    Console.Write("семерка");
                                }
                                break;
                            case 8:
                                {
                                    Console.Write("восьмерка");
                                }
                                break;
                            case 9:
                                {
                                    Console.Write("девятка");
                                }
                                break;
                            case 10:
                                {
                                    Console.Write("десятка");
                                }
                                break;
                            case 11:
                                {
                                    Console.Write("валет");
                                }
                                break;
                            case 12:
                                {
                                    Console.Write("дама");
                                }
                                break;
                            case 13:
                                {
                                    Console.Write("король");
                                }
                                break;
                            case 14:
                                {
                                    Console.Write("туз");
                                }
                                break;
                        }
                        switch (n)
                        {
                            case 1:
                                {
                                    Console.WriteLine(" пик");
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine(" треф");
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine(" бубен");
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine(" червей");
                                }
                                break;
                        }
                        break;
                    }
                case 16:
                    {
                        Console.WriteLine("Case16");
                        byte years = Convert.ToByte(Console.ReadLine());
                        switch (years / 10)
                        {
                            case 2:
                                {
                                    Console.Write("двадцать ");
                                }
                                break;
                            case 3:
                                {
                                    Console.Write("тридцать ");
                                }
                                break;
                            case 4:
                                {
                                    Console.Write("сорок ");
                                }
                                break;
                            case 5:
                                {
                                    Console.Write("пятьдесят ");
                                }
                                break;
                            case 6:
                                {
                                    Console.Write("шестьдесят ");
                                }
                                break;
                        }
                        switch (years % 10)
                        {
                            case 0:
                                {
                                    Console.WriteLine("лет");
                                }
                                break;
                            case 1:
                                {
                                    Console.WriteLine("один год");
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("два года");
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("три года");
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("четыре года");
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("шесть лет");
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("семь лет");
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("восемь лет");
                                }
                                break;
                            case 9:
                                {
                                    Console.WriteLine("девять лет");
                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("пять лет");
                                }
                                break;
                        }
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("Case17");
                        byte years = Convert.ToByte(Console.ReadLine());
                        if (years < 20)
                        {
                            switch (years)
                            {
                                case 10:
                                    {
                                        Console.WriteLine("десять учебных заданий");
                                    }
                                    break;
                                case 11:
                                    {
                                        Console.WriteLine("одиннадцать учебных заданий");
                                    }
                                    break;
                                case 12:
                                    {
                                        Console.WriteLine("двенадцать учебных заданий");
                                    }
                                    break;
                                case 13:
                                    {
                                        Console.WriteLine("тринадцать учебных заданий");
                                    }
                                    break;
                                case 14:
                                    {
                                        Console.WriteLine("четырнадцать учебных заданий");
                                    }
                                    break;
                                case 15:
                                    {
                                        Console.WriteLine("пятнадцать учебных заданий");
                                    }
                                    break;
                                case 16:
                                    {
                                        Console.WriteLine("шестнадцать учебных заданий");
                                    }
                                    break;
                                case 17:
                                    {
                                        Console.WriteLine("семнадцать учебных заданий");
                                    }
                                    break;
                                case 18:
                                    {
                                        Console.WriteLine("восемнадцать учебных заданий");
                                    }
                                    break;
                                case 19:
                                    {
                                        Console.WriteLine("девятнадцать учебных заданий");
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch (years / 10)
                            {
                                case 2:
                                    {
                                        Console.Write("двадцать ");
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.Write("тридцать ");
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.Write("сорок ");
                                    }
                                    break;
                            }
                            switch (years % 10)
                            {
                                case 0:
                                    {
                                        Console.WriteLine("учебных заданий");
                                    }
                                    break;
                                case 1:
                                    {
                                        Console.WriteLine("одно учебное задание");
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("два учебных задания");
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("три учебных задания");
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine("четыре учебных задания");
                                    }
                                    break;
                                case 6:
                                    {
                                        Console.WriteLine("шесть учебных заданий");
                                    }
                                    break;
                                case 7:
                                    {
                                        Console.WriteLine("семь учебных заданий");
                                    }
                                    break;
                                case 8:
                                    {
                                        Console.WriteLine("восемь учебных заданий");
                                    }
                                    break;
                                case 9:
                                    {
                                        Console.WriteLine("девять учебных заданий");
                                    }
                                    break;
                                case 5:
                                    {
                                        Console.WriteLine("пять учебных заданий");
                                    }
                                    break;
                            }
                        }
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("Case3");
                        int value = Convert.ToInt32(Console.ReadLine());
                        switch (value / 100)
                        {
                            case 1:
                                {
                                    Console.Write("сто ");
                                }
                                break;
                            case 2:
                                {
                                    Console.Write("двести ");
                                }
                                break;
                            case 3:
                                {
                                    Console.Write("триста ");
                                }
                                break;
                            case 4:
                                {
                                    Console.Write("четыреста ");
                                }
                                break;
                            case 5:
                                {
                                    Console.Write("пятьсот ");
                                }
                                break;
                            case 6:
                                {
                                    Console.Write("шестьсот ");
                                }
                                break;
                            case 7:
                                {
                                    Console.Write("семьсот ");
                                }
                                break;
                            case 8:
                                {
                                    Console.Write("восемьсот ");
                                }
                                break;
                            case 9:
                                {
                                    Console.Write("девятьсот ");
                                }
                                break;
                        }
                        bool marker = true;
                        switch (value % 100 / 10)
                        {
                            case 1:
                                {
                                    marker = false;
                                    switch (value % 10)
                                    {
                                        case 0:
                                            {
                                                Console.WriteLine("десять");
                                            }
                                            break;
                                        case 1:
                                            {
                                                Console.WriteLine("одиннадцать");
                                            }
                                            break;
                                        case 2:
                                            {
                                                Console.WriteLine("двенадцать");
                                            }
                                            break;
                                        case 3:
                                            {
                                                Console.WriteLine("тринадцать");
                                            }
                                            break;
                                        case 4:
                                            {
                                                Console.WriteLine("четырнадцать");
                                            }
                                            break;
                                        case 5:
                                            {
                                                Console.WriteLine("пятнадцать");
                                            }
                                            break;
                                        case 6:
                                            {
                                                Console.WriteLine("шестнадцать");
                                            }
                                            break;
                                        case 7:
                                            {
                                                Console.WriteLine("семнадцать");
                                            }
                                            break;
                                        case 8:
                                            {
                                                Console.WriteLine("восемнадцать");
                                            }
                                            break;
                                        case 9:
                                            {
                                                Console.WriteLine("девятнадцать");
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    Console.Write("двадцать ");
                                }
                                break;
                            case 3:
                                {
                                    Console.Write("тридцать ");
                                }
                                break;
                            case 4:
                                {
                                    Console.Write("сорок ");
                                }
                                break;
                            case 5:
                                {
                                    Console.Write("пятьдесят ");
                                }
                                break;
                            case 6:
                                {
                                    Console.Write("шестьдесят ");
                                }
                                break;
                            case 7:
                                {
                                    Console.Write("семьдесят ");
                                }
                                break;
                            case 8:
                                {
                                    Console.Write("восемьдесят ");
                                }
                                break;
                            case 9:
                                {
                                    Console.Write("девяносто ");
                                }
                                break;
                        }
                        if (marker)
                        {
                            switch (value % 10)
                            {
                                case 0:
                                    {
                                        Console.WriteLine("");
                                    }
                                    break;
                                case 1:
                                    {
                                        Console.WriteLine("один");
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("два");
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("три");
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine("четыре");
                                    }
                                    break;
                                case 5:
                                    {
                                        Console.WriteLine("пять");
                                    }
                                    break;
                                case 6:
                                    {
                                        Console.WriteLine("шесть");
                                    }
                                    break;
                                case 7:
                                    {
                                        Console.WriteLine("семь");
                                    }
                                    break;
                                case 8:
                                    {
                                        Console.WriteLine("восемь");
                                    }
                                    break;
                                case 9:
                                    {
                                        Console.WriteLine("девять");
                                    }
                                    break;
                            }
                        }

                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("Case19");
                        byte year = (byte)((Convert.ToInt32(Console.ReadLine()) + 56) % 60);
                        bool isWomen = true;
                        switch (year % 12)
                        {
                            case 2:
                            case 3:
                            case 4:
                                {
                                    isWomen = false;
                                }
                                break;
                        }
                        switch (year / 12)
                        {
                            case 0:
                                {
                                    Console.Write(isWomen ? "зеленая " : "зеленый ");
                                }
                                break;
                            case 1:
                                {
                                    Console.Write(isWomen ? "красная " : "красный ");
                                }
                                break;
                            case 2:
                                {
                                    Console.Write(isWomen ? "желтая " : "желтый ");
                                }
                                break;
                            case 3:
                                {
                                    Console.Write(isWomen ? "белая " : "белый ");
                                }
                                break;
                            case 4:
                                {
                                    Console.Write(isWomen ? "черная " : "черный ");
                                }
                                break;
                        }
                        Console.WriteLine((year % 12) switch
                        {
                            0 => "крыса",
                            1 => "корова",
                            2 => "тигр",
                            3 => "заяц",
                            4 => "дракон",
                            5 => "змея",
                            6 => "лошадь",
                            7 => "овца",
                            8 => "обезьяна",
                            9 => "курица",
                            10 => "собака",
                            11 => "свинья",
                        });
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Case20");
                        byte d = Convert.ToByte(Console.ReadLine());
                        byte m = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine(m switch 
                        {
                            1 => d >= 20 ? "Водолей" : "Козерог",
                            2 => d >= 18 ? "Рыбы" : "Водолей",
                            3 => d >= 20 ? "Овен" : "Рыбы",
                            4 => d >= 19 ? "Телец" : "Овен",
                            5 => d >= 20 ? "Близнецы" : "Телец",
                            6 => d >= 21 ? "Рак" : "Близнецы",
                            7 => d >= 22 ? "Лев" : "Рак",
                            8 => d >= 22 ? "Дева" : "Лев",
                            9 => d >= 22 ? "Весы" : "Дева",
                            10 => d >= 22 ? "Скорпион" : "Весы",
                            11 => d >= 22 ? "Стрелец" : "Скорпион",
                            12 => d >= 21 ? "Козерог" : "Стрелец",
                        });
                    }
                    break;
            }
        }
    }
}
