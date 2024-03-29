﻿using System.IO;
using System.Text;

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
                InsertInt(stream, 0, 0);
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
                stream.Seek((count - i) * 4, SeekOrigin.Begin);
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
                InsertInt(stream, i, reader.ReadInt32());
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
                    InsertInt(stream, i, value);
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
                InsertInt(stream, i, 0);
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
                    InsertInt(stream, i, 0);
                    InsertInt(stream, i, 0);
                    stream.Seek(8, SeekOrigin.Current);
                }
            }
            reader.Close();
            writer.Close();
            stream.Close();
        }
        public static void File42()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            File.Copy(s1, "newFile");
            File.Replace(s2, s1, null);
            File.Replace("newFile", s2, null);
            File.Delete("newFile");
        }
        public static void File43()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            File.Copy(s1, s2);
        }
        public static void File44()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileInfo info1 = new FileInfo(s1);
            FileInfo info2 = new FileInfo(s2);
            FileInfo info3 = new FileInfo(s3);
            if (info1.Length > info2.Length)
            {
                if (info1.Length > info3.Length)
                {
                    if (info2.Length > info3.Length)
                    {
                        File.Replace(s3, s1, null);
                    }
                    else
                    {
                        File.Replace(s2, s1, null);
                    }
                }
                else
                {
                    File.Replace(s2, s3, null);
                }
            }
            else if (info2.Length > info3.Length)
            {
                if (info1.Length > info3.Length)
                {
                    File.Replace(s3, s2, null);
                }
                else
                {
                    File.Replace(s1, s2, null);
                }
            }
            else
            {
                File.Replace(s1, s3, null);
            }
        }
        public static void File45()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileInfo info1 = new FileInfo(s1);
            FileInfo info2 = new FileInfo(s2);
            FileInfo info3 = new FileInfo(s3);
            if (info1.Length > info2.Length)
            {
                if (info1.Length > info3.Length)
                {
                    if (info2.Length > info3.Length)
                    {
                        File.Replace(s1, s3, null);
                    }
                    else
                    {
                        File.Replace(s1, s2, null);
                    }
                }
                else
                {
                    File.Replace(s3, s2, null);
                }
            }
            else if (info2.Length > info3.Length)
            {
                if (info1.Length > info3.Length)
                {
                    File.Replace(s2, s3, null);
                }
                else
                {
                    File.Replace(s2, s1, null);
                }
            }
            else
            {
                File.Replace(s3, s1, null);
            }
        }
        public static void File46()
        {
            string s0 = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            FileStream stream = new FileStream(s0, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < n; i++)
            {
                string sI = Console.ReadLine();
                FileStream streamI = new FileStream(sI, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(streamI);
                for (int j = 0; j < streamI.Length; j++)
                {
                    writer.Write(reader.ReadByte());
                }
                reader.Close();
                streamI.Close();
            }
            writer.Close();
            stream.Close();
        }
        public static void File47()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.ReadWrite);
            long count1 = stream1.Length;
            FileStream stream2 = new FileStream(s2, FileMode.Open, FileAccess.ReadWrite);
            long count2 = stream2.Length;
            BinaryWriter writer1 = new BinaryWriter(stream1);
            BinaryWriter writer2 = new BinaryWriter(stream2);
            BinaryReader reader1 = new BinaryReader(stream1);
            BinaryReader reader2 = new BinaryReader(stream2);
            stream1.Seek(0, SeekOrigin.End);
            for (int i = 0; i < count2; i++)
            {
                writer1.Write(reader2.ReadByte());
            }
            stream2.Seek(0, SeekOrigin.End);
            stream1.Seek(0, SeekOrigin.Begin);
            for (int i = 0; i < count1; i++)
            {
                writer2.Write(reader1.ReadByte());
            }
            writer1.Close();
            writer2.Close();
            reader1.Close();
            reader2.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void File48()
        {
            string sA = Console.ReadLine();
            string sB = Console.ReadLine();
            string sC = Console.ReadLine();
            string sD = Console.ReadLine();
            FileStream streamA = new FileStream(sA, FileMode.Open, FileAccess.Read);
            FileStream streamB = new FileStream(sB, FileMode.Open, FileAccess.Read);
            FileStream streamC = new FileStream(sC, FileMode.Open, FileAccess.Read);
            FileStream streamD = new FileStream(sD, FileMode.Create, FileAccess.Write);
            BinaryReader readerA = new BinaryReader(streamA);
            BinaryReader readerB = new BinaryReader(streamB);
            BinaryReader readerC = new BinaryReader(streamC);
            BinaryWriter writerD = new BinaryWriter(streamD);
            for (int i = 0; i < streamA.Length / 4; i++)
            {
                writerD.Write(readerA.ReadInt32());
                writerD.Write(readerB.ReadInt32());
                writerD.Write(readerC.ReadInt32());
            }
            readerA.Close();
            readerB.Close();
            readerC.Close();
            writerD.Close();
            streamA.Close();
            streamB.Close();
            streamC.Close();
            streamD.Close();
        }

        public static void File49()
        {
            BinaryReader[] array = new BinaryReader[4];
            long? min = null;
            for (int i = 0; i < array.Length; i++)
            {
                string s = Console.ReadLine();
                FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
                array[i] = new BinaryReader(stream);
                if (min == null || min > array[i].BaseStream.Length / 4)
                {
                    min = array[i].BaseStream.Length / 4;
                }
            }
            string sE = Console.ReadLine();
            FileStream streamE = new FileStream(sE, FileMode.Create, FileAccess.Write);
            BinaryWriter writerE = new BinaryWriter(streamE);
            for (int i = 0; i < min; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    writerE.Write(array[j].ReadInt32());
                }
            }
            writerE.Close();
            streamE.Close();
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Close();
                array[i].BaseStream.Close();
            }
        }
        public static void File50()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Open, FileAccess.Read);
            FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
            BinaryReader reader1 = new BinaryReader(stream1);
            BinaryReader reader2 = new BinaryReader(stream2);
            BinaryWriter writer = new BinaryWriter(stream3);
            int value1 = reader1.ReadInt32();
            int value2 = reader2.ReadInt32();
            for (int i = 0, j = 0; i < stream1.Length / 4 || j < stream2.Length / 4;)
            {
                if (i == stream1.Length / 4)
                {
                    writer.Write(value2);
                    j++;
                    if (j < stream2.Length / 4)
                    {
                        value2 = reader2.ReadInt32();
                    }
                    continue;
                }
                if (j == stream2.Length / 4)
                {
                    writer.Write(value1);
                    i++;
                    if (i < stream1.Length / 4)
                    {
                        value1 = reader1.ReadInt32();
                    }
                    continue;
                }
                if (value1 < value2)
                {
                    writer.Write(value1);
                    i++;
                    if (i < stream1.Length / 4)
                    {
                        value1 = reader1.ReadInt32();
                    }
                }
                else
                {
                    writer.Write(value2);
                    j++;
                    if (j < stream2.Length / 4)
                    {
                        value2 = reader2.ReadInt32();
                    }
                }
            }
            reader1.Close();
            reader2.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }
        public static void File51()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            string s4 = Console.ReadLine();
            Concat(s1, s2, "New_file");
            Concat(s3, "New_file", s4);
            File.Delete("New_file");
        }
        public static void File52()
        {
            string s0 = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            FileStream stream = new FileStream(s0, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(n);
            BinaryReader[] array = new BinaryReader[n];
            for (int i = 0; i < n; i++)
            {
                string sI = Console.ReadLine();
                FileStream streamI = new FileStream(sI, FileMode.Open, FileAccess.Read);
                writer.Write(streamI.Length);
                array[i] = new BinaryReader(streamI);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].BaseStream.Length; j++)
                {
                    writer.Write(array[i].ReadByte());
                }
                array[i].Close();
                array[i].BaseStream.Close();
            }
            writer.Close();
            stream.Close();
        }
        public static void File53()
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            string rar = Console.ReadLine();
            FileStream rarStream = new FileStream(rar, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(rarStream);
            int n = reader.ReadInt32();
            if (k > n)
            {
                Console.WriteLine("Такого файла не существует");
                reader.Close();
                rarStream.Close();
                return;
            }
            FileStream stream = new FileStream(s, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            long sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += reader.ReadInt64();
            }
            long lenght = reader.ReadInt64();
            stream.Seek(n * 8 + 4 + sum, SeekOrigin.Begin);
            for (int i = 0; i < lenght; i++)
            {
                writer.Write(reader.ReadByte());
            }
            writer.Close();
            reader.Close();
            stream.Close();
            rarStream.Close();
        }

        public static void File54()
        {
            string s = Console.ReadLine();
            string rar = Console.ReadLine();
            FileStream rarStream = new FileStream(rar, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(rarStream);
            FileStream stream = new FileStream(s, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            int n = reader.ReadInt32();
            long[] lenghts = new long[n];
            for (int i = 0; i < n; i++)
            {
                lenghts[i] = reader.ReadInt64();
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < lenghts[i]; j++)
                {
                    sum += reader.ReadByte();
                }
                writer.Write(sum / lenghts[i]);
            }
            writer.Close();
            reader.Close();
            stream.Close();
            rarStream.Close();
        }
        public static void File55()
        {
            string s0 = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            FileStream stream = new FileStream(s0, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(n);
            for (int i = 0; i < n; i++)
            {
                string sI = Console.ReadLine();
                FileStream streamI = new FileStream(sI, FileMode.Open, FileAccess.Read);
                BinaryReader readerI = new BinaryReader(streamI);
                writer.Write(streamI.Length);
                for (int j = 0; j < streamI.Length; j++)
                {
                    writer.Write(readerI.ReadByte());
                }
                readerI.Close();
                streamI.Close();
            }
            writer.Close();
            stream.Close();
        }
        public static void File56()
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            string rar = Console.ReadLine();
            FileStream rarStream = new FileStream(rar, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(rarStream);
            int n = reader.ReadInt32();
            if (k > n)
            {
                Console.WriteLine("Такого файла не существует");
                reader.Close();
                rarStream.Close();
                return;
            }
            FileStream stream = new FileStream(s, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = i = 0; i < k; i++)
            {
                long lenghtI = reader.ReadInt64();
                rarStream.Seek(lenghtI, SeekOrigin.Current);
            }
            long lenght = reader.ReadInt64();
            for (int i = 0; i < lenght; i++)
            {
                writer.Write(reader.ReadByte());
            }
            writer.Close();
            reader.Close();
            stream.Close();
            rarStream.Close();
        }

        public static void File57()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string rar = Console.ReadLine();
            FileStream rarStream = new FileStream(rar, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(rarStream);
            int n = reader.ReadInt32();
            FileStream stream1 = new FileStream(s1, FileMode.Create, FileAccess.Write);
            FileStream stream2 = new FileStream(s1, FileMode.Create, FileAccess.Write);
            BinaryWriter writer1 = new BinaryWriter(stream1);
            BinaryWriter writer2 = new BinaryWriter(stream2);
            for (int i = 0; i < n; i++)
            {
                long lenghtI = reader.ReadInt64();
                writer1.Write(reader.ReadByte());
                rarStream.Seek(lenghtI != 1 ? lenghtI - 2 : -1, SeekOrigin.Current);
                writer2.Write(reader.ReadByte());
            }
            writer1.Close();
            writer2.Close();
            reader.Close();
            stream1.Close();
            stream2.Close();
            rarStream.Close();
        }
        public static void File58()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            for (int i = 0; i < stream.Length / 2; i++)
            {
                if (reader.ReadChar() == ' ')
                {
                    stream.SetLength(i * 2);
                    break;
                }
            }
            reader.Close();
            stream.Close();
        }

        public static void File59()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            stream.Seek(-2, SeekOrigin.End);
            for (int i = 0; i < stream.Length / 2; i++)
            {
                char value = reader.ReadChar();
                if (value == ' ')
                {
                    stream.SetLength((stream.Length / 2 - i - 1) * 2);
                    break;
                }
                stream.Seek(-4, SeekOrigin.Current);
            }
            reader.Close();
            stream.Close();
        }
        public static void File60()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            for (int i = 0; i < stream.Length / 2; i++)
            {
                if (reader.ReadChar() == ' ')
                {
                    BinaryWriter writer = new BinaryWriter(stream);
                    for (int j = i + 1; j < stream.Length / 2; j++)
                    {
                        char c = reader.ReadChar();
                        stream.Seek((j - i - 1) * 2, SeekOrigin.Begin);
                        writer.Write(c);
                        stream.Seek((j + 1) * 2, SeekOrigin.Begin);
                    }
                    stream.SetLength((stream.Length / 2 - i - 1) * 2);
                    writer.Close();
                    break;
                }
            }
            reader.Close();
            stream.Close();
        }
        public static void File61()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            stream.Seek(-2, SeekOrigin.End);
            for (int i = 0; i < stream.Length / 2; i++)
            {
                if (reader.ReadChar() == ' ')
                {
                    BinaryWriter writer = new BinaryWriter(stream);
                    for (int j = i + 1; j < stream.Length / 2; j++)
                    {
                        char c = reader.ReadChar();
                        stream.Seek((j - i - 1) * 2, SeekOrigin.Begin);
                        writer.Write(c);
                        stream.Seek((j + 1) * 2, SeekOrigin.Begin);
                    }
                    stream.SetLength((stream.Length / 2 - i - 1) * 2);
                    writer.Close();
                    break;
                }
                stream.Seek(-4, SeekOrigin.Current);
            }
            reader.Close();
            stream.Close();
        }

        public static void File62()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < stream.Length / 2 - 1; i++)
            {
                char first = reader.ReadChar();
                (char, int) min = (first, 0);
                for (int j = i + 1; j < stream.Length / 2; j++)
                {
                    char c = reader.ReadChar();
                    if (min.Item1 > c)
                    {
                        min.Item1 = c;
                        min.Item2 = j;
                    }
                }
                stream.Seek(min.Item2 * 2, SeekOrigin.Begin);
                writer.Write(first);
                stream.Seek(i * 2, SeekOrigin.Begin);
                writer.Write(min.Item1);
            }
            reader.Close();
            writer.Close();
            stream.Close();
        }

        public static void File63()
        {
            int k = Convert.ToInt32(Console.ReadLine());// то что Байден прописал
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
            BinaryWriter writer1 = new BinaryWriter(stream2);
            BinaryWriter writer2 = new BinaryWriter(stream3);
            BinaryReader reader = new BinaryReader(stream1);
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                writer1.Write(k >= s.Length ? ' ' : s[k]);
                writer2.Write(k >= s.Length ? s : s.Remove(k + 1));
            }
            writer1.Close();
            writer2.Close();
            reader.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }

        public static void File64()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryWriter writer1 = new BinaryWriter(stream2);
            BinaryReader reader = new BinaryReader(stream1);
            int? min = null;
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                if (min == null || min > s.Length)
                {
                    min = s.Length;
                }
            }
            stream1.Seek(0, SeekOrigin.Begin);
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                if (s.Length == min)
                {
                    writer1.Write(s);
                }
            }
            writer1.Close();
            reader.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void File65()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            int? max = null;
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                if (max == null || max > s.Length)
                {
                    max = s.Length;
                }
            }
            stream1.Seek(0, SeekOrigin.Begin);
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                if (s.Length == max)
                {
                    byte[] array = Encoding.Unicode.GetBytes(s);
                    for (int i = 1; i <= array.Length; i++)
                    {
                        InsertByte(stream2, 0, array[^i]);
                    }
                }
            }
            reader.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void File66()
        {
            string s1 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream1);
            int count = 0;
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                count++;
            }
            stream1.Seek(0, SeekOrigin.Begin);
            for (int i = 0; i < count; i++)
            {
                string first = reader.ReadString();
                (string, int) min = (first, 0);
                for (int j = i + 1; j < count; j++)
                {
                    string c = reader.ReadString();
                    if (string.Compare(min.Item1, c) > 0)
                    {
                        min.Item1 = c;
                        min.Item2 = j;
                    }
                }
                FileStream stream = new FileStream("I - " + i, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter writer = new BinaryWriter(stream);
                stream1.Seek(0, SeekOrigin.Begin);
                for (int j = 0; j < count; j++)
                {
                    if (j == i)
                    {
                        writer.Write(min.Item1);
                        reader.ReadString();
                    }
                    else if (j == min.Item2)
                    {
                        writer.Write(first);
                        reader.ReadString();
                    }
                    else
                    {
                        writer.Write(reader.ReadString());
                    }
                }
                stream.Seek(0, SeekOrigin.Begin);
                stream1.Close();
                stream1 = stream;
                reader = new BinaryReader(stream1);
                for (int j = 0; j <= i; j++) reader.ReadString();
            }
            reader.Close();
            stream1.Close();
            File.Replace("I - " + (count - 1), s1, null);
            for (int i = 0; i < count - 2; i++)
            {
                File.Delete("I - " + i);
            }
        }
        public static void File67()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer1 = new BinaryWriter(stream2);
            BinaryWriter writer2 = new BinaryWriter(stream3);
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                string[] array = s.Split('/');
                writer1.Write(Convert.ToByte(array[0]));
                writer2.Write(Convert.ToByte(array[1]));
            }
            writer1.Close();
            writer2.Close();
            reader.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }

        public static void File68()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                string[] array = s.Split('/');
                InsertByte(stream2, 0, Convert.ToByte(array[1]));
                InsertInt(stream3, 0, Convert.ToInt16(array[2]));
            }
            reader.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }
        public static void File69()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            BinaryReader reader = new BinaryReader(stream1);
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                string[] array = s.Split('/');
                byte month = Convert.ToByte(array[1]);
                if (month >= 6 && month <= 8)
                {
                    writer.Write(s);
                }
            }
            writer.Close();
            reader.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void File70()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            BinaryReader reader = new BinaryReader(stream1);
            long[] positions = new long[0];
            while (true)
             {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                string[] array = s.Split('/');
                byte month = Convert.ToByte(array[1]);
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                       positions = Array.Insert(positions, 0, stream1.Position);
                        break;
                }
            }
            for (int i = 0; i < positions.Length; i++)
            {
                stream1.Seek(positions[i], SeekOrigin.Begin);
                writer.Write(reader.ReadString());
            }
            writer.Close();
            reader.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void File71()
        {
            string s1 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream1);
            string min = null;
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                string[] array = s.Split('/');
                byte month = Convert.ToByte(array[1]);
                if (month >= 3 && month <= 5)
                {
                    if (min == null || 
                        Convert.ToInt16(min.Split('/')[2]) > Convert.ToInt16(array[2]) ||
                        (Convert.ToInt16(min.Split('/')[2]) == Convert.ToInt16(array[2]) &&
                        Convert.ToByte(min.Split('/')[1]) > month) ||
                        (Convert.ToInt16(min.Split('/')[2]) == Convert.ToInt16(array[2]) &&
                        Convert.ToByte(min.Split('/')[1]) == month &&
                        Convert.ToByte(min.Split('/')[0]) > Convert.ToByte(array[0])))
                    {
                        min = s;
                    }
                }
            }
            reader.Close();
            stream1.Close();
            Console.WriteLine(min == null ? "" : min);
        }

        public static void File72()
        {
            string s1 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream1);
            string max = null;
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                string[] array = s.Split('/');
                byte month = Convert.ToByte(array[1]);
                if (month >= 9 && month <= 11)
                {
                    if (max == null ||
                        Convert.ToInt16(max.Split('/')[2]) < Convert.ToInt16(array[2]) ||
                        (Convert.ToInt16(max.Split('/')[2]) == Convert.ToInt16(array[2]) &&
                        Convert.ToByte(max.Split('/')[1]) < month) ||
                        (Convert.ToInt16(max.Split('/')[2]) == Convert.ToInt16(array[2]) &&
                        Convert.ToByte(max.Split('/')[1]) == month &&
                        Convert.ToByte(max.Split('/')[0]) < Convert.ToByte(array[0])))
                    {
                        max = s;
                    }
                }
            }
            reader.Close();
            stream1.Close();
            Console.WriteLine(max == null ? "" : max);
        }

        public static void File73()
        {
            string s1 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(stream1);
            int count = 0;
            while (true)
            {
                string s;
                try
                {
                    s = reader.ReadString();
                }
                catch (EndOfStreamException)
                {
                    break;
                }
                count++;
            }
            stream1.Seek(0, SeekOrigin.Begin);
            for (int i = 0; i < count; i++)
            {
                string first = reader.ReadString();
                (string, int) min = (first, 0);
                for (int j = i + 1; j < count; j++)
                {
                    string c = reader.ReadString();
                    if (Convert.ToInt16(min.Item1.Split('/')[2]) > Convert.ToInt16(c.Split('/')[2]) ||
                        (Convert.ToInt16(min.Item1.Split('/')[2]) == Convert.ToInt16(c.Split('/')[2]) &&
                        Convert.ToByte(min.Item1.Split('/')[1]) > Convert.ToByte(c.Split('/')[1])) ||
                        (Convert.ToInt16(min.Item1.Split('/')[2]) == Convert.ToInt16(c.Split('/')[2]) &&
                        Convert.ToByte(min.Item1.Split('/')[1]) == Convert.ToByte(c.Split('/')[1]) &&
                        Convert.ToByte(min.Item1.Split('/')[0]) > Convert.ToByte(c.Split('/')[0])))
                    {
                        min.Item1 = c;
                        min.Item2 = j;
                    }
                }
                FileStream stream = new FileStream("I - " + i, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter writer = new BinaryWriter(stream);
                stream1.Seek(0, SeekOrigin.Begin);
                for (int j = 0; j < count; j++)
                {
                    if (j == i)
                    {
                        writer.Write(min.Item1);
                        reader.ReadString();
                    }
                    else if (j == min.Item2)
                    {
                        writer.Write(first);
                        reader.ReadString();
                    }
                    else
                    {
                        writer.Write(reader.ReadString());
                    }
                }
                stream.Seek(0, SeekOrigin.Begin);
                stream1.Close();
                stream1 = stream;
                reader = new BinaryReader(stream1);
                for (int j = 0; j <= i; j++) reader.ReadString();
            }
            reader.Close();
            stream1.Close();
            File.Replace("I - " + (count - 1), s1, null);
            for (int i = 0; i < count - 2; i++)
            {
                File.Delete("I - " + i);
            }
        }

        public static void File74()
        {
            int i = Convert.ToInt32(Console.ReadLine()) - 1;
            int j = Convert.ToInt32(Console.ReadLine()) - 1;
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int n = (int)Math.Sqrt(stream.Length / 4);
            if (i < 0 || j < 0 || i >= n || j >= n)
            {
                Console.WriteLine(0);
            }
            else
            {
                stream.Seek((i * n + j) * 4, SeekOrigin.Begin);
                Console.WriteLine(reader.ReadInt32());
            }
            reader.Close();
            stream.Close();
        }
        public static void File75()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int n = (int)Math.Sqrt(stream1.Length / 4);
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    stream1.Seek((n * i + j) * 4, SeekOrigin.Begin);
                    writer.Write(reader.ReadInt32());
                }
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void File76()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            MatrixMul(s1, s2, s3);
        }

        public static void File77()
        {
            int i = Convert.ToInt32(Console.ReadLine()) - 1;
            int j = Convert.ToInt32(Console.ReadLine()) - 1;
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int countJ = reader.ReadInt32();
            int countI = (int)(stream.Length / 4  - 1) / countJ;
            if (i < 0 || j < 0 || i >= countI || j >= countJ)
            {
                Console.WriteLine(0);
            }
            else
            {
                stream.Seek((i * countJ + j) * 4, SeekOrigin.Begin);
                Console.WriteLine(reader.ReadInt32());
            }
            reader.Close();
            stream.Close();
        }
        public static void File78()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int countJ = reader.ReadInt32();
            int countI = (int)(stream1.Length / 4 - 1) / countJ;
            for (int j = 0; j < countJ; j++)
            {
                for (int i = 0; i < countI; i++)
                {
                    stream1.Seek((countJ * i + j) * 4, SeekOrigin.Begin);
                    writer.Write(reader.ReadInt32());
                }
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void File79()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Open, FileAccess.Read);
            BinaryReader reader1 = new BinaryReader(stream1);
            BinaryReader reader2 = new BinaryReader(stream2);
            int countJ1 = reader1.ReadInt32();
            int countI1 = (int)(stream1.Length / 4 - 1) / countJ1;
            int countJ2 = reader2.ReadInt32();
            int countI2 = (int)(stream2.Length / 4 - 1) / countJ2;
            if (countJ1 == countI2)
            {
                FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream3);
                for (int i = 0; i < countI1; i++)
                {
                    for (int j = 0; j < countJ2; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < countJ2; k++)
                        {
                            stream1.Seek((countJ1 * i + k) * 4, SeekOrigin.Begin);
                            stream2.Seek((countJ2 * k + j) * 4, SeekOrigin.Begin);
                            sum += reader1.ReadInt32() * reader2.ReadInt32();
                        }
                        writer.Write(sum);
                    }
                }
                writer.Close();
                stream3.Close();
            }
            reader1.Close();
            reader2.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void File80()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            SetUp(s1, s2);
        }
        public static void File81()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            SetDown(s1, s2);
        }

        public static void File82()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream1);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            int n = (int)Math.Sqrt(stream1.Length / 4);
            for (int i = 0; i < n; i++)
            {
                for (int j = i - 1; j <= i + 1; j++)
                {
                    if (j >= 0 && j < n)
                    {
                        stream1.Seek((i * n + j) * 4, SeekOrigin.Begin);
                        writer.Write(reader.ReadInt32());
                    }
                }
            }
            writer.Close();
            reader.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void File83()
        {
            int i = Convert.ToInt32(Console.ReadLine()) - 1;
            int j = Convert.ToInt32(Console.ReadLine()) - 1;
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int n = (int)(Math.Sqrt(stream.Length / 2 + 0.25) - 0.5);
            Console.WriteLine(n);
            if (i < 0 || j < 0 || i >= n || j >= n)
            {
                Console.WriteLine("элемент отсутствует"); 
            }
            else if (j < i)
            {
                Console.WriteLine(0);
            }
            else
            {
                stream.Seek((i * n + j - i) * 4, SeekOrigin.Begin);
                Console.WriteLine(reader.ReadInt32());
            }
            reader.Close();
            stream.Close();
        }

        public static void File84()
        {
            int i = Convert.ToInt32(Console.ReadLine()) - 1;
            int j = Convert.ToInt32(Console.ReadLine()) - 1;
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int n = (int)(Math.Sqrt(stream.Length / 2 + 0.25) - 0.5);
            Console.WriteLine(n);
            if (i < 0 || j < 0 || i >= n || j >= n)
            {
                Console.WriteLine("элемент отсутствует");
            }
            else if (j > i)
            {
                Console.WriteLine(0);
            }
            else
            {
                stream.Seek((i * n + j - (2 * n * i - i * i - i) / 2) * 4, SeekOrigin.Begin);
                Console.WriteLine(reader.ReadInt32());
            }
            reader.Close();
            stream.Close();
        }

        public static void File85()
        {
            int i = Convert.ToInt32(Console.ReadLine()) - 1;
            int j = Convert.ToInt32(Console.ReadLine()) - 1;
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            int n = (int)((stream.Length / 4 + 2) / 3);
            Console.WriteLine(n);
            if (i < 0 || j < 0 || i >= n || j >= n)
            {
                Console.WriteLine("элемент отсутствует");
            }
            else if (Math.Abs(j - i) > 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                stream.Seek(((i == 1 ? 2 : 3 * i) + j - i + 1) * 4, SeekOrigin.Begin);
                Console.WriteLine(reader.ReadInt32());
            }
            reader.Close();
            stream.Close();
        }

        public static void File86()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            GetUp(s1,  s2);
        }

        public static void File87()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            GetDown(s1, s2);
        }

        public static void File88()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            GetD(s1, s2);
        }
        public static void File89()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            GetUp(s1, "New_file89_1");
            GetUp(s2, "New_file89_2");
            MatrixMul("New_file89_1", "New_file89_2", "New_file89_3");
            SetUp("New_file89_3", s3);
            for (int i = 1; i <= 3; i++) File.Delete($"New_file89_{i}");
        }

        public static void File90()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            GetDown(s1, "New_file90_1");
            GetDown(s2, "New_file90_2");
            MatrixMul("New_file90_1", "New_file90_2", "New_file90_3");
            SetDown("New_file90_3", s3);
            for (int i = 1; i <= 3; i++) File.Delete($"New_file90_{i}");
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
        public static void InsertInt(FileStream stream, int k, int value)
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

        public static void InsertByte(FileStream stream, int k, byte value)
        {
            long position = stream.Position;
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            stream.Seek(k, SeekOrigin.Begin);
            for (; k < stream.Length; k++)
            {
                byte prev = reader.ReadByte();
                stream.Seek(-1, SeekOrigin.Current);
                writer.Write(value);
                value = prev;
            }
            writer.Write(value);
            stream.Position = position;
            writer.Close();
            reader.Close();
        }

        public static void Concat(string s1, string s2, string s3)
        {
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Open, FileAccess.Read);
            FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
            BinaryReader reader1 = new BinaryReader(stream1);
            BinaryReader reader2 = new BinaryReader(stream2);
            BinaryWriter writer = new BinaryWriter(stream3);
            int value1 = reader1.ReadInt32();
            int value2 = reader2.ReadInt32();
            for (int i = 0, j = 0; i < stream1.Length / 4 || j < stream2.Length / 4;)
            {
                if (i == stream1.Length / 4)
                {
                    writer.Write(value2);
                    j++;
                    if (j < stream2.Length / 4)
                    {
                        value2 = reader2.ReadInt32();
                    }
                    continue;
                }
                if (j == stream2.Length / 4)
                {
                    writer.Write(value1);
                    i++;
                    if (i < stream1.Length / 4)
                    {
                        value1 = reader1.ReadInt32();
                    }
                    continue;
                }
                if (value1 > value2)
                {
                    writer.Write(value1);
                    i++;
                    if (i < stream1.Length / 4)
                    {
                        value1 = reader1.ReadInt32();
                    }
                }
                else
                {
                    writer.Write(value2);
                    j++;
                    if (j < stream2.Length / 4)
                    {
                        value2 = reader2.ReadInt32();
                    }
                }
            }
            reader1.Close();
            reader2.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
            stream3.Close();
        }

        public static void GetUp(string s1, string s2)
        {
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int n = (int)(Math.Sqrt(stream1.Length / 2 + 0.25) - 0.5);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j < i)
                    {
                        writer.Write(0);
                    }
                    else
                    {
                        writer.Write(reader.ReadInt32());
                    }
                }
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void GetDown(string s1, string s2)
        {
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int n = (int)(Math.Sqrt(stream1.Length / 2 + 0.25) - 0.5);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j > i)
                    {
                        writer.Write(0);
                    }
                    else
                    {
                        writer.Write(reader.ReadInt32());
                    }
                }
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }
        public static void GetD(string s1, string s2)
        {
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryReader reader = new BinaryReader(stream1);
            BinaryWriter writer = new BinaryWriter(stream2);
            int n = (int)((stream1.Length / 4 + 2) / 3);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(j - i) > 1)
                    {
                        writer.Write(0);
                    }
                    else
                    {
                        writer.Write(reader.ReadInt32());
                    }
                }
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void MatrixMul(string s1, string s2, string s3)
        {
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream(s2, FileMode.Open, FileAccess.Read);
            if (stream1.Length == stream2.Length)
            {
                FileStream stream3 = new FileStream(s3, FileMode.Create, FileAccess.Write);
                BinaryReader reader1 = new BinaryReader(stream1);
                BinaryReader reader2 = new BinaryReader(stream2);
                BinaryWriter writer = new BinaryWriter(stream3);
                int n = (int)Math.Sqrt(stream1.Length / 4);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < n; k++)
                        {
                            stream1.Seek((n * i + k) * 4, SeekOrigin.Begin);
                            stream2.Seek((n * k + j) * 4, SeekOrigin.Begin);
                            sum += reader1.ReadInt32() * reader2.ReadInt32();
                        }
                        writer.Write(sum);
                    }
                }
                reader1.Close();
                reader2.Close();
                writer.Close();
                stream3.Close();
            }
            stream1.Close();
            stream2.Close();
        }

        public static void SetUp(string s1, string s2)
        {
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream1);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            int n = (int)Math.Sqrt(stream1.Length / 4);
            for (int i = 0; i < n; i++)
            {
                stream1.Seek((i * n + i) * 4, SeekOrigin.Begin);
                for (int j = i; j < n; j++)
                {
                    writer.Write(reader.ReadInt32());
                }
            }
            writer.Close();
            reader.Close();
            stream1.Close();
            stream2.Close();
        }

        public static void SetDown(string s1, string s2)
        {
            FileStream stream1 = new FileStream(s1, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream1);
            FileStream stream2 = new FileStream(s2, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            int n = (int)Math.Sqrt(stream1.Length / 4);
            for (int i = 0; i < n; i++)
            {
                stream1.Seek(i * n * 4, SeekOrigin.Begin);
                for (int j = 0; j <= i; j++)
                {
                    writer.Write(reader.ReadInt32());
                }
            }
            writer.Close();
            reader.Close();
            stream1.Close();
            stream2.Close();
        }
    }
}
