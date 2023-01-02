namespace IlyaCode
{
    internal static class Proc
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Proc1");
                        for (int i = 0; i < 5; i++)
                        {
                            double b;
                            PowerA3(Convert.ToDouble(Console.ReadLine()), out b);
                            Console.WriteLine(b);
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Proc2");
                        for (int i = 0; i < 5; i++)
                        {
                            double b, c, d;
                            PowerA234(Convert.ToDouble(Console.ReadLine()), out b, out c, out d);
                            Console.WriteLine(b);
                        }
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Proc3");
                        double a = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            double aMean, gMean;
                            Mean( Convert.ToDouble(Console.ReadLine()), a, out aMean, out gMean);
                            Console.WriteLine(aMean);
                            Console.WriteLine(gMean);

                        }
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Proc4");
                        for (int i = 0; i < 3; i++)
                        {
                            double p, s;
                            TrianglePS(Convert.ToDouble(Console.ReadLine()), out p, out s);
                            Console.WriteLine(p);
                            Console.WriteLine(s);
                        }
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Proc5");
                        for (int i = 0; i < 3; i++)
                        {
                            double p, s;
                            RectPS(Convert.ToDouble(Console.ReadLine()),
                                Convert.ToDouble(Console.ReadLine()),
                                Convert.ToDouble(Console.ReadLine()),
                                Convert.ToDouble(Console.ReadLine()), 
                                out p, out s);
                            Console.WriteLine(p);
                            Console.WriteLine(s);

                        }
                    }
                    break;
            }
        }

        public static void PowerA3(double a, out double b)
        {
            b = a * a * a;
        }

        public static void PowerA234(double a, out double b, out double c, out double d)
        {
            b = a * a;
            c = a * a * a;
            d = a * a * a * a;
        }

        public static void Mean(double x, double y, out double aMean, out double gMean)
        {
            aMean = (x + y) / 2;
            gMean = Math.Sqrt(x * y);
        }

        public static void TrianglePS(double a, out double p, out double s)
        { 
            p = a * 3;
            s = (a * a) * Math.Sqrt(3) / 4;
        }

        public static void RectPS(double x1, double y1, double x2, double y2, out double p, out double s)
        {
            x1 = Math.Abs(x1 - x2);
            y1 = Math.Abs(y1 - y2);
            p = (x1 + y1) * 2;
            s = x1 * y2;
        }
    }
}
