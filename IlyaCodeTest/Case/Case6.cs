namespace IlyaCodeTest.Case
{
    internal class Case6
    {
        [Test]
        public void Case6_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "6");
            backInput.WriteLine("1");
            backInput.WriteLine("56");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "5,6");
            backInput.WriteLine();
        }
        [Test]
        public void Case6_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "6");
            backInput.WriteLine("2");
            backInput.WriteLine("0,0056");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "5,6");
            backInput.WriteLine();
        }
        [Test]
        public void Case6_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "6");
            backInput.WriteLine("3");
            backInput.WriteLine("5,6");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "5,6");
            backInput.WriteLine();
        }
        [Test]
        public void Case6_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "6");
            backInput.WriteLine("4");
            backInput.WriteLine("5600");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "5,6");
            backInput.WriteLine();
        }
        [Test]
        public void Case6_5()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "6");
            backInput.WriteLine("5");
            backInput.WriteLine("560");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "5,6");
            backInput.WriteLine();
        }
    }
}
