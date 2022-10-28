namespace IlyaCodeTest.Begin
{
    public class Begin1
    {

        [Test]
        public void Begin1_1()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "1", "1");
            backInput.WriteLine("1");
            string res = backOutput.ReadLine();
            Assert.AreEqual(int.Parse(res), 4);
            backInput.WriteLine();
        }

        [Test]
        public void Begin1_2()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "1", "1");
            backInput.WriteLine("2");
            string res = backOutput.ReadLine();
            Assert.AreEqual(int.Parse(res), 8);
            backInput.WriteLine();
        }

        [Test]
        public void Begin1_3()
        {
            StreamWriter backInput;
            StreamReader backOutput;
            Main.Start(out backInput, out backOutput, "1", "1");
            backInput.WriteLine("3");
            string res = backOutput.ReadLine();
            Assert.AreEqual(int.Parse(res), 12);
            backInput.WriteLine();
        }
    }
}