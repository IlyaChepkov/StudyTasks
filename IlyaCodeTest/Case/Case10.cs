namespace IlyaCodeTest.Case
{
    internal class Case10
    {
        [Test]
        public void Case10_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("С");
            backInput.WriteLine(-1);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "В");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("С");
            backInput.WriteLine(0);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "С");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("С");
            backInput.WriteLine(1);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "З");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("В");
            backInput.WriteLine(-1);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Ю");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_5()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("В");
            backInput.WriteLine(0);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "В");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_6()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("В");
            backInput.WriteLine(1);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "С");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_7()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("Ю");
            backInput.WriteLine(-1);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "З");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_8()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("Ю");
            backInput.WriteLine(0);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Ю");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_9()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("Ю");
            backInput.WriteLine(1);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "В");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_10()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("З");
            backInput.WriteLine(-1);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "С");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_11()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("З");
            backInput.WriteLine(0);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "З");
            backInput.WriteLine();
        }

        [Test]
        public void Case10_12()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "10");
            backInput.WriteLine("З");
            backInput.WriteLine(1);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "Ю");
            backInput.WriteLine();
        }
    }
}
