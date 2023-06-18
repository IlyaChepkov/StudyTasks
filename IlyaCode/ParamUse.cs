namespace IlyaCode
{
    internal partial class Param
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("Param");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            try
            {
                typeof(Param).GetMethod("Param" + taskNumber).Invoke(null, null);
            }
            catch { }
        }

        public static void Param1()
        {
            for (int i = 0; i < 3; i++)
            {
                int[] array = Array.IntInput(int.Parse(Console.ReadLine()));
                Console.WriteLine(MinElem(array));
            }
        }

        public static void Param2()
        {
            for (int i = 0; i < 3; i++)
            {
                double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
                Console.WriteLine(MaxNum(array));
            }
        }

        public static void Param3()
        {
            for (int i = 0; i < 3; i++)
            {
                double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
                int min, max;
                MinmaxNum(array, out min, out max);
                Console.WriteLine(min);
                Console.WriteLine(max);
            }
        }

        public static void Param4()
        {
            for (int i = 0; i < 3; i++)
            {
                double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
                Invert(array);
                Array.Output(array);
            }
        }

        public static void Param5()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            for (int i = 0; i < 5; i++)
            {
                Smooth1(array);
                Array.Output(array);
            }
        }

        public static void Param6()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            for (int i = 0; i < 5; i++)
            {
                Smooth2(array);
                Array.Output(array);
            }
        }

        public static void Param7()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            for (int i = 0; i < 5; i++)
            {
                Smooth3(array);
                Array.Output(array);
            }
        }

        public static void Param8()
        {
            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int[] array = Array.IntInput(int.Parse(Console.ReadLine()));
                RemoveX(array, x);
                Array.Output(array);
            }
        }

        public static void Param9()
        {
            for (int i = 0; i < 3; i++)
            {
                int[] array = Array.IntInput(int.Parse(Console.ReadLine()));
                RemoveForInc(array);
                Array.Output(array);
            }
        }

        public static void Param10()
        {
            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int[] array = Array.IntInput(int.Parse(Console.ReadLine()));
                DoubleX(array, x);
                Array.Output(array);
            }
        }

        public static void Param11()
        {
            for (int i = 0; i < 3; i++)
            {
                double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
                SortArray(array);
                Array.Output(array);
            }
        }
        public static void Param12()
        {
            for (int i = 0; i < 3; i++)
            {
                double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
                Array.Output(SortIndex(array));
            }
        }
        public static void Param13()
        {
            for (int i = 0; i < 3; i++)
            {
                double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
                Bell(array);
                Array.Output(array);
            }
        }
        public static void Param14()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            double[] odd, even;
            Split1(array, out odd, out even);
            Array.Output(odd);
            Array.Output(even);
        }
        public static void Param15()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            double[] odd, even;
            Split2(array, out odd, out even);
            Array.Output(odd);
            Array.Output(even);
        }

        public static void Param16()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            int m = int.Parse(Console.ReadLine()),
                n = int.Parse(Console.ReadLine());
            Matrix.Output(ArrayToMatrRow(array, m, n));
        }

        public static void Param17()
        {
            double[] array = Array.DoubleInput(int.Parse(Console.ReadLine()));
            int m = int.Parse(Console.ReadLine()),
                n = int.Parse(Console.ReadLine());
            Matrix.Output(ArrayToMatrCol(array, m, n));
        }

        public static void Param18()
        {
            int m = int.Parse(Console.ReadLine()),
                n = int.Parse(Console.ReadLine());
            Matrix.Output(Chessboard(m, n));
        }

        public static void Param19()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            Console.WriteLine(Norm1(matrix));
        }

        public static void Param20()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            Console.WriteLine(Norm2(matrix));
        }

        public static void Param21()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            for (int i = 0; i < 3; i++)
            {
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(sumRow(matrix, k));
            }
        }

        public static void Param22()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            for (int i = 0; i < 3; i++)
            {
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(sumCol(matrix, k));
            }
        }

        public static void Param23()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());
            SwapRow(matrix, k1, k2);
            Matrix.Output(matrix);
        }

        public static void Param24()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());
            SwapCol(matrix, k1, k2);
            Matrix.Output(matrix);
        }

        public static void Param25()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            Transp(ref matrix);
            Matrix.Output(matrix);
        }

        public static void Param26()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());
            RemoveRows(ref matrix, k1, k2);
            Console.WriteLine(matrix.Length);
            Matrix.Output(matrix);
        }

        public static void Param27()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());
            RemoveCols(ref matrix, k1, k2);
            Console.WriteLine(matrix.Length);
            Matrix.Output(matrix);
        }

        public static void Param28()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());
            RemoveRowCol(ref matrix, k1, k2);
            Console.WriteLine(matrix.Length);
            Matrix.Output(matrix);
        }

        public static void Param29()
        {
            double[,] matrix = Matrix.DoubleInput(int.Parse(Console.ReadLine()),
                                                  int.Parse(Console.ReadLine()));
            SortCols(matrix);
            Matrix.Output(matrix);
        }

        public static void Param30()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(IsIdent(Console.ReadLine()));
            }
        }

        public static void Param31()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(FillStr(Console.ReadLine(), n));
            }
        }

        public static void Param32()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(UpCaseRus(Console.ReadLine()));
            }
        }

        public static void Param33()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(LowerCaseRus(Console.ReadLine()));
            }
        }

        public static void Param34()
        {
            char c = Console.ReadLine()[0];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(TrimLeftC(Console.ReadLine(), c));
            }
        }

        public static void Param35()
        {
            char c = Console.ReadLine()[0];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(TrimRightC(Console.ReadLine(), c));
            }
        }

        public static void Param36()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(InvertStr(s, k, n));
            }
        }

        public static void Param37()
        {
            string s0 = Console.ReadLine();
            string s = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(PosSub(s0, s, k, n));
            }
        }

        public static void Param38()
        {
            for (int i = 0; i < 5; i++)
            {
                string s0 = Console.ReadLine();
                string s = Console.ReadLine();
                Console.WriteLine(PosLast(s0, s));
            }
        }

        public static void Param39()
        {
            for (int i = 0; i < 5; i++)
            {
                string s0 = Console.ReadLine();
                string s = Console.ReadLine();
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(PosK(s0, s, k));
            }
        }

        public static void Param40()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(WordK(s, k));
            }
        }

        public static void Param41()
        {
            string s = Console.ReadLine();
            string[] array = SplitStr(s);
            Console.WriteLine(array.Length);
            Array.Output(array);
        }

        public static void Param42()
        {
            for (int i = 0; i < 5; i++)
            {
                string k = Console.ReadLine();
                Console.WriteLine(CompressStr(k));
            }
        }

        public static void Param43()
        {
            for (int i = 0; i < 5; i++)
            {
                string k = Console.ReadLine();
                Console.WriteLine(DeCompressStr(k));
            }
        }

        public static void Param44()
        {
            for (int i = 0; i < 5; i++)
            {
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(DecToBin(k));
            }
        }

        public static void Param45()
        {
            for (int i = 0; i < 5; i++)
            {
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(DecToHex(k));
            }
        }

        public static void Param46()
        {
            for (int i = 0; i < 5; i++)
            {
                string k = Console.ReadLine();
                Console.WriteLine(BinToDec(k));
            }
        }

        public static void Param47()
        {
            for (int i = 0; i < 5; i++)
            {
                string k = Console.ReadLine();
                Console.WriteLine(HexToDec(k));
            }
        }

        public static void Param48()
        {
            for (int i = 0; i < 3; i++)
            {
                string k = Console.ReadLine();
                Console.WriteLine(IntFileSize(k));
            }
        }

        public static void Param49()
        {
            for (int i = 0; i < 3; i++)
            {
                string k = Console.ReadLine();
                Console.WriteLine(LineCount(k));
            }
        }

        public static void Param50()
        {
            for (int i = 0; i < 3; i++)
            {
                string k = Console.ReadLine();
                InvertIntFile(k);
            }
        }

        public static void Param51()
        {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            AddLineNumbers(s, n, k, l);
        }

        public static void Param52()
        {
            string s = Console.ReadLine();
            RemoveLineNumbers(s);
        }

        public static void Param53()
        {
            string s0 = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            SplitIntFile(s0, n, s1, s2);
        }

        public static void Param54()
        {
            string s0 = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            SplitText(s0, n, s1, s2);
        }

        public static void Param55()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            StringFileToText(s1);
            StringFileToText(s2);
        }

        public static void Param56()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            TextToStringFile(s1);
            TextToStringFile(s2);
        }

        public static void Param57()
        {
            int k = int.Parse(Console.ReadLine());
            string s1 = Console.ReadLine();
            EncodeText(s1, k);
        }

        public static void Param58()
        {
            int k = int.Parse(Console.ReadLine());
            string s1 = Console.ReadLine();
            DecodeText(s1, k);
        }

        public static void Param59()
        {
            IlyaDate d;
            for (int i = 0; i < 5; i++)
            {
                d.day = byte.Parse(Console.ReadLine());
                d.month = byte.Parse(Console.ReadLine());
                d.year = ushort.Parse(Console.ReadLine());
                Console.WriteLine(LeapYear(d));
            }
        }

        public static void Param60()
        {
            for (int i = 0; i < 5; i++)
            {
                IlyaDate d = new IlyaDate(
                    byte.Parse(Console.ReadLine()),
                    byte.Parse(Console.ReadLine()),
                    ushort.Parse(Console.ReadLine()));
                Console.WriteLine(DayInMonth(d));
            }
        }

        public static void Param61()
        {
            for (int i = 0; i < 5; i++)
            {
                IlyaDate d = new IlyaDate(
                    byte.Parse(Console.ReadLine()),
                    byte.Parse(Console.ReadLine()),
                    ushort.Parse(Console.ReadLine()));
                Console.WriteLine(CheckDate(d));
            }
        }

        public static void Param62()
        {
            for (int i = 0; i < 5; i++)
            {
                IlyaDate d = new IlyaDate(
                    byte.Parse(Console.ReadLine()),
                    byte.Parse(Console.ReadLine()),
                    ushort.Parse(Console.ReadLine()));
                Console.WriteLine(PrevDate(d));
            }
        }

        public static void Param63()
        {
            for (int i = 0; i < 5; i++)
            {
                IlyaDate d = new IlyaDate(
                    byte.Parse(Console.ReadLine()),
                    byte.Parse(Console.ReadLine()),
                    ushort.Parse(Console.ReadLine()));
                Console.WriteLine(NextDate(d));
            }
        }

        public static void Param64()
        {
            IlyaPoint a = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint b = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint c = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint d = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            Console.WriteLine(IlyaPoint.Lenght(a, b));
            Console.WriteLine(IlyaPoint.Lenght(a, c));
            Console.WriteLine(IlyaPoint.Lenght(a, d));
        }

        public static void Param65()
        {
            IlyaPoint a = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint b = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint c = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint d = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            Console.WriteLine(new IlyaTriangle(a, b, c).Perim());
            Console.WriteLine(new IlyaTriangle(a, b, d).Perim());
            Console.WriteLine(new IlyaTriangle(a, d, c).Perim());
        }

        public static void Param66()
        {
            IlyaPoint a = new IlyaPoint(
                 double.Parse(Console.ReadLine()),
                 double.Parse(Console.ReadLine()));
            IlyaPoint b = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint c = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint d = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            Console.WriteLine(new IlyaTriangle(a, b, c).Area());
            Console.WriteLine(new IlyaTriangle(a, b, d).Area());
            Console.WriteLine(new IlyaTriangle(a, d, c).Area());
        }

        public static void Param67()
        {
            IlyaPoint p = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint a = new IlyaPoint(
                 double.Parse(Console.ReadLine()),
                 double.Parse(Console.ReadLine()));
            IlyaPoint b = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint c = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            Console.WriteLine(p.Dist(a, b));
            Console.WriteLine(p.Dist(a, c));
            Console.WriteLine(p.Dist(c, b));
        }

        public static void Param68()
        {
            IlyaPoint a = new IlyaPoint(
                 double.Parse(Console.ReadLine()),
                 double.Parse(Console.ReadLine()));
            IlyaPoint b = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint c = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            IlyaPoint d = new IlyaPoint(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            double h1, h2, h3;
            new IlyaTriangle(a, b, c).Heights(out h1, out h2, out h3);
            Console.WriteLine($"{h1} {h2} {h3}");
            new IlyaTriangle(a, b, d).Heights(out h1, out h2, out h3);
            Console.WriteLine($"{h1} {h2} {h3}");
            new IlyaTriangle(a, d, c).Heights(out h1, out h2, out h3);
            Console.WriteLine($"{h1} {h2} {h3}");
        }

        public static void Param69()
        {
            for (int i = 0; i < 3; i++)
            {
                IlyaPoint[] points = new IlyaPoint[int.Parse(Console.ReadLine())];
                for (int j = 0; j < points.Length; j++)
                {
                    points[j] = new IlyaPoint(
                        double.Parse(Console.ReadLine()),
                        double.Parse(Console.ReadLine()));
                }
                Console.WriteLine(IlyaPoint.PerimN(points));
            }
        }

        public static void Param70()
        {
            for (int i = 0; i < 3; i++)
            {
                IlyaPoint[] points = new IlyaPoint[int.Parse(Console.ReadLine())];
                for (int j = 0; j < points.Length; j++)
                {
                    points[j] = new IlyaPoint(
                        double.Parse(Console.ReadLine()),
                        double.Parse(Console.ReadLine()));
                }
                Console.WriteLine(IlyaPoint.AreaN(points));
            }
        }
    }
}
