using System.Reflection.PortableExecutable;

namespace IlyaCode
{
    internal class Text
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("Text");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            try
            {
                typeof(Text).GetMethod("Text" + taskNumber).Invoke(null, null);
            }
            catch { }
        }

        public static void Text1()
        {
            string s = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            FileStream stream = new FileStream(s, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            string value = "";
            for (int i = 0; i < k; i++)
            {
                value += '*';
            }
            for (int i = 0; i < n; i++)
            {
                writer.WriteLine(value);
            }
            writer.Close();
            stream.Close();
        }

        public static void Text2()
        {
            string s = Console.ReadLine();
            byte n = Convert.ToByte(Console.ReadLine());
            FileStream stream = new FileStream(s, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            string value = "";
            for (int i = 0; i < n; i++)
            {
                value += (char)('a' + i);
                writer.WriteLine(value);
            }
            writer.Close();
            stream.Close();
        }

        public static void Text3()
        {
            string s = Console.ReadLine();
            byte n = Convert.ToByte(Console.ReadLine());
            FileStream stream = new FileStream(s, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            for (int i = 0; i < n; i++)
            {
                string value = "";
                for (int j = 0; j < i + 1; j++)
                {
                    value += (char)('A' + j);
                }
                for (int j = i + 1; j < n; j++)
                {
                    value += '*';
                }
                writer.WriteLine(value);
            }
            writer.Close();
            stream.Close();
        }

        public static void Text4()
        {
            string s = Console.ReadLine();
            FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int sum = 0;
            int count = 0;
            while (!reader.EndOfStream)
            {
                sum += reader.ReadLine().Length;
                count++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
            reader.Close();
            stream.Close();
        }

        public static void Text5()
        {
            string s = Console.ReadLine();
            string fileName = Console.ReadLine();
            File.AppendAllText(fileName, s);
        }

        public static void Text6()
        {
            string fileName1 = Console.ReadLine();
            string fileName2 = Console.ReadLine();
            FileStream stream = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (!reader.EndOfStream)
            {
                File.AppendAllText(fileName1, reader.ReadLine() + '\n');
            }
            reader.Close();
            stream.Close();
        }

        public static void Text7()
        {
            string s = Console.ReadLine();
            string fileName = Console.ReadLine();
            Insert(fileName, s, 0);
        }

        public static void Text8()
        {
            string fileName1 = Console.ReadLine();
            string fileName2 = Console.ReadLine();
            InsertRange(fileName1, fileName2, 0);
        }

        public static void Text9()
        {
            string fileName1 = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            try
            {
                Insert(fileName1, "", k);
            }
            catch { }
        }

        public static void Text10()
        {
            string fileName1 = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            try
            {
                Insert(fileName1, "", k);
            }
            catch { }
        }

        public static void Text11()
        {
            string fileName = Console.ReadLine();
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int count = 0;
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                if (s == "")
                {
                    reader.Close();
                    stream.Close();
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream);
                    Insert(reader, "", count);
                    reader.Close();
                    stream.Close();
                    File.Delete(fileName);
                    File.Move("textInsert", fileName);
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
                    reader = new StreamReader(stream);
                    for(int i = 0; i <= count + 1; i++) reader.ReadLine();
                }
                count++;
            }
            reader.Close();
            stream.Close();
        }

        public static void Text12()
        {
            string input = Console.ReadLine();
            string fileName = Console.ReadLine();
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int count = 0;
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                if (s == "")
                {
                    reader.Close();
                    stream.Close();
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream);
                    ReplaceAt(reader, input, count);
                    reader.Close();
                    stream.Close();
                    File.Delete(fileName);
                    File.Move("textReplace", fileName);
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
                    reader = new StreamReader(stream);
                    for (int i = 0; i <= count; i++) reader.ReadLine();
                }
                count++;
            }
            reader.Close();
            stream.Close();
        }

        public static void Text13()
        {
            string fileName = Console.ReadLine();
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            RemoveAt(reader, 0);
            reader.Close();
            stream.Close();
            File.Delete(fileName);
            File.Move("textRemove", fileName);
        }

        public static void Text14()
        {
            string fileName = Console.ReadLine();
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int count = 0;
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                count++;
            }
            reader.Close();
            stream.Close();
            stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);
            RemoveAt(reader, count - 1);
            reader.Close();
            stream.Close();
            File.Delete(fileName);
            File.Move("textRemove", fileName);
        }

        public static void Text15()
        {
            int k = Convert.ToInt32(Console.ReadLine());
            string fileName = Console.ReadLine();
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            reader.Close();
            stream.Close();
            stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);
            try
            {
                RemoveAt(reader, k);
                reader.Close();
                stream.Close();
                File.Delete(fileName);
                File.Move("textRemove", fileName);
            }
            catch
            {
                Console.WriteLine("элемент не найден");
                reader.Close();
                stream.Close();
            }
        }

        public static void Text16()
        {
            string fileName = Console.ReadLine();
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int count = 0;
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                if (s == "")
                {
                    reader.Close();
                    stream.Close();
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream);
                    RemoveAt(reader, count);
                    reader.Close();
                    stream.Close();
                    File.Delete(fileName);
                    File.Move("textRemove", fileName);
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
                    reader = new StreamReader(stream);
                    count--;
                    for (int i = 0; i <= count; i++) reader.ReadLine();
                }
                count++;
            }
            reader.Close();
            stream.Close();
        }

        public static void Text17()
        {
            string fileName1 = Console.ReadLine();
            string fileName2 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);
            FileStream stream3 = new FileStream("text17_1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream3);
            while (!reader1.EndOfStream && !reader2.EndOfStream)
            {
                string s1 = reader1.ReadLine();
                string s2 = reader2.ReadLine();
                s1 += s2;
                writer.WriteLine(s1);
            }
            while (!reader1.EndOfStream)
            {
                writer.WriteLine(reader1.ReadLine());
            }
            while (!reader2.EndOfStream)
            {
                writer.WriteLine(reader2.ReadLine());
            }

            reader1.Close();
            stream1.Close();
            reader2.Close();
            stream2.Close();
            writer.Close();
            stream3.Close();
            File.Delete(fileName1);
            File.Move("text17_1.txt", fileName1);
        }

        public static void Text18()
        {
            int k = int.Parse(Console.ReadLine());
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream("text18_1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            while (!reader1.EndOfStream)
            {
                string s1 = reader1.ReadLine();
                writer.WriteLine(s1.Substring(k));
            }
            reader1.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
            File.Delete(fileName1);
            File.Move("text18_1.txt", fileName1);
        }

        public static void Text19()
        {
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream("text19_1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            while (!reader1.EndOfStream)
            {
                string s1 = reader1.ReadLine();
                string result = "";
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] >= 'а' && s1[i] <= 'я')
                    {
                        result += Char.ToUpper(s1[i]);
                    }
                    else if (s1[i] >= 'А' && s1[i] <= 'Я')
                    {
                        result += Char.ToLower(s1[i]);
                    }
                    else
                    {
                        result += s1[i];
                    }
                }
                writer.WriteLine(result);
            }
            reader1.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
            File.Delete(fileName1);
            File.Move("text19_1.txt", fileName1);
        }

        public static void Text20()
        {
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream("text20_1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            while (!reader1.EndOfStream)
            {
                string s1 = reader1.ReadLine();
                while (s1.IndexOf("  ") != -1) s1 = s1.Replace("  ", " ");
                writer.WriteLine(s1);
            }
            reader1.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
            File.Delete(fileName1);
            File.Move("text20_1.txt", fileName1);
        }

        public static void Text21()
        {
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            int count = 0;
            while (!reader1.EndOfStream)
            {
                count++;
            }
            reader1.Close();
            stream1.Close();
            for (int i = 0; i < 3; i++)
            {
                stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
                reader1 = new StreamReader(stream1);
                RemoveAt(reader1, count - 3);
                reader1.Close();
                stream1.Close();
                File.Delete(fileName1);
                File.Move("textRemove", fileName1);
            }
        }

        public static void Text22()
        {
            int k = int.Parse(Console.ReadLine());
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            int count = 0;
            while (!reader1.EndOfStream)
            {
                count++;
            }
            reader1.Close();
            stream1.Close();
            for (int i = 0; i < k; i++)
            {
                stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
                reader1 = new StreamReader(stream1);
                RemoveAt(reader1, count - k);
                reader1.Close();
                stream1.Close();
                File.Delete(fileName1);
                File.Move("textRemove", fileName1);
            }
        }

        public static void Insert(string fileName, string s, int position)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            try
            {
                Insert(reader, s, position);
            }
            catch
            {
                File.Delete("textInsert");
                reader.Close();
                stream.Close();
                throw new Exception("такого места в файле нет");
            }
            reader.Close();
            stream.Close();
            File.Delete(fileName);
            File.Move("textInsert", fileName);
        }

        public static void Insert(StreamReader reader, string s, int position)
        {
            for (int i = 0; i < position; i++)
            {
                File.AppendAllText("textInsert", reader.ReadLine() + '\n');
            }
            File.AppendAllText("textInsert", s + "\n");
            while (!reader.EndOfStream)
            {
                File.AppendAllText("textInsert", reader.ReadLine() + '\n');
            }
        }

        public static void InsertRange(string fileName1, string fileName2, int position)
        {
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);
            try
            {
                InsertRange(reader1, reader2, position);
            }
            catch
            {
                File.Delete("textInsertRange");
                reader1.Close();
                stream1.Close();
                reader2.Close();
                stream2.Close();
                throw new Exception("такого места в файле нет");
            }
            reader1.Close();
            stream1.Close();
            reader2.Close();
            stream2.Close();
            File.Delete(fileName1);
            File.Move("textInsertRange", fileName1);
        }

        public static void InsertRange(StreamReader reader1, StreamReader reader2, int position)
        {
            for (int i = 0; i < position; i++)
            {

                File.AppendAllText("textInsertRange", reader1.ReadLine() + '\n');
            }
            while (!reader2.EndOfStream)
            {
                File.AppendAllText("textInsertRange", reader2.ReadLine() + '\n');
            }
            while (!reader1.EndOfStream)
            {
                File.AppendAllText("textInsertRange", reader1.ReadLine() + '\n');
            }
        }

        public static void ReplaceAt(StreamReader reader, string s, int position)
        {
            for (int i = 0; i < position; i++)
            {
                File.AppendAllText("textReplace", reader.ReadLine() + '\n');
            }
            File.AppendAllText("textReplace", s + "\n");
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                File.AppendAllText("textReplace", reader.ReadLine() + '\n');
            }
        }

        public static void RemoveAt(StreamReader reader, int position)
        {
            for (int i = 0; i < position; i++)
            {
                File.AppendAllText("textRemove", reader.ReadLine() + '\n');
            }
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                File.AppendAllText("textRemove", reader.ReadLine() + '\n');
            }
        }
    }
}
