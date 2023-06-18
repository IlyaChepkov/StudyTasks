using System.Security.Cryptography;

namespace IlyaCode
{
    internal partial class Param
    {
        public static int MinElem(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int MaxNum(double[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[max] < array[i])
                {
                    max = i;
                }
            }
            return max;
        }

        public static void MinmaxNum(double[] array, out int min, out int max)
        {
            min = 0;
            max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[max] < array[i])
                {
                    max = i;
                }
                if (array[min] > array[i])
                {
                    min = i;
                }
            }
        }

        public static void Invert<T>(T[] a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                Proc.Swap(ref a[i], ref a[^(i + 1)]);
            }
        }

        public static void Smooth1(double[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                double value = a[i];
                a[i] = sum / (i + 1);
                sum += value;
            }
        }

        public static void Smooth2(double[] a)
        {
            double prev = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                double current = a[i];
                a[i] = (a[i] + prev) / 2;
                prev = current;
            }
        }

        public static void Smooth3(double[] a)
        {
            double prev = a[0];
            a[0] = (a[0] + a[1]) / 2;
            for (int i = 1; i < a.Length - 1; i++)
            {
                double current = a[i];
                a[i] = (prev + a[i] + a[i + 1]) / 3;
                prev = current;
            }
            a[^1] = (prev + a[^1]) / 2;
        }

        public static void RemoveX(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    Array.RemoveAt(a, i);
                    i--;
                }
            }
        }

        public static void RemoveForInc(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] <= a[i - 1])
                {
                    Array.RemoveAt(a, i);
                    i--;
                }
            }
        }

        public static void DoubleX(int[] a, int x)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    Array.Insert(a, i, x);
                    i++;
                }
            }
        }

        public static void SortArray(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
                Proc.Swap(ref array[i], ref array[min]);
            }
        }

        public static int[] SortIndex(double[] array)
        {
            int[] output = new int[array.Length];
            for (int i = 1; i < array.Length; i++) output[i] = i;
            for (int i = 0; i < output.Length - 1; i++)
            {
                for (int j = 0; j < output.Length - i - 1; j++)
                {
                    if (array[output[j]] > array[output[j + 1]])
                    {
                        Proc.Swap(ref output[j], ref output[j + 1]);
                    }
                }
            }
            return output;
        }

        public static void Bell(double[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int min = i;
                int nextMin = i;
                for (int j = i + 1; j < array.Length - i; j++)
                {
                    if (array[min] > array[j])
                    {
                        nextMin = min;
                        min = j;
                    }
                    else if (array[j] < array[nextMin])
                    {
                        nextMin = j;
                    }
                }
                Proc.Swap(ref array[i], ref array[min]);
                Proc.Swap(ref array[^(i + 1)], ref array[nextMin]);
            }
        }

        public static void Split1(double[] array, out double[] odd, out double[] even)
        {
            odd = new double[array.Length / 2 + array.Length % 2];
            even = new double[array.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    odd[i / 2] = array[i];
                }
                else
                {
                    even[i / 2] = array[i];
                }
            }
        }

        public static void Split2(double[] array, out double[] odd, out double[] even)
        {
            odd = new double[0];
            even = new double[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    odd = Array.Insert(odd, odd.Length - 1, array[i]);
                }
                else
                {
                    even = Array.Insert(even, even.Length - 1, array[i]);
                }
            }
        }

        public static double[,] ArrayToMatrRow(double[] array, int m, int n)
        {
            double[,] matrix = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n && i * n + j < array.Length; j++)
                {
                    matrix[i, j] = array[i * n + j];
                }
            }
            return matrix;
        }

        public static double[,] ArrayToMatrCol(double[] array, int m, int n)
        {
            double[,] matrix = new double[m, n];
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m && j * m + i < array.Length; i++)
                {
                    matrix[i, j] = array[j * m + i];
                }
            }
            return matrix;
        }

        public static byte[,] Chessboard(int m, int n)
        {
            byte[,] matrix = new byte[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (byte)((j + i) % 2);
                }
            }
            return matrix;
        }

        public static double Norm1(double[,] matrix)
        {
            double? max = null;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += Math.Abs(matrix[i, j]);
                }
                if (max == null || max < sum)
                {
                    max = sum;
                }
            }
            return max.Value;
        }

        public static double Norm2(double[,] matrix)
        {
            double? max = null;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += Math.Abs(matrix[i, j]);
                }
                if (max == null || max < sum)
                {
                    max = sum;
                }
            }
            return max.Value;
        }

        public static double sumRow(double[,] matrix, int k)
        {
            double sum = 0;
            if (k >= 0 && k < matrix.GetLength(0))
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[k, j];
                }
            }
            return sum;
        }

        public static double sumCol(double[,] matrix, int k)
        {
            double sum = 0;
            if (k >= 0 && k < matrix.GetLength(1))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, k];
                }
            }
            return sum;
        }

        public static void SwapRow(double[,] matrix, int k1, int k2)
                    => Matrix.SwapRow(matrix, k1, k2);

        public static void SwapCol(double[,] matrix, int k1, int k2)
                    => Matrix.SwapCollumn(matrix, k1, k2);

        public static void Transp(ref double[,] matrix)
        {
            double[][] d = Matrix.GetMainD(matrix);
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    Proc.Swap(ref d[i][j], ref d[^(i + 1)][j]);
                }
            }
            matrix = Matrix.GetFromMainD(d);
        }

        public static void RemoveRows(ref double[,] matrix, int k1, int k2)
        {
            if (k1 >= matrix.GetLength(0)) return;
            if (k2 >= matrix.GetLength(0)) k2 = matrix.GetLength(0) - 1;
            for (int i = 0; i < k2 - k1 + 1; i++)
            {
                matrix = Matrix.RemoveRow(matrix, k1);
            }
        }

        public static void RemoveCols(ref double[,] matrix, int k1, int k2)
        {
            if (k1 >= matrix.GetLength(1)) return;
            if (k2 >= matrix.GetLength(1)) k2 = matrix.GetLength(1) - 1;
            for (int i = 0; i < k2 - k1 + 1; i++)
            {
                matrix = Matrix.RemoveCollumn(matrix, k1);
            }
        }

        public static void RemoveRowCol(ref double[,] matrix, int k, int l)
        {
            if (k >= matrix.GetLength(0)) return;
            if (l >= matrix.GetLength(1)) return;
            matrix = Matrix.RemoveRow(matrix, k);
            matrix = Matrix.RemoveCollumn(matrix, l);
        }

        public static void SortCols(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if (CompareCollumns(matrix, min, j))
                    {
                        min = j;
                    }
                }
                Matrix.SwapCollumn(matrix, min, i);
            }
        }

        public static int IsIdent(string s)
        {
            if (string.IsNullOrEmpty(s)) return -1;
            if (Char.IsDigit(s[0])) return -2;
            for (int i = 0; i < s.Length; i++)
            {
                if (!(Char.IsLetter(s[i]) || Char.IsDigit(s[i]) || s[i] == '_'))
                {
                    return i + 1;
                }
            }
            return 0;
        }

        public static string FillStr(string s, int n)
        {
            string res = "";
            while (res.Length + s.Length <= n) res += s;
            for (int i = 0; res.Length < n; i++) res += s[i];
            return res;
        }

        public static string UpCaseRus(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'а' && s[i] <= 'я')
                {
                    s = s.Replace(s[i], Char.ToUpper(s[i]));
                }
            }
            return s;
        }

        public static string LowerCaseRus(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'А' && s[i] <= 'Я')
                {
                    s = s.Replace(s[i], Char.ToLower(s[i]));
                }
            }
            return s;
        }

        public static string TrimLeftC(string s, char c) => s.TrimStart(c);

        public static string TrimRightC(string s, char c) => s.TrimEnd(c);

        public static string InvertStr(string s, int k, int n)
        {
            if (k >= s.Length) return "";
            if (s.Length <= k + n) n = s.Length - k;
            string res = "";
            for (int i = 0; i < n; i++)
            {
                res = s[k + i] + res;
            }
            return s.Remove(k) + res + s.Substring(k + n);
        }

        public static int PosSub(string s0, string s, int k, int n)
        {
            if (k >= s.Length) return -1;
            if (s.Length <= k + n) n = s.Length - k;
            return s.Substring(k, n).IndexOf(s0);
        }

        public static int PosLast(string s0, string s)
        {
            return s.LastIndexOf(s0);
        }

        public static int PosK(string s0, string s, int k)
        {
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                int index = s.IndexOf(s0);
                if (index == -1) return -1;
                s = s.Substring(index + 1);
                count += index + 1;
            }
            return s.IndexOf(s0) == -1 ? -1 : s.IndexOf(s0) + count;
        }

        public static string WordK(string s, int k)
        {
            while (s.IndexOf("  ") != -1) s = s.Replace("  ", " ");
            string[] array = s.Split(' ');
            return k >= array.Length ? "" : array[k];
        }

        public static string[] SplitStr(string s)
        {
            while (s.IndexOf("  ") != -1) s = s.Replace("  ", " ");
            string[] array = s.Split(' ');
            return array;
        }

        public static string CompressStr(string s)
        {
            int count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count > 4)
                    {
                        string bufer = s.Remove(i - count) + s[i - 1] + $"{{{count}}}";
                        s = bufer + s.Substring(i);
                        i = bufer.Length + 1;
                    }
                    count = 1;
                }
            }
            return s;
        }

        public static string DeCompressStr(string s)
        {
            string[] array = s.Split('{');
            s = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                string[] two = array[i].Split('}');
                int count = int.Parse(two[0]);
                for (int j = 0; j < count - 1; j++)
                {
                    s += s[^1];
                }
                s += two[1];
            }
            return s;
        }

        public static string DecToBin(int n)
        {
            string s = "";
            while (n >= 2)
            {
                s = n % 2 + s;
                n /= 2;
            }
            return n + s;
        }

        public static string DecToHex(int n)
        {
            string s = "";
            char[] digits = { '0', '1', '2', '3', '4', '5', '6',
                '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            while (n >= 16)
            {
                s = digits[n % 16] + s;
                n /= 16;
            }
            return digits[n] + s;
        }

        public static int BinToDec(string s)
        {
            int n = 0;
            for (int i = 0; i < s.Length; i++)
            {
                n += int.Parse(s[i].ToString()) * (int)Math.Pow(2, s.Length - i - 1);
            }
            return n;
        }

        public static int HexToDec(string s)
        {
            int n = 0;
            char[] digits = { '0', '1', '2', '3', '4', '5', '6',
                '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = 0; i < s.Length; i++)
            {
                n += System.Array.IndexOf(digits, s[i]) * (int)Math.Pow(16, s.Length - i - 1);
            }
            return n;
        }

        public static int IntFileSize(string s)
        {
            if (!File.Exists(s))
                return -1;
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            int count = (int)(stream.Length / 4);
            stream.Close();
            return count;
        }

        public static int LineCount(string s)
        {
            if (!File.Exists(s))
                return -1;
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int count = 0;
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                count++;
            }
            reader.Close();
            stream.Close();
            return count;
        }

        public static void InvertIntFile(string s)
        {
            if (!File.Exists(s))
                return;
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < stream.Length / 8; i++)
            {
                stream.Seek(i * 4, SeekOrigin.Begin);
                int value1 = reader.ReadInt32();
                stream.Seek(-(i + 1) * 4, SeekOrigin.End);
                int value2 = reader.ReadInt32();
                stream.Seek(i * 4, SeekOrigin.Begin);
                writer.Write(value2);
                stream.Seek(-(i + 1) * 4, SeekOrigin.End);
                writer.Write(value1);
            }
            reader.Close();
            writer.Close();
            stream.Close();
        }

        public static void AddLineNumbers(string s, int n, int k, int l)
        {
            if (!File.Exists(s))
                return;
            FileStream stream1 = new FileStream(s, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream("51.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            while (!reader.EndOfStream)
            {
                string res = n.ToString();
                while (res.Length < k) res = ' ' + res;
                string value = reader.ReadLine();
                if (!string.IsNullOrEmpty(value))
                {
                    while (res.Length < k + l) res += ' ';
                    res += value;
                }
                writer.WriteLine(res);
                n++;
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
            File.Delete(s);
            File.Move("51.txt", s);
        }

        public static void RemoveLineNumbers(string s)
        {
            if (!File.Exists(s))
                return;
            FileStream stream1 = new FileStream(s, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream("52.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            while (!reader.EndOfStream)
            {
                string input = reader.ReadLine();
                string value = input.TrimStart(' ');
                string[] array = s.Split(' ');
                int result;
                if (int.TryParse(array[0], out result))
                {
                    value = value.Substring(array[0].Length);
                    value = value.TrimStart(' ');
                }
                else
                {
                    value = input;
                }
                writer.WriteLine(value);
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
            File.Delete(s);
            File.Move("52.txt", s);
        }

        public static void SplitIntFile(string s0, int k, string s1, string s2)
        {
            if (!File.Exists(s0))
                return;
            FileStream stream1 = new FileStream(s0, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream1);
            FileStream stream2 = new FileStream(s1, FileMode.Create, FileAccess.Write);
            BinaryWriter writer1 = new BinaryWriter(stream2);
            FileStream stream3 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryWriter writer2 = new BinaryWriter(stream3);
            for (int i = 0; i < k && i < stream1.Length / 4; i++)
            {
                int value = reader.ReadInt32();
                writer1.Write(value);
            }
            for (int i = k; i < stream1.Length / 4; i++)
            {
                int value = reader.ReadInt32();
                writer2.Write(value);
            }
            reader.Close();
            writer1.Close();
            writer2.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }

        public static void SplitText(string s0, int k, string s1, string s2)
        {
            if (!File.Exists(s0))
                return;
            FileStream stream1 = new FileStream(s0, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream(s1, FileMode.Create, FileAccess.Write);
            StreamWriter writer1 = new StreamWriter(stream2);
            FileStream stream3 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            StreamWriter writer2 = new StreamWriter(stream3);
            for (int i = 0; i < k && !reader.EndOfStream; i++)
            {
                string value = reader.ReadLine();
                writer1.WriteLine(value);
            }
            while (!reader.EndOfStream)
            {
                string value = reader.ReadLine();
                writer2.WriteLine(value);
            }
            reader.Close();
            writer1.Close();
            writer2.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }

        public static void StringFileToText(string s)
        {
            if (!File.Exists(s))
                return;
            FileStream stream1 = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream1);
            FileStream stream2 = new FileStream(s + ".txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer1 = new StreamWriter(stream2);
            for (long i = 0; i < stream1.Length; i = stream1.Position)
            {
                string value = reader.ReadString();
                writer1.WriteLine(value);
            }
            reader.Close();
            writer1.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void TextToStringFile(string s)
        {
            if (!File.Exists(s))
                return;
            FileStream stream1 = new FileStream(s, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream(s + ".bin", FileMode.Create, FileAccess.Write);
            BinaryWriter writer1 = new BinaryWriter(stream2);
            while (!reader.EndOfStream)
            {
                string value = reader.ReadLine();
                writer1.Write(value);
            }
            reader.Close();
            writer1.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void EncodeText(string s, int k)
        {
            if (!File.Exists(s))
                return;
            FileStream stream1 = new FileStream(s, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream("57.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            while (!reader.EndOfStream)
            {
                string value = reader.ReadLine();
                string res = "";
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.ToLower(value[i]) >= 'а' && Char.ToLower(value[i]) <= 'я')
                    {
                        if (Char.ToLower(value[i]) + k > 'я')
                        {
                            res += (char)(value[i] + k - ('я' - 'а' + 1));
                        }
                        else
                        {
                            res += (char)(value[i] + k);
                        }
                    }
                    else
                    {
                        res += value[i];
                    }
                }
                writer.WriteLine(res);
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
            File.Delete(s);
            File.Move("57.txt", s);
        }

        public static void DecodeText(string s, int k)
        {
            if (!File.Exists(s))
                return;
            FileStream stream1 = new FileStream(s, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream("58.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            while (!reader.EndOfStream)
            {
                string value = reader.ReadLine();
                string res = "";
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.ToLower(value[i]) >= 'а' && Char.ToLower(value[i]) <= 'я')
                    {
                        if (Char.ToLower(value[i]) - k > 'а')
                        {
                            res += (char)(value[i] - k + ('я' - 'а' + 1));
                        }
                        else
                        {
                            res += (char)(value[i] - k);
                        }
                    }
                    else
                    {
                        res += value[i];
                    }
                }
                writer.WriteLine(res);
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
            File.Delete(s);
            File.Move("58.txt", s);
        }

        public static bool LeapYear(IlyaDate d)
            => (d.year % 4 == 0 && d.year % 100 != 0) || d.year % 400 == 0;

        public static byte DayInMonth(IlyaDate d)
        {
            switch (d.month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return (byte)(LeapYear(d) ? 29 : 28);
            }
        }

        public static int CheckDate(IlyaDate d)
        {
            if (d.year == 0) return 3;
            if (d.month > 12 || d.month == 0) return 1;
            if (d.day > DayInMonth(d) || d.day == 0) return 2;
            return 0;
        }

        public static IlyaDate PrevDate(IlyaDate d)
        {
            if (CheckDate(d) != 0) return d;
            if (d.day != 1) d.day = (byte)(d.day - 1);
            else if (d.month != 1)
            {
                d.month--;
                d.day = DayInMonth(d);
            }
            else
            {
                d.year--;
                d.month = 12;
                d.day = DayInMonth(d);
            }
            return d;
        }

        public static IlyaDate NextDate(IlyaDate d)
        {
            if (CheckDate(d) != 0) return d;
            if (d.day != DayInMonth(d)) d.day++;
            else if (d.month != 12)
            {
                d.month++;
                d.day = 1;
            }
            else
            {
                d.year++;
                d.month = 1;
                d.day = 1;
            }
            return d;
        }

        public static bool CompareCollumns(double[,] matrix, int index1, int index2)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, index1] != matrix[i, index2])
                {
                    return matrix[i, index1] > matrix[i, index2];
                }
            }
            return false;
        }

    }

    public struct IlyaDate
    {
        public byte day;
        public byte month;
        public ushort year;
        public IlyaDate(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }

    public struct IlyaPoint
    {
        public double x;
        public double y;
        public IlyaPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static double Lenght(IlyaPoint a, IlyaPoint b) =>
            Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        public double Dist(IlyaPoint a, IlyaPoint b)
        {
            IlyaTriangle pab = new IlyaTriangle(this, a, b);
            return 2 * pab.Area() / Lenght(a, b);
        }
        public static double PerimN(params IlyaPoint[] points)
        {
            double p = 0;
            for (int i = 1; i < points.Length; i++)
            {
                p += Lenght(points[i - 1], points[i]);
            }
            p += Lenght(points[0], points[^1]);
            return p;
        }

        public static double AreaN(params IlyaPoint[] points)
        {
            if (points.Length == 3)
            {
                return new IlyaTriangle(points[0], points[1], points[2]).Area();
            }
            double s = 0;
            for (int i = 2; i < points.Length; i++)
            {
                s += new IlyaTriangle(points[0], points[i - 1], points[i]).Area();
            }
            return s;
        }
    }

    public struct IlyaTriangle
    {
        public IlyaPoint a;
        public IlyaPoint b;
        public IlyaPoint c;
        public IlyaTriangle(IlyaPoint a, IlyaPoint b, IlyaPoint c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Perim() =>
            IlyaPoint.Lenght(a, b) + IlyaPoint.Lenght(c, b) + IlyaPoint.Lenght(a, c);
        public double Area()
        {
            double p = Perim() / 2;
            return Math.Sqrt(p 
                * (p - IlyaPoint.Lenght(a, b))
                * (p - IlyaPoint.Lenght(a, c))
                * (p - IlyaPoint.Lenght(c, b)));
        }
        public void Heights(out double h1, out double h2, out double h3)
        {
            h1 = a.Dist(b, c);
            h2 = b.Dist(a, c);
            h3 = c.Dist(a, b);
        }
    }
}
