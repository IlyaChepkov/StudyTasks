using System.IO;

namespace IlyaCode
{
    internal class StudyFile
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("StudyFile");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            try
            {
                typeof(StudyFile).GetMethod("File" + taskNumber).Invoke(null, null);
            }
            catch { }
        }

        public static void File1()
        {
            string s = Console.ReadLine();
            try
            {
                File.Create(s);
                Console.WriteLine(true);
            }
            catch
            {
                Console.WriteLine(false);
            }
        }
        public static void File2()
        {
            string s = Console.ReadLine();
            byte n = Convert.ToByte(Console.ReadLine());
            FileStream stream = new FileStream(s, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 1; i < n + 1; i++)
            {
                writer.Write(2 * i);
            }
            writer.Close();
            stream.Close();
        }
        public static void File3()
        {
            string s = Console.ReadLine();
            double a = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            FileStream stream = new FileStream(s, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < 10; i++)
            {
                writer.Write(a + (d * i));
            }
            writer.Close();
            stream.Close();
        }
        public static void File4()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            string s4 = Console.ReadLine();
            int count = 0;
            if (File.Exists(s1)) count++;
            if (File.Exists(s2)) count++;
            if (File.Exists(s3)) count++;
            if (File.Exists(s4)) count++;
            Console.WriteLine(count);
        }
        public static void File5()
        {
            string s = Console.ReadLine();
            if (File.Exists(s))
            {
                FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
                Console.WriteLine(stream.Length / 4);
                stream.Close();
                return;
            }
            Console.WriteLine(-1);
        }
        public static void File6()
        {
            int k = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            Console.WriteLine(GetInt(stream, k));
            stream.Close();
        }
        public static void File7()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadInt32());
            for (int i = 2; i < stream.Length / 4 - 2; i++)
            {
                reader.ReadInt32();
            }
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadInt32());
            reader.Close();
            stream.Close();
        }
        public static void File8()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int last = reader.ReadInt32();
            writer.Write(last);
            for (int i = 1; i < stream1.Length / 4; i++)
            {
                last = reader.ReadInt32();
            }
            writer.Write(last);
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void File9()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            if (!File.Exists(s1))
            {
                Proc.Swap(ref s1, ref s2);
            }
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int first = reader.ReadInt32();
            int last = first;
            for (int i = 1; i < stream1.Length / 4; i++)
            {
                last = reader.ReadInt32();
            }
            writer.Write(last);
            writer.Write(first);
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void File10()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            for (int i = 1; i <= stream1.Length / 4; i++)
            {
                stream1.Seek(-i * 4, SeekOrigin.End);
                writer.Write(reader.ReadInt32());
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void File11()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
            BinaryReader reader1 = new BinaryReader(stream1);
            BinaryWriter writer2 = new BinaryWriter(stream2);
            BinaryWriter writer3 = new BinaryWriter(stream3);
            for (int i = 0; i < stream1.Length / 4; i++)
            {
                if (i % 2 == 0)
                {
                    writer2.Write(reader1.ReadInt32());
                }
                else
                {
                    writer3.Write(reader1.ReadInt32());
                }
            }
            reader1.Close();
            writer2.Close();
            writer3.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }

        public static void File12()
        {
                        string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
            BinaryReader reader1 = new BinaryReader(stream1);
            BinaryWriter writer2 = new BinaryWriter(stream2);
            BinaryWriter writer3 = new BinaryWriter(stream3);
            for (int i = 0; i < stream1.Length / 4; i++)
            {
                int value = reader1.ReadInt32();
                if (value % 2 == 0)
                {
                    writer2.Write(value);
                }
                else
                {
                    writer3.Write(value);
                }
            }
            reader1.Close();
            writer2.Close();
            writer3.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }


        public static void File13()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
            BinaryReader reader1 = new BinaryReader(stream1);
            BinaryWriter writer2 = new BinaryWriter(stream2);
            BinaryWriter writer3 = new BinaryWriter(stream3);
            for (int i = 1; i <= stream1.Length / 4; i++)
            {
                stream1.Seek(-i * 4, SeekOrigin.End);
                int value = reader1.ReadInt32();
                if (value > 0)
                {
                    writer2.Write(value);
                }
                else if (value < 0)
                {
                    writer3.Write(value);
                }
            }
            reader1.Close();
            writer2.Close();
            writer3.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }
        public static void File14()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int sum = 0;
            for (int i = 1; i <= stream.Length / 4; i++)
            {
                sum += reader.ReadInt32();
            }
            Console.WriteLine(sum / (stream.Length / 4));
            reader.Close();
            stream.Close();
        }
        public static void File15()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int sum = 0;
            for (int i = 1; i < stream.Length / 4; i += 2)
            {
                reader.ReadInt32();
                sum += reader.ReadInt32();
            }
            Console.WriteLine(sum);
            reader.Close();
            stream.Close();
        }
        public static void File16()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int count = 1;
            int value = reader.ReadInt32();
            for (int i = 1; i < stream.Length / 4; i++)
            {
                int element = reader.ReadInt32();
                if (value != element)
                {
                    value = element;
                    count++;
                }
            }
            Console.WriteLine(count);
            reader.Close();
            stream.Close();
        }
        public static void File17()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int lenght = 1;
            int value = reader.ReadInt32();
            for (int i = 1; i < stream1.Length / 4; i++)
            {
                int element = reader.ReadInt32();
                if (value != element)
                {
                    value = element;
                    writer.Write(lenght);
                    lenght = 1;
                }
                else
                {
                    lenght++;
                }
            }
            writer.Write(lenght);
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void File18()
        {
            string s1 = Console.ReadLine();
            FileStream stream = new FileStream(s1, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int prev = reader.ReadInt32();
            int current = reader.ReadInt32();
            for (int i = 2; i < stream.Length / 4; i++)
            {
                int next = reader.ReadInt32();
                if (prev > current && current < next)
                {
                    Console.WriteLine(current);
                    break;
                }
                prev = current;
                current = next;
            }
            reader.Close();
            stream.Close();
        }
        public static void File19()
        {
            string s1 = Console.ReadLine();
            FileStream stream = new FileStream(s1, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            stream.Seek(-4, SeekOrigin.End);
            int prev = reader.ReadInt32();
            stream.Seek(-8, SeekOrigin.End);
            int current = reader.ReadInt32();
            for (int i = 3; i <= stream.Length / 4; i++)
            {
                stream.Seek(-i * 4, SeekOrigin.End);
                int next = reader.ReadInt32();
                if (prev < current && current > next)
                {
                    Console.WriteLine(current);
                    break;
                }
                prev = current;
                current = next;
            }
            reader.Close();
            stream.Close();
        }
        public static void File20()
        {
            string s1 = Console.ReadLine();
            FileStream stream = new FileStream(s1, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int count = 0;
            int prev = reader.ReadInt32();
            int current = reader.ReadInt32();
            for (int i = 2; i < stream.Length / 4; i++)
            {
                int next = reader.ReadInt32();
                if ((prev < current && current > next)
                    || (prev > current && current < next))
                {
                    count++;
                }
                prev = current;
                current = next;
            }
            Console.WriteLine(count);
            reader.Close();
            stream.Close();
        }
        public static void File21()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int prev = reader.ReadInt32();
            int current = reader.ReadInt32();
            for (int i = 2; i < stream1.Length / 4; i++)
            {
                int next = reader.ReadInt32();
                if (prev < current && current > next)
                {
                    writer.Write(i);
                }
                prev = current;
                current = next;
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void File22()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            stream1.Seek(-4, SeekOrigin.End);
            int prev = reader.ReadInt32();
            stream1.Seek(-8, SeekOrigin.End);
            int current = reader.ReadInt32();
            for (int i = 3; i <= stream1.Length / 4; i++)
            {
                stream1.Seek(-i * 4, SeekOrigin.End);
                int next = reader.ReadInt32();
                if (prev > current && current < next)
                {
                    writer.Write(stream1.Length / 4 - i + 2);
                }
                prev = current;
                current = next;
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void File23()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int length = 0;
            int prev = reader.ReadInt32();
            for (int i = 1; i <= stream1.Length / 4; i++)
            {
                int current = reader.ReadInt32();
                if (prev > current)
                {
                    length += length == 0 ? 2 : 1;
                }
                else if (length != 0)
                {
                    writer.Write(length);
                    length = 0;
                }
                prev = current;
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void File24()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int length = 2;
            int prevPrev = reader.ReadInt32();
            int prev = reader.ReadInt32();
            for (int i = 2; i < stream1.Length / 4; i++)
            {
                int current = reader.ReadInt32();
                if ((prevPrev < prev == prev < current) &&
                    (prevPrev > prev == prev > current))
                {
                    length++;
                }
                else if (length != 2 || prevPrev != prev)
                {
                    writer.Write(length);
                    length = 2;
                }
                prevPrev = prev;
                prev = current;
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void File25()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < stream.Length / 4; i++)
            {
                int value = reader.ReadInt32();
                stream.Seek(-4, SeekOrigin.Current);
                writer.Write(value * value);
            }
            reader.Close();
            writer.Close();
            stream.Close();
        }

        public static void File26()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            (int, int) min = (0, reader.ReadInt32());
            (int, int) max = min;
            for (int i = 1; i < stream.Length / 4; i++)
            {
                int value = reader.ReadInt32();
                if (min.Item2 > value)
                {
                    min.Item2 = value;
                    min.Item1 = i;
                }
                if (max.Item2 < value)
                {
                    max.Item2 = value;
                    max.Item1 = i;
                }
            }
            stream.Seek(max.Item1 * 4, SeekOrigin.Begin);
            writer.Write(min.Item2);
            stream.Seek(min.Item1 * 4, SeekOrigin.Begin);
            writer.Write(max.Item2);
            reader.Close();
            writer.Close();
            stream.Close();
        }

        public static void File27()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            long count = stream.Length / 4;
            for (int i = 0; i < count; i++)
            {
                stream.Seek(i * 4, SeekOrigin.Begin);
                int value = reader.ReadInt32();
                stream.Seek(0, SeekOrigin.End);
                writer.Write(value);
            }
            for (int i = 1; i < count; i++)
            {
                stream.Seek(i % 2 == 1 ? -(i / 2 + 1) * 4 : 4 * ((i / 2) - count), SeekOrigin.End);
                int value = reader.ReadInt32();
                stream.Seek(i * 4, SeekOrigin.Begin);
                writer.Write(value);
            }
            stream.SetLength(count * 4);
            reader.Close();
            writer.Close();
            stream.Close();
        }
        public static void File28()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            int prev = reader.ReadInt32();
            int current = reader.ReadInt32();
            for (int i = 1; i < stream.Length / 4 - 1; i++)
            {
                int next = reader.ReadInt32();
                stream.Seek(i * 4, SeekOrigin.Begin);
                writer.Write((prev + current + next) / 3);
                stream.Seek(4, SeekOrigin.Current);
                prev = current;
                current = next;
            }
            reader.Close();
            writer.Close();
            stream.Close();
        }
        public static void File29()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Write);
            stream.SetLength(200);
            stream.Close();
        }
        public static void File30()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Write);
            stream.SetLength(stream.Length / 2);
            stream.Close();
        }

        public static void File31()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryWriter writer = new BinaryWriter(stream);
            BinaryReader reader = new BinaryReader(stream);
            for (int i = 0; i < 50; i++)
            {
                stream.Seek(-4 * (50 - i), SeekOrigin.End);
                int value = reader.ReadInt32();
                stream.Seek(i * 4, SeekOrigin.Begin);
                writer.Write(value);
            }
            stream.SetLength(200);
            writer.Close();
            reader.Close();
            stream.Close();
        }

        public static void File32()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryWriter writer = new BinaryWriter(stream);
            BinaryReader reader = new BinaryReader(stream);
            for (int i = 0; i < stream.Length / 8; i++)
            {
                stream.Seek(-4 * (stream.Length / 8 - i), SeekOrigin.End);
                int value = reader.ReadInt32();
                stream.Seek(i * 4, SeekOrigin.Begin);
                writer.Write(value);
            }
            stream.SetLength(stream.Length / 2);
            writer.Close();
            reader.Close();
            stream.Close();
        }
        public static void File33()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryWriter writer = new BinaryWriter(stream);
            BinaryReader reader = new BinaryReader(stream);
            for (int i = 1; i < stream.Length / 8 + stream.Length % 2; i++)
            {
                stream.Seek(i * 8, SeekOrigin.Begin);
                int value = reader.ReadInt32();
                stream.Seek(i * 4, SeekOrigin.Begin);
                writer.Write(value);
            }
            stream.SetLength(stream.Length / 2 + stream.Length % 2 * 4);
            writer.Close();
            reader.Close();
            stream.Close();
        }
        public static void File34()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryWriter writer = new BinaryWriter(stream);
            BinaryReader reader = new BinaryReader(stream);
            int j = 0;
            for (int i = 0; i < stream.Length / 4; i++)
            {
                stream.Seek(i * 4, SeekOrigin.Begin);
                int value = reader.ReadInt32();
                if (value >= 0)
                {
                    stream.Seek(j * 4, SeekOrigin.Begin);
                    writer.Write(value);
                    j++;
                }
            }
            stream.SetLength(j * 4);
            writer.Close();
            reader.Close();
            stream.Close();
        }
        public static void File35()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            while (stream.Length < 200)
            {
                Insert(stream, 0, 0);
            }
            stream.Close();
        }
        public static void File36()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            long count = stream.Length / 4;
            for (int i = 0; i < count; i++)
            {
                stream.Seek(i * 4, SeekOrigin.Begin);
                int value = reader.ReadInt32();
                stream.Seek(0, SeekOrigin.End);
                writer.Write(value);
            }
            reader.Close();
            writer.Close();
            stream.Close();
        }
        public static void File37()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            long count = stream.Length / 4;
            for (int i = 1; i <= count; i++)
            {
                stream.Seek((count - i)* 4, SeekOrigin.Begin);
                int value = reader.ReadInt32();
                stream.Seek(0, SeekOrigin.End);
                writer.Write(value);
            }
            reader.Close();
            writer.Close();
            stream.Close();
        }
        public static void File38()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            for (int i = 0; i < stream.Length / 4; i += 2)
            {
                Insert(stream, i, reader.ReadInt32());
                stream.Seek(8, SeekOrigin.Current);
            }
            reader.Close();
            stream.Close();
        }
        public static void File39()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            for (int i = 0; i < stream.Length / 4; i++)
            {
                int value = reader.ReadInt32();
                if (value <= 10 && value >= 5)
                {
                    Insert(stream, i, value);
                    stream.Seek(4, SeekOrigin.Current);
                }
            }
            reader.Close();
            stream.Close();
        }

        public static void File40()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 1; i < stream.Length / 4; i += 2)
            {
                writer.Write(0);
                Insert(stream, i, 0);
                stream.Seek(8, SeekOrigin.Current);
            }
            writer.Close();
            stream.Close();
        }
        public static void File41()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < stream.Length / 4; i++)
            {
                int value = reader.ReadInt32();
                if (value > 0)
                {
                    stream.Seek(-4, SeekOrigin.Current);
                    writer.Write(0);
                    Insert(stream, i, 0);
                    Insert(stream, i, 0);
                    stream.Seek(8, SeekOrigin.Current);
                }
            }
            reader.Close();
            writer.Close();
            stream.Close();
        }
        public static int GetInt(FileStream stream, int k)
        {
            long pos = stream.Position;
            int res = -1;
            if (stream.Length / 4 >= k)
            {
                stream.Seek(0, SeekOrigin.Begin);
                BinaryReader reader = new BinaryReader(stream);
                for (int i = 0; i < k - 1; i++)
                {
                    reader.ReadInt32();
                }
                res = reader.ReadInt32();
                stream.Position = pos;
                reader.Close();
            }
            return res;
        }
        public static void Insert(FileStream stream, int k, int value)
        {
            long position = stream.Position;
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            stream.Seek(k * 4, SeekOrigin.Begin);
            for (; k < stream.Length / 4; k++)
            {
                int prev = reader.ReadInt32();
                stream.Seek(-4, SeekOrigin.Current);
                writer.Write(value);
                value = prev;
            }
            writer.Write(value);
            stream.Position = position;
            writer.Close();
            reader.Close();
        }

    }
}
