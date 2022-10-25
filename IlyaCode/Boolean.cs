namespace IlyaCode
{
    public static class _Boolean
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Boolean1");
                        int a = Convert.ToInt32(Console.ReadLine());
                        bool b = a > 0;
                        Console.WriteLine(b);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Boolean2");
                        int a = Convert.ToInt32(Console.ReadLine());
                        a = a % 2;
                        bool b = a == 1;
                        Console.WriteLine(b);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Boolean3");
                        int a = Convert.ToInt32(Console.ReadLine());
                        a = a % 2;
                        bool b = a == 0;
                        Console.WriteLine(b);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Boolean4");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a > 2 && b <= 3);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Boolean5");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a >= 0 || b < -2);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Boolean6");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a < b && b < c);
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Boolean7");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine((a < b && b < c) || (c < b && b < a));
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Boolean8");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a % 2 == 1 && b % 2 == 1);
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Boolean9");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a % 2 == 1 || b % 2 == 1);
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Boolean10");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine((a % 2 == 1) ^ (b % 2 == 1));
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Boolean11");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine((a % 2 == 1 && b % 2 == 1) || (a % 2 == 0 && b % 2 == 0));
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Boolean12");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a > 0 && b > 0 && c > 0);
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Boolean13");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a > 0 || b > 0 || c > 0);
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("Boolean14");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a > 0 ^ b > 0 ^ c > 0);
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Boolean15");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine((a > 0 && b > 0 && c <= 0) ||
                                            (b > 0 && c > 0 && a <= 0) ||
                                              (a > 0 && c > 0 && b <= 0));
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("Boolean16");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a > 9 && a < 100 && a % 2 == 0);
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("Boolean17");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a > 99 && a < 1000 && a % 2 == 1);
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("Boolean18");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a == b || a == c || b == c);
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("Boolean19");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a == -b || a == -c || b == -c);
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Boolean20");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 100;
                        uint c = (a % 100 - a % 10) / 10;
                        uint d = a % 10;
                        Console.WriteLine(b != c && b != d && c != d);
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("Boolean21");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 100;
                        uint c = (a % 100 - a % 10) / 10;
                        uint d = a % 10;
                        Console.WriteLine(b < c && c < d);
                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("Boolean22");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 100;
                        uint c = (a % 100 - a % 10) / 10;
                        uint d = a % 10;
                        Console.WriteLine((b < c && c < d) || (b > c && c > d));
                    }
                    break;
                case 23:
                    {
                        Console.WriteLine("Boolean23");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 1000;
                        uint c = (a % 1000 - a % 100) / 100;
                        uint d = (a % 100 - a % 10) / 10;
                        uint e = a % 10;
                        Console.WriteLine(b == e && c == d);
                    }
                    break;
                case 24:
                    {
                        Console.WriteLine("Boolean24");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int d = (b * b) - 4 * a * c;
                        Console.WriteLine(d >= 0);
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("Boolean25");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(x < 0 && y > 0);
                    }
                    break;
                case 26:
                    {
                        Console.WriteLine("Boolean26");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(x > 0 && y < 0);
                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("Boolean27");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(x < 0 && y != 0);
                    }
                    break;
                case 28:
                    {
                        Console.WriteLine("Boolean28");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine((x > 0 && y > 0) || (x < 0 && y < 0));
                    }
                    break;
                case 29:
                    {
                        Console.WriteLine("Boolean29");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(x > x1 && x < x2 && y < y1 && y > y2);
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("Boolean30");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a == b && b == c);
                    }
                    break;
                case 31:
                    {
                        Console.WriteLine("Boolean31");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a == c || b == c || b == a);
                    }
                    break;
                case 32:
                    {
                        Console.WriteLine("Boolean32");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b);
                    }
                    break;
                case 33:
                    {
                        Console.WriteLine("Boolean33");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a < (b + c) && b < (a + c) && c < (a + b));
                    }
                    break;
                case 34:
                    {
                        Console.WriteLine("Boolean34");
                       byte x = Convert.ToByte(Console.ReadLine());
                        byte y = Convert.ToByte(Console.ReadLine()); 
                        Console.WriteLine((x + y) % 2 == 1);
                    }
                    break;
                case 35:
                    {
                        Console.WriteLine("Boolean35");
                        byte x1 = Convert.ToByte(Console.ReadLine());
                        byte y1 = Convert.ToByte(Console.ReadLine());
                        byte x2 = Convert.ToByte(Console.ReadLine());
                        byte y2 = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine((x1 + y1) % 2 == (x2 + y2) % 2);
                    }
                    break;
                case 36:
                    {
                        Console.WriteLine("Boolean36");
                        byte x1 = Convert.ToByte(Console.ReadLine());
                        byte y1 = Convert.ToByte(Console.ReadLine());
                        byte x2 = Convert.ToByte(Console.ReadLine());
                        byte y2 = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine(x1 == x2 || y1 == y2);
                    }
                    break;
                case 37:
                    {
                        Console.WriteLine("Boolean37");
                        byte x1 = Convert.ToByte(Console.ReadLine());
                        byte y1 = Convert.ToByte(Console.ReadLine());
                        byte x2 = Convert.ToByte(Console.ReadLine());
                        byte y2 = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine(x1 >= x2 - 1 && x1 <= x2 + 1 && y1 >= y2 - 1 && y1 <= y2 + 1);
                    }
                    break;
                case 38:
                    {
                        Console.WriteLine("Boolean38");
                        byte x1 = Convert.ToByte(Console.ReadLine());
                        byte y1 = Convert.ToByte(Console.ReadLine());
                        byte x2 = Convert.ToByte(Console.ReadLine());
                        byte y2 = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine(Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
                    }
                    break;
                case 39:
                    {
                        Console.WriteLine("Boolean39");
                        byte x1 = Convert.ToByte(Console.ReadLine());
                        byte y1 = Convert.ToByte(Console.ReadLine());
                        byte x2 = Convert.ToByte(Console.ReadLine());
                        byte y2 = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine((Math.Abs(x1 - x2) == Math.Abs(y1 - y2)) || (x1 == x2 || y1 == y2));
                    }
                    break;
                case 40:
                    {
                        Console.WriteLine("Boolean40");
                        byte x1 = Convert.ToByte(Console.ReadLine());
                        byte y1 = Convert.ToByte(Console.ReadLine());
                        byte x2 = Convert.ToByte(Console.ReadLine());
                        byte y2 = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine((x1 - 1 == x2 && y1 - 2 == y2) ||
                            (x1 - 2 == x2 && y1 - 1 == y2) ||
                            (x1 - 1 == x2 && y1 + 2 == y2) ||
                            (x1 - 2 == x2 && y1 + 1 == y2) ||
                            (x1 + 1 == x2 && y1 - 2 == y2) ||
                            (x1 + 2 == x2 && y1 - 1 == y2) ||
                            (x1 + 1 == x2 && y1 + 2 == y2) ||
                            (x1 + 2 == x2 && y1 + 1 == y2));
                    }
                    break;
            }
        }
    }
}
