﻿namespace IlyaCode
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
                    for (int i = 0; i <= count + 1; i++) reader.ReadLine();
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

        public static void Text23()
        {
            int k = int.Parse(Console.ReadLine());
            string fileName1 = Console.ReadLine();
            string fileName2 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream(fileName2, FileMode.Create, FileAccess.Write);
            StreamWriter reader2 = new StreamWriter(stream2);
            int count = 0;
            while (!reader1.EndOfStream)
            {
                count++;
            }
            reader1.Close();
            stream1.Close();
            stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            reader1 = new StreamReader(stream1);
            for (int i = 0; i < count - k; i++)
            {
                reader1.ReadLine();
            }
            while (!reader1.EndOfStream)
            {
                reader2.Write(reader1.ReadLine());
            }
            reader1.Close();
            stream1.Close();
            reader2.Close();
            stream2.Close();
        }

        public static void Text24()
        {
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            bool mode = true;
            int count = 0;
            while (!reader1.EndOfStream)
            {
                string s = reader1.ReadLine();
                if (s != "" && mode)
                {
                    count++;
                    mode = false;
                }
                else if (s == "")
                {
                    mode = true;
                }
            }
            reader1.Close();
            stream1.Close();
            Console.WriteLine(count);
        }

        public static void Text25()
        {
            int k = int.Parse(Console.ReadLine());
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream("textfile25_1", FileMode.Create, FileAccess.Write);
            StreamWriter reader2 = new StreamWriter(stream2);
            bool mode = true;
            int count = 0;
            while (!reader1.EndOfStream)
            {
                string s = reader1.ReadLine();
                if (s != "" && mode)
                {
                    count++;
                    mode = false;
                }
                else if (s == "")
                {
                    mode = true;
                }
                if (count != k || s == "")                          //'_'
                {                                                   //+-+
                    reader2.WriteLine(s);                           //=_= 
                }                                                   //-_-
            }                                                       //*_*
            reader1.Close();                                        //"_"
            stream1.Close();
            reader2.Close();
            stream2.Close();
            File.Delete(fileName1);
            File.Move("textfile25_1", fileName1);
        }
        public static void Text26()
        {
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            int count = 0;
            while (!reader1.EndOfStream)
            {
                string s = reader1.ReadLine();
                if (s.StartsWith("     "))
                {
                    count++;
                }
            }
            reader1.Close();
            stream1.Close();
            Console.WriteLine(count);
        }

        public static void Text27()
        {
            int k = int.Parse(Console.ReadLine());
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream("textfile25_1", FileMode.Create, FileAccess.Write);
            StreamWriter reader2 = new StreamWriter(stream2);
            int count = 0;
            while (!reader1.EndOfStream)
            {
                string s = reader1.ReadLine();
                if (s.StartsWith("     "))
                {
                    count++;
                }
                if (count != k)                                     //'_'
                {                                                   //+-+
                    reader2.WriteLine(s);                           //=_= 
                }                                                   //-_-
            }                                                       //*_*
            reader1.Close();                                        //"_"
            stream1.Close();
            reader2.Close();
            stream2.Close();
            File.Delete(fileName1);
            File.Move("textfile25_1", fileName1);
        }

        public static void Text28()
        {
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream("textfile25_1", FileMode.Create, FileAccess.Write);
            StreamWriter reader2 = new StreamWriter(stream2);
            bool count = false;
            while (!reader1.EndOfStream)
            {
                string s = reader1.ReadLine();
                if (s.StartsWith("     "))
                {
                    if (count)
                    {
                        reader2.WriteLine("");
                    }
                }
                reader2.WriteLine(s);
                count = true;
            }
            reader1.Close();
            stream1.Close();
            reader2.Close();
            stream2.Close();
            File.Delete(fileName1);
            File.Move("textfile25_1", fileName1);
        }

        public static void Text29()
        {
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            string max = "";
            while (!reader1.EndOfStream)
            {
                string s = reader1.ReadLine();
                string[] array = s.Split(' ');
                for (int i = 0; i < array.Length; i++)
                {
                    if (max.Length < array[i].Length)
                    {
                        max = array[i];
                    }
                }
            }
            reader1.Close();
            stream1.Close();
            Console.WriteLine(max == null ? "в тексте нет слов" : max);
        }

        public static void Text30()
        {
            string fileName1 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            string min = null;
            while (!reader1.EndOfStream)
            {
                string s = reader1.ReadLine();
                string[] array = s.Split(' ');
                for (int i = 0; i < array.Length; i++)
                {
                    if ((min == null || min.Length >= array[i].Length) && min != "")
                    {
                        min = array[i];
                    }
                }
            }
            reader1.Close();
            stream1.Close();
            Console.WriteLine(min == null ? "" : min);
        }

        public static void Text31()
        {
            int k = int.Parse(Console.ReadLine());
            string fileName1 = Console.ReadLine();
            string fileName2 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
            BinaryWriter writer = new BinaryWriter(stream2);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsPunctuation(s[i]))
                    {
                        s = s.Replace(s[i], ' ');
                    }
                }
                string[] array = s.Split(' ');
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length == k)
                    {
                        writer.Write(array[i]);
                    }
                }
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text32()
        {
            char c = Console.ReadLine()[0];
            string fileName1 = Console.ReadLine();
            string fileName2 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
            BinaryWriter writer = new BinaryWriter(stream2);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsPunctuation(s[i]))
                    {
                        s = s.Replace(s[i], ' ');
                    }
                }
                string[] array = s.Split(' ');
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].ToUpper().StartsWith(c))
                    {
                        writer.Write(array[i]);
                    }
                }
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text33()
        {
            char c = Console.ReadLine()[0];
            string fileName1 = Console.ReadLine();
            string fileName2 = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
            BinaryWriter writer = new BinaryWriter(stream2);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsPunctuation(s[i]))
                    {
                        s = s.Replace(s[i], ' ');
                    }
                }
                string[] array = s.Split(' ');
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].ToLower().Contains(c))
                    {
                        writer.Write(array[i]);
                    }
                }
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text34()
        {
            string fileName = Console.ReadLine();
            ToWord(fileName, 50);
            File.Delete(fileName);
            FileStream stream1 = new FileStream("Word.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream1);
            FileStream stream3 = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter reader4 = new StreamWriter(stream3);
            while (!reader2.EndOfStream)
            {
                string s = reader2.ReadLine();
                while (s.Length < 50) s = ' ' + s;
                reader4.WriteLine(s);
            }
            reader2.Close();
            reader4.Close();
            stream1.Close();
            stream3.Close();
            File.Delete("Word.txt");
        }

        public static void Text35()
        {
            string fileName = Console.ReadLine();
            ToWord(fileName, 50);
            File.Delete(fileName);
            FileStream stream1 = new FileStream("Word.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream1);
            FileStream stream3 = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter reader4 = new StreamWriter(stream3);
            while (!reader2.EndOfStream)
            {
                string s = reader2.ReadLine();
                for (int i = 0; i < (50 - s.Length) / 2; i++) s = ' ' + s;
                reader4.WriteLine(s);
            }
            reader2.Close();
            reader4.Close();
            stream1.Close();
            stream3.Close();
            File.Delete("Word.txt");
        }

        public static void Text36()
        {
            string fileName = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream1);
            FileStream stream3 = new FileStream("textFile36_1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter reader4 = new StreamWriter(stream3);
            while (!reader2.EndOfStream)
            {
                string s = reader2.ReadLine();
                s = s.Trim();
                for (int i = 0; i < (50 - s.Length) / 2; i++) s = ' ' + s;
                reader4.WriteLine(s);
            }
            reader2.Close();
            reader4.Close();
            stream1.Close();
            stream3.Close();
            File.Delete(fileName);
            File.Move("textFile36_1.txt", fileName);
        }

        public static void Text37()
        {
            string fileName = Console.ReadLine();
            FileStream stream1 = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream1);
            FileStream stream3 = new FileStream("textFile37_1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter reader4 = new StreamWriter(stream3);
            string prev = reader2.ReadLine();
            while (!reader2.EndOfStream)
            {
                string s = reader2.ReadLine();
                if (s == "")
                {
                    reader4.WriteLine(prev);
                }
                else
                {
                    string[] array = prev.Split(' ');
                    int count = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] != "") count++;
                    }
                    string space = "";
                    for (int i = 0; i < (50 - prev.Length) / (count - 1); i++)
                    {
                        space += " ";
                    }
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] != "") array[i] += space;
                    }
                    for (int j = 2, i = (50 - prev.Length) % (count - 1); i > 0; i--, j++)
                    {
                        if (array[^j] != "")
                        {
                            array[^j] += " ";
                        }
                        else
                        {
                            i++;
                        }
                    }
                    for (int i = 0; i < array.Length - 1; i++) reader4.Write(array[i] + ' ');
                    reader4.WriteLine(array[^1]);
                }
                prev = s;
            }
            reader4.WriteLine(prev);
            reader2.Close();
            reader4.Close();
            stream1.Close();
            stream3.Close();
            File.Delete(fileName);
            File.Move("textFile37_1.txt", fileName);
        }

        public static void Text38()
        {
            byte k = byte.Parse(Console.ReadLine());
            string fileName1 = Console.ReadLine();
            string fileName2 = Console.ReadLine();
            ToWord(fileName1, k);
            File.Move("Word.txt", fileName2);
            File.Delete("Word.txt");
        }

        public static void Text39()
        {
            byte k = byte.Parse(Console.ReadLine());
            string fileName1 = Console.ReadLine();
            string fileName2 = Console.ReadLine();
            ToWord(fileName1, k);
            File.Move("Word.txt", fileName2);
            File.Delete("Word.txt");
        }

        public static void Text40()
        {
            string binFileName1 = Console.ReadLine();
            string binFileName2 = Console.ReadLine();
            string textFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(binFileName1, FileMode.Open, FileAccess.Read);
            BinaryReader reader1 = new BinaryReader(stream1);
            FileStream stream2 = new FileStream(binFileName2, FileMode.Open, FileAccess.Read);
            BinaryReader reader2 = new BinaryReader(stream2);
            FileStream stream3 = new FileStream(textFileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream3);
            for (int i = 0; i < stream1.Length / 4; i++)
            {
                string res = "|";
                string value = reader1.ReadInt32().ToString();
                while (res.Length + value.Length <= 30) res += ' ';
                res += value;
                value = reader2.ReadInt32().ToString();
                while (res.Length + value.Length <= 60) res += ' ';
                res += value + '|';
                writer.WriteLine(res);
            }
            writer.Close();
            stream3.Close();
            reader2.Close();
            stream2.Close();
            reader1.Close();
            stream1.Close();
        }

        public static void Text41()
        {
            BinaryReader[] array = new BinaryReader[3];
            for (int i = 0; i < 3; i++)
            {
                array[i] = new BinaryReader(new FileStream(
                    Console.ReadLine(), FileMode.Open, FileAccess.Read));
            }
            string textFileName = Console.ReadLine();
            FileStream stream = new FileStream(textFileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            for (int i = 0; i < array[0].BaseStream.Length / 4; i++)
            {
                string res = "|";
                for (int j = 0; j < 3; j++)
                {
                    string value = array[j].ReadInt32().ToString();
                    res += value;
                    while (res.Length <= 20 * (j + 1) + 1) res += ' ';
                }
                writer.WriteLine(res + '|');
            }
            writer.Close();
            stream.Close();
            for (int i = 0; i < 3; i++)
            {
                array[i].Close();
                array[i].BaseStream.Close();
            }
        }

        public static void Text42()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string textFileName = Console.ReadLine();
            FileStream stream = new FileStream(textFileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            for (double i = a; i <= b; i += (b - a) / n)
            {
                string s = Math.Round(i, 4).ToString();
                while (s.Length <= 10) s = ' ' + s;
                s += Math.Round(Math.Sqrt(i), 8).ToString();
                while (s.Length <= 25) s = ' ' + s;
                writer.WriteLine(s);
            }
            writer.Close();
            stream.Close();
        }

        public static void Text43()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string textFileName = Console.ReadLine();
            FileStream stream = new FileStream(textFileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            for (double i = a; i <= b; i += (b - a) / n)
            {
                string s = Math.Round(i, 4).ToString();
                while (s.Length <= 8) s = ' ' + s;
                s += Math.Round(Math.Sin(i), 8).ToString();
                while (s.Length <= 20) s = ' ' + s;
                s += Math.Round(Math.Cos(i), 8).ToString();
                while (s.Length <= 32) s = ' ' + s;
                writer.WriteLine(s);
            }
            writer.Close();
            stream.Close();
        }

        public static void Text44()
        {
            string textFileName = Console.ReadLine();
            FileStream stream = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int count = 0;
            int sum = 0;
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                s = s.Trim();
                sum += int.Parse(s);
                count++;
            }
            reader.Close();
            stream.Close();
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }

        public static void Text45()
        {
            string textFileName = Console.ReadLine();
            FileStream stream = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int count = 0;
            double sum = 0;
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                s = s.Trim();
                double value = double.Parse(s);
                if (value != (int)value)
                {
                    sum += value;
                    count++;
                }
            }
            reader.Close();
            stream.Close();
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }

        public static void Text46()
        {
            string textFileName = Console.ReadLine();
            string binFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream(binFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                s = s.Trim();
                double value = double.Parse(s);
                if (value != (int)value)
                {
                    writer.Write(value);
                }
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text47()
        {
            string textFileName = Console.ReadLine();
            FileStream stream = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int count = 0;
            double sum = 0;
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                s = s.Trim();
                double value = double.Parse(s);
                if (value == (int)value)
                {
                    sum += value;
                    count++;
                }
            }
            reader.Close();
            stream.Close();
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }

        public static void Text48()
        {
            string textFileName = Console.ReadLine();
            string binFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream(binFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                s = s.Trim();
                double value = double.Parse(s);
                if (value == (int)value)
                {
                    writer.Write(value);
                }
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text49()
        {
            string textFileName = Console.ReadLine();
            string binFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            FileStream stream2 = new FileStream(binFileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader2 = new BinaryReader(stream2);
            FileStream stream3 = new FileStream("text49_1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream3);
            int i = 0;
            for (; !reader1.EndOfStream && i < stream2.Length / 4; i++)
            {
                string s1 = reader1.ReadLine();
                string s2 = reader2.ReadInt32().ToString();
                s1 += s2;
                writer.WriteLine(s1);
            }
            while (!reader1.EndOfStream)
            {
                writer.WriteLine(reader1.ReadLine());
            }
            for (; i < stream2.Length / 4; i++)
            {
                writer.WriteLine(reader2.ReadInt32());
            }
            reader1.Close();
            stream1.Close();
            reader2.Close();
            stream2.Close();
            writer.Close();
            stream3.Close();
            File.Delete(textFileName);
            File.Move("text49_1.txt", textFileName);
        }

        public static void Text50()
        {
            string textFileName = Console.ReadLine();
            string stringFileName = Console.ReadLine();
            string binFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream(stringFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer1 = new BinaryWriter(stream2);
            FileStream stream3 = new FileStream(binFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer2 = new BinaryWriter(stream3);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                writer1.Write(s.Remove(30));
                writer2.Write(s.Substring(30));
            }
            reader.Close();
            stream1.Close();
            writer1.Close();
            stream2.Close();
            writer2.Close();
            stream3.Close();
        }

        public static void Text51()
        {
            string textFileName = Console.ReadLine();
            BinaryWriter[] array = new BinaryWriter[3];
            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                array[i] = new BinaryWriter(new FileStream(name, FileMode.Create, FileAccess.Write));
            }
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                int lenght = s.Length / 3;
                for (int i = 0; i < 3; i++)
                {
                    array[i].Write(double.Parse(s.Substring(lenght * i, lenght)));
                }
            }
            reader.Close();
            stream1.Close();
            for (int i = 0; i < 3; i++)
            {
                array[i].Close();
                array[i].BaseStream.Close();
            }
        }

        public static void Text52()
        {
            string textFileName = Console.ReadLine();
            BinaryWriter[] array = new BinaryWriter[3];
            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                array[i] = new BinaryWriter(new FileStream(name, FileMode.Create, FileAccess.Write));
            }
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                int lenght = (s.Length - 2) / 3;
                for (int i = 0; i < 3; i++)
                {
                    array[i].Write(int.Parse(s.Substring(lenght * i + i, lenght)));
                }
            }
            reader.Close();
            stream1.Close();
            for (int i = 0; i < 3; i++)
            {
                array[i].Close();
                array[i].BaseStream.Close();
            }
        }

        public static void Text53()
        {
            string textFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            string charFileName = Console.ReadLine();
            FileStream stream2 = new FileStream(charFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsPunctuation(s[i]))
                    {
                        writer.Write(s[i]);
                    }
                }
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text54()
        {
            string textFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            string charFileName = Console.ReadLine();
            FileStream stream2 = new FileStream(charFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            char[] array = new char[0];
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (!array.Contains(s[i]))
                    {
                        writer.Write(s[i]);
                        Array.Insert(array, 0, s[i]);
                    }
                }
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text55()
        {
            string textFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            string charFileName = Console.ReadLine();
            FileStream stream2 = new FileStream(charFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            char[] array = new char[0];
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (!array.Contains(s[i]))
                    {
                        Array.Insert(array, 0, s[i]);
                    }
                }
            }
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
                writer.Write(array[min]);
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text56()
        {
            string textFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            string charFileName = Console.ReadLine();
            FileStream stream2 = new FileStream(charFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            char[] array = new char[0];
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (!array.Contains(s[i]))
                    {
                        Array.Insert(array, 0, s[i]);
                    }
                }
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[max] < array[j])
                    {
                        max = j;
                    }
                }
                Proc.Swap(ref array[i], ref array[max]);
                writer.Write(array[max]);
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text57()
        {
            string textFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            string stringFileName = Console.ReadLine();
            FileStream stream2 = new FileStream(stringFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            (char, int)[] array = new (char, int)[0];
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] >= 'а' && s[i] <= 'я')
                    {
                        bool marker = true;
                        for (int j = 0; j < array.Length; j++)
                        {
                            if (array[j].Item1 == s[i])
                            {
                                array[j].Item2++;
                                marker = false;
                                break;
                            }
                        }
                        if (marker)
                        {
                            Array.Insert(array, 0, (s[i], 1));
                        }
                    }
                }
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min].Item1 > array[j].Item1)
                    {
                        min = j;
                    }
                }
                Proc.Swap(ref array[i], ref array[min]);
                writer.Write($"{array[min].Item1}-{array[min].Item2}");
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text58()
        {
            string textFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            string stringFileName = Console.ReadLine();
            FileStream stream2 = new FileStream(stringFileName, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream2);
            (char, int)[] array = new (char, int)[0];
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] >= 'а' && s[i] <= 'я')
                    {
                        bool marker = true;
                        for (int j = 0; j < array.Length; j++)
                        {
                            if (array[j].Item1 == s[i])
                            {
                                array[j].Item2++;
                                marker = false;
                                break;
                            }
                        }
                        if (marker)
                        {
                            Array.Insert(array, 0, (s[i], 1));
                        }
                    }
                }
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min].Item2 < array[j].Item2 ||
                        (array[min].Item2 == array[j].Item2 &&
                        array[min].Item1 > array[j].Item1))
                    {
                        min = j;
                    }
                }
                Proc.Swap(ref array[i], ref array[min]);
                writer.Write($"{array[min].Item1}-{array[min].Item2}");
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
        }

        public static void Text59()
        {
            string s = Console.ReadLine();
            string textFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream("временный файл.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            while (!reader.EndOfStream)
            {
                string input = reader.ReadLine();
                string output = "";
                for (int i = 0; i < input.Length; i++)
                {
                    if ((input[i] >= 'а' && input[i] <= 'я') || (input[i] >= 'А' && input[i] <= 'Я'))
                    {
                        if (Char.ToLower(input[i]) + s[i % 10] - '0' > 'я')
                        {
                            output += (Char.IsLower(input[i]) ? 'а' : 'А') + (Char.ToLower(input[i]) + s[i % 10] - '0' - 'я' - 1);
                        }
                        else
                        {
                            output += input[i] + s[i % 10] - '0';
                        }
                    }
                    else
                    {
                        output += input[i];
                    }
                }
                writer.WriteLine(output);
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
            File.Delete(textFileName);
            File.Move("временный файл.txt", textFileName);
        }

        public static void Text60()
        {
            string s = Console.ReadLine();
            string textFileName = Console.ReadLine();
            FileStream stream1 = new FileStream(textFileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream("временный файл.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            string input = reader.ReadLine();
            byte?[] array = new byte?[10];
            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] >= 'а' && input[i] <= 'я') || (input[i] >= 'А' && input[i] <= 'Я'))
                {
                    array[i % 10] = (byte)(s[i] - input[i]); 
                }
            }
            writer.WriteLine(s);
            while (!reader.EndOfStream)
            {
                input = reader.ReadLine();
                string output = "";
                for (int i = 0; i < input.Length; i++)
                {
                    if ((input[i] >= 'а' && input[i] <= 'я') || (input[i] >= 'А' && input[i] <= 'Я'))
                    {
                        if (array[i % 10] == null)
                        {
                            Console.WriteLine("данных для расшифровки недостаточно");
                            writer.Close();
                            stream2.Close();
                            File.Delete("временный файл.txt");
                            reader.Close();
                            stream1.Close();
                            return;
                        }
                        if (Char.ToLower(input[i]) - array[i % 10] < 'а')
                        {
                            output += (Char.IsLower(input[i]) ? 'я' : 'Я') + (Char.ToLower(input[i]) - 'а' - s[i] + 1);
                        }
                        else
                        {
                            output += input[i] - s[i];
                        }
                    }
                    else
                    {
                        output += input[i];
                    }
                }
                writer.WriteLine(output);
            }
            reader.Close();
            stream1.Close();
            writer.Close();
            stream2.Close();
            File.Delete(textFileName);
            File.Move("временный файл.txt", textFileName);
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

        public static void ToWord(string fileName, byte lenght)
        {
            FileStream stream1 = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);
            FileStream stream2 = new FileStream("Word.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream2);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(s))
                {
                    writer.WriteLine(s);
                    continue;
                }
                string[] array = s.Split(' ');
                string value = "";
                for (int i = 0; i < array.Length; i++)
                {
                    if (value.Length + array[i].Length + (value != "" ? 1 : 0) <= lenght)
                    {
                        value += (value != "" ? ' ' : "") + array[i];
                    }
                    else
                    {
                        writer.WriteLine(value);
                        value = array[i];
                    }
                }
                writer.WriteLine(value);
            }
            reader.Close();
            writer.Close();
            stream1.Close();
            stream2.Close();
        }
    }
}
