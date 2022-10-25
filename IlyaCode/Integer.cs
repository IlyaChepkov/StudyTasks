namespace IlyaCode
{
    internal static class Integer
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Integer1");
                        uint l = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(l / 100);
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Integer2");
                        uint m = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(m / 1000);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Integer3");
                        uint b = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(b / 1024);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Integer4");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(a / b);
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("Integer5");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(a % b);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Integer6");
                        byte a = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine(a / 10);
                        Console.WriteLine(a % 10);
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Integer7");
                        byte a = Convert.ToByte(Console.ReadLine());
                        byte b = (byte)(a / 10);
                        byte c = (byte)(a % 10);
                        Console.WriteLine(b + c);
                        Console.WriteLine(b * c);
                    }
                    break;

                case 8:
                    {
                        Console.WriteLine("Integer8");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        byte b = (byte)(a / 10);
                        byte c = (byte)(a % 10);
                        Console.WriteLine(c * 10 + b);
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Integer9");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(a / 100);
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Integer10");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(a % 10);
                        Console.WriteLine((a % 100 - a % 10) / 10);
                    }
                    break;

                case 11:
                    {
                        Console.WriteLine("Integer11");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 100;
                        uint c = (a % 100 - a % 10) / 10;
                        uint d = a % 10;
                        Console.WriteLine(b + c + d);
                        Console.WriteLine(b * c * d);
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Integer12");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 100;
                        uint c = (a % 100 - a % 10) / 10;
                        uint d = a % 10;
                        Console.WriteLine(d * 100 + c * 10 + b);
                    }
                    break;
                case 13:
                    {
                        /*
                        Console.WriteLine("Integer13");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 100;
                        uint c = (a % 100 - a % 10) / 10;
                        uint d = a % 10;
                        Console.WriteLine(c * 100 + d * 10 + b);
                        */
                        Console.WriteLine("Integer13");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 100;
                        uint c = a % 100;
                        Console.WriteLine(c * 10 + b);
                    }
                    break;

                case 14:
                    {
                        Console.WriteLine("Integer14");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a % 10;
                        uint c = a / 10;
                        Console.WriteLine(b * 100 + c);
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Integer15");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 100;
                        uint c = (a % 100 - a % 10) / 10;
                        uint d = a % 10;
                        Console.WriteLine(c * 100 + b * 10 + d);
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("Integer16");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = a / 100;
                        uint c = (a % 100 - a % 10) / 10;
                        uint d = a % 10;
                        Console.WriteLine(b * 100 + d * 10 + c);
                    }
                    break;

                case 17:
                    {
                        Console.WriteLine("Integer17");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(a / 100 % 10);
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("Integer18");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(a / 1000 % 10);
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("Integer19");
                        uint n = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(n / 60);
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Integer20");
                        uint n = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(n / 3600);
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("Integer21");
                        uint n = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(n % 60);
                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("Integer22");
                        uint n = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(n % 3600);
                    }
                    break;

                case 23:
                    {
                        Console.WriteLine("Integer23");
                        uint n = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(n / 60 % 60);
                    }
                    break;
                case 24:
                    {
                        Console.WriteLine("Integer24");
                        uint k = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(k % 7);
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("Integer25");
                        uint k = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine((k + 3) % 7);
                    }
                    break;

                case 26:
                    {
                        Console.WriteLine("Integer26");
                        uint k = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine(k % 7 + 1);
                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("Integer27");
                        uint k = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine((k + 4) % 7 + 1);
                    }
                    break;
                case 28:
                    {
                        Console.WriteLine("Integer28");
                        uint k = Convert.ToUInt32(Console.ReadLine());
                        uint n = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine((((k - 1) + n) % 7) + 1);
                    }
                    break;

                case 29:
                    {
                        Console.WriteLine("Integer29");
                        uint a = Convert.ToUInt32(Console.ReadLine());
                        uint b = Convert.ToUInt32(Console.ReadLine());
                        uint c = Convert.ToUInt32(Console.ReadLine());
                        uint d = (a / c) * (b / c);
                        Console.WriteLine(d);
                        Console.WriteLine((a * b) - (c * c * d));
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("Integer3");
                        uint v = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine((v - 1) / 100 + 1);
                    }
                    break;
            }
        }
    }
}
