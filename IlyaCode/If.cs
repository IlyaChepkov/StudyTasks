namespace IlyaCode
{
    internal static class If
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("If1");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a > 0)
                        {
                            a++;
                        }
                        Console.WriteLine(a);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("If2");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a > 0)
                        {
                            a++;
                        }
                        else
                        {
                            a -= 2;
                        }
                        Console.WriteLine(a);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("If3");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a > 0)
                        {
                            a++;
                        }
                        else
                        {
                            if (a == 0)
                            {
                                a = 10;
                            }
                            else
                            {
                                a -= 2;
                            }
                        }
                        Console.WriteLine(a);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("If4");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        byte count = 0;
                        if (a > 0)
                        {
                            count++;
                        }
                        if (b > 0)
                        {
                            count++;
                        }
                        if (c > 0)
                        {
                            count++;
                        }
                        Console.WriteLine(count);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("If5");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        byte countP = 0;
                        byte countO = 0;
                        if (a > 0)
                        {
                            countP++;
                        }
                        else
                        {
                            if (a != 0)
                            {
                                countO++;
                            }
                        }
                        if (b > 0)
                        {
                            countP++;
                        }
                        else
                        {
                            if (b != 0)
                            {
                                countO++;
                            }
                        }
                        if (c > 0)
                        {
                            countP++;
                        }
                        else
                        {
                            if (c != 0)
                            {
                                countO++;
                            }
                        }
                        Console.WriteLine(countP);
                        Console.WriteLine(countO);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("If6");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        if (a > b)
                        {
                            Console.WriteLine(a);
                        }
                        else
                        {
                            Console.WriteLine(b);
                        }
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("If7");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        if (a <= b)
                        {
                            Console.WriteLine(1);
                        }
                        else
                        {
                            Console.WriteLine(2);
                        }
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("If8");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        if (a > b)
                        {
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                        }
                        else
                        {
                            Console.WriteLine(b);
                            Console.WriteLine(a);
                        }
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("If9");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (a > b)
                        {
                            double c = a;
                            a = b;
                            b = c;
                        }
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("If10");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        if (a != b)
                        {
                            a = a + b;
                            b = a;
                        }
                        else
                        {
                            b = 0;
                            a = 0;
                        }
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("If11");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        if (a != b)
                        {
                            if (a > b)
                            {
                                b = a;
                            }
                            else
                            {
                                a = b;
                            }
                        }
                        else
                        {
                            a = 0;
                            b = 0;
                        }
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("If12");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (a < b)
                        {
                            if (a < c)
                            {
                                Console.WriteLine(a);
                            }
                            else
                            {
                                Console.WriteLine(c);
                            }
                        }
                        else
                        {
                            if (b < c)
                            {
                                Console.WriteLine(b);
                            }
                            else
                            {
                                Console.WriteLine(c);
                            }
                        }
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("If13");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (a < b)
                        {
                            if (a > c)
                            {
                                Console.WriteLine(a);
                            }
                            else
                            {
                                Console.WriteLine(c);
                            }
                        }
                        else
                        {
                            if (b > c)
                            {
                                Console.WriteLine(b);
                            }
                            else
                            {
                                Console.WriteLine(c);
                            }
                        }
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("If14");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (a < b)
                        {
                            if (a < c)
                            {
                                Console.WriteLine(a);
                                if (b > c)
                                {
                                    Console.WriteLine(b);
                                }
                                else
                                {
                                    Console.WriteLine(c);
                                }
                            }
                            else
                            {
                                Console.WriteLine(c);
                                Console.WriteLine(b);
                            }
                        }
                        else
                        {
                            if (b < c)
                            {
                                Console.WriteLine(b);
                                if (a > c)
                                {
                                    Console.WriteLine(a);
                                }
                                else
                                {
                                    Console.WriteLine(c);
                                }
                            }
                            else
                            {
                                Console.WriteLine(c);
                                Console.WriteLine(a);
                            }
                        }
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("If15");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (a < b)
                        {
                            if (a < c)
                            {
                                Console.WriteLine(b + c);
                            }
                            else
                            {
                                Console.WriteLine(a + b);
                            }
                        }
                        else
                        {
                            if (b < c)
                            {
                                Console.WriteLine(a + c);
                            }
                            else
                            {
                                Console.WriteLine(a + b);
                            }
                        }
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("If16");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double c = Convert.ToDouble(Console.ReadLine());
                        if (a < b && b < c)
                        {
                            a += a;
                            b += b;
                            c += c;
                        }
                        else
                        {
                            a = -a;
                            b = -b;
                            c = -c;
                        }
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("If17");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double c = Convert.ToDouble(Console.ReadLine());
                        if ((a < b && b < c) || (a > b && b > c))
                        {
                            a += a;
                            b += b;
                            c += c;
                        }
                        else
                        {
                            a = -a;
                            b = -b;
                            c = -c;
                        }
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("If18");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (a == b)
                        {
                            Console.WriteLine(3);
                        }
                        else
                        {
                            if (b == c)
                            {
                                Console.WriteLine(1);
                            }
                            else
                            {
                                Console.WriteLine(2);
                            }
                        }
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("If19");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int d = Convert.ToInt32(Console.ReadLine()); // лол, оно не используется
                        if (a == b)
                        {
                            if (b == c)
                            {
                                Console.WriteLine(4);
                            }
                            else
                            {
                                Console.WriteLine(3);
                            }
                        }
                        else
                        {
                            if (b == c)
                            {
                                Console.WriteLine(1);
                            }
                            else
                            {
                                Console.WriteLine(2);
                            }
                        }
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("If20");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int sb = Math.Abs(a - b);
                        int sc = Math.Abs(a - c);
                        if (sc == sb && b != c)
                        {
                            Console.WriteLine("Неоднозначность");
                        }
                        else
                        {
                            if (sb < sc)
                            {
                                Console.WriteLine(b);
                                Console.WriteLine(sb);
                            }
                            else
                            {
                                Console.WriteLine(c);
                                Console.WriteLine(sc);
                            }
                        }
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("If21");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (x == 0 && y == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            if (y == 0)
                            {
                                Console.WriteLine(1);
                            }
                            else
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine(2);
                                }
                                else
                                {
                                    Console.WriteLine(3);
                                }

                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("If22");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (x > 0)
                        {
                            if (y > 0)
                            {
                                Console.WriteLine(1);
                            }
                            else
                            {
                                Console.WriteLine(4);
                            }
                        }
                        else
                        {
                            if (y > 0)
                            {
                                Console.WriteLine(2);
                            }
                            else
                            {
                                Console.WriteLine(3);
                            }
                        }
                    }
                    break;
                case 23:
                    {
                        Console.WriteLine("If23");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        int x3 = Convert.ToInt32(Console.ReadLine());
                        int y3 = Convert.ToInt32(Console.ReadLine());
                        if (x1 == x2)
                        {
                            Console.WriteLine(x3);
                            if (y2 == y3)
                            {
                                Console.WriteLine(y1);
                            }
                            else
                            {
                                Console.WriteLine(y2);
                            }
                        }
                        else
                        {
                            if (x1 == x3)
                            {
                                Console.WriteLine(x2);
                                if (y2 == y3)
                                {
                                    Console.WriteLine(y1);
                                }
                                else
                                {
                                    Console.WriteLine(y3);
                                }
                            }
                            else
                            {
                                Console.WriteLine(x1);
                                if (y1 == y3)
                                {
                                    Console.WriteLine(y2);
                                }
                                else
                                {
                                    Console.WriteLine(y3);
                                }
                            }
                        }
                    }
                    break;
                case 24:
                    {
                        Console.WriteLine("If24");
                        double x = Convert.ToDouble(Console.ReadLine());
                        if (x > 0)
                        {
                            x = Math.Sin(x) * 2;
                        }
                        else
                        {
                            x = 6 - x;
                        }
                        Console.WriteLine(x);
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("If25");
                        int x = Convert.ToInt32(Console.ReadLine());
                        if (x < -2 || x > 2)
                        {
                            x *= 2;
                        }
                        else
                        {
                            x *= -3;
                        }
                        Console.WriteLine(x);
                    }
                    break;
                case 26:
                    {
                        Console.WriteLine("If26");
                        double x = Convert.ToDouble(Console.ReadLine());
                        if (x <= 0)
                        {
                            x = -x;
                        }
                        else
                        {
                            if (x < 2)
                            {
                                x *= x;
                            }
                            else
                            {
                                x = 4;
                            }
                        }
                        Console.WriteLine(x);
                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("If27");
                        double x = Convert.ToDouble(Console.ReadLine());
                        if (x < 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            if (((int)x) % 2 == 0)
                            {
                                Console.WriteLine(1);
                            }
                            else
                            {
                                Console.WriteLine(-1);
                            }
                        }
                    }
                    break;
                case 28:
                    {
                        Console.WriteLine("If28");
                        uint year = Convert.ToUInt32(Console.ReadLine());
                        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                        {
                            Console.WriteLine(366);
                        }
                        else
                        {
                            Console.WriteLine(365);
                        }
                    }
                    break;
                case 29:
                    {
                        Console.WriteLine("If29");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a == 0)
                        {
                            Console.WriteLine("нулевое число");
                        }
                        else
                        {
                            if (a < 0)
                            {
                                Console.Write("отрицательное ");
                            }
                            else
                            {
                                Console.Write("положительное ");
                            }
                            if (a % 2 == 0)
                            {
                                Console.WriteLine("четное число");
                            }
                            else
                            {
                                Console.WriteLine("нечетное число");
                            }
                        }
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("If30");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        if (a % 2 == 0)
                        {
                            Console.Write("четное ");
                        }
                        else
                        {
                            Console.Write("нечетное ");
                        }
                        if(a >= 100 )
                        {
                            Console.WriteLine("трехзначное число");
                        }
                        else
                        {
                            if (a >= 10)
                            {
                                Console.WriteLine("двухзначное число");
                            }
                            else
                            {
                                Console.WriteLine("однозначное число");
                            }
                        }
                    }
                    break;
            }
        }
    }
}
