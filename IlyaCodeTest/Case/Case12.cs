namespace IlyaCodeTest.Case
{
    internal class Case12
    {
        [Test]
        public void Case12_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "12");
            backInput.WriteLine(1);
            backInput.WriteLine(1);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "2");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "6,28");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "3,14");
            backInput.WriteLine();
        }

        [Test]
        public void Case12_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "12");
            backInput.WriteLine(2);
            backInput.WriteLine(2);
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "1");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "6,28");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "3,14");
            backInput.WriteLine();
        }

        [Test]
        public void Case12_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "12");
            backInput.WriteLine(3);
            backInput.WriteLine("6,28");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "1");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "2");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "3,14");
            backInput.WriteLine();
        }

        [Test]
        public void Case12_4()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "5", "12");
            backInput.WriteLine(4);
            backInput.WriteLine("3,14");
            string res = backOutput.ReadLine();
            Assert.AreEqual(res, "1");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "2");
            res = backOutput.ReadLine();
            Assert.AreEqual(res, "6,28");
            backInput.WriteLine();
        }
    }
}
