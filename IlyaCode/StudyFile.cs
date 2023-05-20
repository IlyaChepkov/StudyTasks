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
            if (stream.Length / 4 >= k)
            {
                BinaryReader reader = new BinaryReader(stream);
                for (int i = 0; i < k - 1; i++)
                {
                    reader.ReadInt32();
                }
                Console.WriteLine(reader.ReadInt32());
                reader.Close();
            }
            else
            {
                Console.WriteLine(-1);
            }
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
    }
}
